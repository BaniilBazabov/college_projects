namespace cs264Ass2.memento
{   
    class Memento
    {
    private readonly string savedState;

    private Memento(string stateToSave)
    {
        savedState = stateToSave;
    }

    public class Originator
    {
        private string state;
        // The class could also contain additional data that is not part of the
        // state saved in the memento.

        public void Set(string state)
        {
            Console.WriteLine("Originator: setting the canvas to: " + state);
            this.state = state;
        }

        public Memento SaveToMemento()
        {
            Console.WriteLine("Originator: Saving to Memento.");
            return new Memento(state);
        }

        public void RestoreFromMemento(Memento memento)
        {
            state = memento.savedState;
            Console.WriteLine("Originator: State after restoring from Memento: " + state);
        }
    }
}

class Caretaker
{
    // static void Main(string[] args)
    // {
    //     List<Memento> savedStates = new List<Memento>();

    //     Memento.Originator originator = new Memento.Originator();
    //     originator.Set("State1");
    //     originator.Set("State2");
    //     savedStates.Add(originator.SaveToMemento());
    //     originator.Set("State3");
    //     // We can request multiple mementos, and choose which one to roll back to.
    //     savedStates.Add(originator.SaveToMemento());
    //     originator.Set("State4");

    //     originator.RestoreFromMemento(savedStates[1]);
    // }
}
   
}