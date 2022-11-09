namespace cs264Ass2.memento
{
    class Originator
    {
        // For the sake of simplicity, the originator's state is stored inside a
        // single variable.
        private Canvas _state;

        public Originator(Canvas state)
        {
            this._state = state;
        }

        public Canvas getCurrentState()
        {
            return this._state;
        }


        
        // Saves the current state inside a memento.
        public Memento Save()
        {
            return new Memento(this._state);
        }

        // Restores the Originator's state from a memento object.
        public void Restore(Memento memento)
        {
            this._state = memento.GetState();
            Console.Write($"Originator: My state has changed to: {_state.ToSvg}");
        }
    }
}