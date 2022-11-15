using System;

namespace cs264Ass2
{
    class Invoker
    {
        private Command _onStart;

        private Command _onFinish;

        // Initialize commands.
        public void SetOnStart(Command command)
        {
            this._onStart = command;
        }

        public void SetOnFinish(Command command)
        {
            this._onFinish = command;
        }

        // The Invoker does not depend on concrete command or receiver classes.
        // The Invoker passes a request to a receiver indirectly, by executing a
        // command.
        public void DoSomethingImportant()
        {
            Console.WriteLine("Invoker: Does anybody want something done before I begin?");
            if (this._onStart is Command)
            {
                this._onStart.Execute();
            }
            
            Console.WriteLine("Invoker: ...doing something really important...");
            
            Console.WriteLine("Invoker: Does anybody want something done after I finish?");
            if (this._onFinish is Command)
            {
                this._onFinish.Execute();
            }
        }
    }
}