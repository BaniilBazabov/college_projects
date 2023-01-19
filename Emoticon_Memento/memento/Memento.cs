namespace finalexam.memento
{   
    public class Memento
    {
        private Canvas _state;

        public Memento(Canvas state)
        {
            this._state = state;
            
        }

        // The Originator uses this method when restoring its state.
        public Canvas GetState()
        {
            return this._state;
        }
    }

    
   
}