using static System.Console;
namespace finalexam.memento
{
    class Caretaker
    {
        private List<Memento> _mementos = new List<Memento>();
        private List<Memento> _removedMementos = new List<Memento>();

        private Originator _originator = null;

        public Caretaker(Originator originator)
        {
            this._originator = originator;
        }

        public void Backup()
        {
            
            this._mementos.Add(this._originator.Save());
        }

        public void Undo()
        {
            
            if (this._mementos.Count == 1)
            {
                WriteLine("Nothing to undo!");
                return;
            }
            else
            {
                var memento = this._mementos.Last();
                _removedMementos.Add(memento);
                this._mementos.Remove(memento);
                this._originator.Restore(this._mementos.Last());
                WriteLine("Restored previous state");
            }
            

            

            
        }

        public void Redo()
        {
            if(this._removedMementos.Count == 0)
            {
                WriteLine("Nothing to redo!");
                return;
            }
            var memento = this._removedMementos.Last();
            _mementos.Add(memento);
            this._removedMementos.Remove(this._removedMementos.Last());

            try
            {
                this._originator.Restore(this._mementos.Last());
            }
            catch (Exception)
            {
                this.Redo();
            }

        }

        
    }
}