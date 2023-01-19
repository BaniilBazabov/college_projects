using finalexam.Command;
using finalexam.abstractFactory;
using static System.Console;

namespace finalexam
{
    class Program
    {
        static void Main(string[] args) //to run: dotnet start
        {
            bool run = true;
            var canvas = new Canvas(500,500);
            Invoker invoker = new Invoker();
            Console.Clear();
            WriteLine("Hi John, what can I do for you?");
            Thread.Sleep(1000);
            WriteLine("Type 'help' for a list of commands");
            Style style = new Style();
            canvas.AddShape(new Circle(new Style())); //initial yellow face, wont be changed, does not require command for it.
            LeftEyeFactory leftEyeFactory = new LeftEyeFactory();
            RightEyeFactory rightEyeFactory = new RightEyeFactory();            
            LeftBrowFactory leftBrowFactory = new LeftBrowFactory();
            RightBrowFactory rightBrowFactory = new RightBrowFactory();         //all factories used
            MouthFactory mouthFactory = new MouthFactory();
            CreateStyle styleFactory = new CreateStyle();

            while(run)
            {
                string input = ReadLine(); //initial (default) design for all is A.

                //*****Adding parts****
                if(input.ToLower()=="add left-eye")
                {
                    var LeftEye = leftEyeFactory.CreateShape(styleFactory.giveStyle());
                    var cmnd = new AddShapeCmnd(canvas, LeftEye);
                    invoker.AddCommand(cmnd);
                    Console.Clear();
                    WriteLine("Left eye with style A has been added.");
                }
                else if (input.ToLower()=="add right-eye")
                {
                    var RightEye = rightEyeFactory.CreateShape(styleFactory.giveStyle());
                    var cmnd = new AddShapeCmnd(canvas, RightEye);
                    invoker.AddCommand(cmnd);
                    Console.Clear();
                    WriteLine("Left eye with style A has been added.");
                }
                else if (input.ToLower()=="add left-brow")
                {
                    var leftBrow = leftBrowFactory.CreateShape(styleFactory.giveStyle());
                    var cmnd = new AddShapeCmnd(canvas, leftBrow);
                    invoker.AddCommand(cmnd);
                    Console.Clear();
                    WriteLine("Left Brow with style A has been added.");
                }
                else if (input.ToLower()=="add right-brow")
                {
                    var rightBrow = rightBrowFactory.CreateShape(styleFactory.giveStyle());
                    var cmnd = new AddShapeCmnd(canvas, rightBrow);
                    invoker.AddCommand(cmnd);
                    Console.Clear();
                    WriteLine("Right Brow with style A has been added.");
                }
                else if (input.ToLower()=="add mouth")
                {
                    var mouth = mouthFactory.CreateShape(styleFactory.giveStyle());
                    var cmnd = new AddShapeCmnd(canvas, mouth);
                    invoker.AddCommand(cmnd);
                    Console.Clear();
                    WriteLine("Mouth has been added.");  
                }
                //*****Removing parts based on ID implementation****
                else if(input.ToLower()=="remove left-eye")
                {
                    var toBeRemoved = canvas.getShape("lefteye");
                    var cmnd = new DeleteShapeCmnd(canvas, toBeRemoved);
                    invoker.AddCommand(cmnd);
                    
                    WriteLine("Left Eye has been deleted.");
                }
                else if(input.ToLower()=="remove right-eye")
                {
                    var toBeRemoved = canvas.getShape("righteye");
                    var cmnd = new DeleteShapeCmnd(canvas, toBeRemoved);
                    invoker.AddCommand(cmnd);
                    
                    WriteLine("Right Eye has been deleted.");
                }
                else if(input.ToLower()=="remove left-brow")
                {
                    var toBeRemoved = canvas.getShape("leftbrow");
                    var cmnd = new DeleteShapeCmnd(canvas, toBeRemoved);
                    invoker.AddCommand(cmnd);
                    
                    WriteLine("Left Brow has been deleted.");
                }
                else if(input.ToLower()=="remove right-brow")
                {
                    var toBeRemoved = canvas.getShape("rightbrow");
                    var cmnd = new DeleteShapeCmnd(canvas, toBeRemoved);
                    invoker.AddCommand(cmnd);
                    
                    WriteLine("Right Brow has been deleted.");
                }
                else if(input.ToLower()=="remove mouth")
                {
                    var toBeRemoved = canvas.getShape("mouth");
                    var cmnd = new DeleteShapeCmnd(canvas, toBeRemoved);
                    invoker.AddCommand(cmnd);
                    
                    WriteLine("Mouth has been deleted.");
                }
                //*****Moving parts based on ID implementation****
                else if(input.Contains("move left-eye"))
                {
                    string [] ar = input.Split(" "); string direction = ar[2]; int value = Int32.Parse(ar[3]);
                    var toBeUpdated = canvas.getShape("lefteye");
                    var cmnd = new UpdateShapeCmnd(canvas,toBeUpdated,direction,value);
                    invoker.AddCommand(cmnd);
                    WriteLine("Left Eye has been updated");
                }
                else if(input.Contains("move right-eye"))
                {
                    string [] ar = input.Split(" "); string direction = ar[2]; int value = Int32.Parse(ar[3]);
                    var toBeUpdated = canvas.getShape("righteye");
                    var cmnd = new UpdateShapeCmnd(canvas,toBeUpdated,direction,value);
                    invoker.AddCommand(cmnd);
                    WriteLine("right Eye has been updated");
                }
                else if(input.Contains("move left-brow"))
                {
                    string [] ar = input.Split(" "); string direction = ar[2]; int value = Int32.Parse(ar[3]);
                    var toBeUpdated = canvas.getShape("leftbrow");
                    var cmnd = new UpdateShapeCmnd(canvas,toBeUpdated,direction,value);
                    invoker.AddCommand(cmnd);
                    WriteLine("Left Brow has been updated");
                }
                else if(input.Contains("move right-brow"))
                {
                    string [] ar = input.Split(" "); string direction = ar[2]; int value = Int32.Parse(ar[3]);
                    var toBeUpdated = canvas.getShape("rightbrow");
                    var cmnd = new UpdateShapeCmnd(canvas,toBeUpdated,direction,value);
                    invoker.AddCommand(cmnd);
                    WriteLine("Right Brow has been updated");
                }
                else if(input.Contains("move mouth"))
                {
                    string [] ar = input.Split(" "); string direction = ar[2]; int value = Int32.Parse(ar[3]);
                    var toBeUpdated = canvas.getShape("mouth");
                    var cmnd = new UpdateShapeCmnd(canvas,toBeUpdated,direction,value);
                    invoker.AddCommand(cmnd);
                    WriteLine("Mouth has been updated");
                }
                else if(input.Contains("move mouth"))
                {
                    string [] ar = input.Split(" "); string direction = ar[2]; int value = Int32.Parse(ar[3]);
                    var toBeUpdated = canvas.getShape("mouth");
                    var cmnd = new UpdateShapeCmnd(canvas,toBeUpdated,direction,value);
                    invoker.AddCommand(cmnd);
                    WriteLine("Mouth has been updated");
                }
                //*****Style updates based on ID implementation****
                else if(input.Contains("style left-eye"))
                {
                    string [] ar = input.Split(" "); string wantedStyle = ar[2]; 
                    var toBeUpdated = canvas.getShape("lefteye");
                    var cmnd = new UpdateStyleCmnd(canvas, toBeUpdated, style.getColor(wantedStyle));
                    invoker.AddCommand(cmnd);
                    WriteLine("Left Eye has been updated");
                }
                else if(input.Contains("style right-eye"))
                {
                    string [] ar = input.Split(" "); string wantedStyle = ar[2]; 
                    var toBeUpdated = canvas.getShape("righteye");
                    var cmnd = new UpdateStyleCmnd(canvas, toBeUpdated, style.getColor(wantedStyle));
                    invoker.AddCommand(cmnd);
                    WriteLine("Right Eye has been updated");
                }
                else if(input.Contains("style left-brow"))
                {
                    string [] ar = input.Split(" "); string wantedStyle = ar[2]; 
                    var toBeUpdated = canvas.getShape("leftbrow");
                    var cmnd = new UpdateStyleCmnd(canvas, toBeUpdated, style.getColor(wantedStyle));
                    invoker.AddCommand(cmnd);
                    WriteLine("Left Brow has been updated");
                }
                else if(input.Contains("style right-brow"))
                {
                    string [] ar = input.Split(" "); string wantedStyle = ar[2]; 
                    var toBeUpdated = canvas.getShape("rightbrow");
                    var cmnd = new UpdateStyleCmnd(canvas, toBeUpdated, style.getColor(wantedStyle));
                    invoker.AddCommand(cmnd);
                    WriteLine("Right Brow has been updated");
                }
                else if(input.Contains("style mouth"))
                {
                    string [] ar = input.Split(" "); string wantedStyle = ar[2]; 
                    var toBeUpdated = canvas.getShape("mouth");
                    var cmnd = new UpdateStyleCmnd(canvas, toBeUpdated, style.getColor(wantedStyle));
                    invoker.AddCommand(cmnd);
                    WriteLine("Mouth has been updated");
                }

                
                else if(input.ToLower()=="draw") //displays the SVG to command line.
                {
                    WriteLine(canvas.ToSvg());
                }
                else if(input.ToLower()=="undo") //Undo
                {
                    invoker.Undo();
                    Console.Clear();
                    WriteLine("Restored previous state");
                }
                else if (input.ToLower()=="redo")  //Redo
                {  
                    invoker.Redo();
                    Console.Clear();
                    WriteLine("Redo was successful");
                }
                else if(input.Contains("save")) //saved the file in current directory with given name and format
                {
                    string[] ar = input.Split(" ");
                    string name = ar[1];
                    Program.SaveFile(canvas.ToSvg()+Environment.NewLine,name);
                }
                else if(input.ToLower()=="quit"){WriteLine("Thanks for everything and good luck!"); run=false;}
                else if(input.ToLower()=="help")
                {
                    WriteLine("add {left-eye|right-eye|left-brow|right-brow|mouth}");
                    WriteLine("remove {left-eye|right-eye|left-brow|right-brow|mouth}");
                    WriteLine("move {left-eye|right-eye|left-brow|right-brow|mouth} {up|down|left|right} value");
                    WriteLine("rotate - has not been implemented");
                    WriteLine("style {left-eye|right-eye|left-brow|right-brow|mouth} {A|B|C}");
                    WriteLine("save {<file>}");
                    WriteLine("draw");
                    WriteLine("undo");
                    WriteLine("redo");
                    WriteLine("help");
                    WriteLine("quit");
                }

            }
            

        }
        public static async Task SaveFile(string text,string name)
        {
            await File.WriteAllTextAsync(name, text);
        }
    }

    public abstract class AbstractShape
    {
        public abstract void UpdateStyle(string color); //updates style of parts
        public abstract void UpdateShape(string direction, int value); //move
        public abstract string ToSvg(); //converts objects to svg
        public abstract string getId(); //gets the id of given part.
    }
}