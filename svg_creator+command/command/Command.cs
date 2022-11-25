using System;
namespace cs264Ass2.Command
{
    
    // Some commands can implement simple operations on their own.
    public abstract class Command 
    {

        public abstract void Execute();
        public abstract void UndoExecute();
        
            

    }

    
    
}