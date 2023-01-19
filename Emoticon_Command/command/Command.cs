
namespace finalexam.Command
{
    
    // Some commands can implement simple operations on their own.
    public abstract class Command 
    {

        public abstract void Execute();
        public abstract void UndoExecute();
        
    }

    
    
}