using System;
namespace cs264Ass2
{
    
    // Some commands can implement simple operations on their own.
    class Command 
    {
        List<Canvas> saved = new List<Canvas>();
        List<Canvas> undone = new List<Canvas>();
        private string _payload = string.Empty;

        public Command(string payload)
        {
            this._payload = payload;
        }

        public void Execute()
        {
            Console.WriteLine($"SimpleCommand: See, I can do simple things like printing ({this._payload})");
        }
    }

    
    
}