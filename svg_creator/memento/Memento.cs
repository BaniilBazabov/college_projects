namespace cs264Ass2.memento
{   
    public class Memento
    {
    private readonly List<AbstractShape>  savedState;

    private Memento(List<AbstractShape>  stateToSave)
    {
        savedState = stateToSave;
    }

    public class Originator
    {
        public List<AbstractShape> state;
        // The class could also contain additional data that is not part of the
        // state saved in the memento.

        public void Set(List<AbstractShape>  state)
        {
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
            
        }
        public void removeMemento()
        {
            state.RemoveAt(state.Count()-1);
        }
        public void setState (List<AbstractShape> l)
        {
            state = l;
        }
        public List<AbstractShape>  getState()
        {
            return state;
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