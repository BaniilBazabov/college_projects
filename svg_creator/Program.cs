using System;
using static System.Console;
namespace cs264Ass2
{

    //Users can add , update and delete shapes from here.
    class Program {         
        static void Main(string[] args)
        {
            memento.Originator originator = new memento.Originator(null);
            memento.Caretaker caretaker = new memento.Caretaker(originator);

            Canvas canvas = new Canvas(1000,1000);
            bool run =true;
            WriteLine("Good Day Dear Demonstrator!");
            WriteLine("Please input the shape you would like to add:");
            WriteLine("(Rectangle | Circle | Ellipse | Line | Polyline | Polygon | Path)");
            WriteLine("Input (Update | Delete) if you wish to do some changes :D");

            
            while(run) //when user needs is done, quits the program
            {

                
                string input = ReadLine(); //reads what user wants to do
                if(input.Contains("rectangle"))
                {
                    var currentState = originator.getCurrentState();
                    var newCanvas = new Canvas(canvas.getShapes(),1000,1000);
                    Rectangle rectangle = new Rectangle();
                    newCanvas.AddShape(rectangle);
                    originator.Restore(new memento.Memento(newCanvas));
                    caretaker.Backup();

                    WriteLine("Rectangle with random attributes has been added.");
                }
                else if(input.Contains("circle"))
                {   
                    var currentState = originator.getCurrentState();
                    var newCanvas = new Canvas(canvas.getShapes(),1000,1000);
                    Circle circle = new Circle();
                    newCanvas.AddShape(circle);
                    originator.Restore(new memento.Memento(newCanvas));
                    caretaker.Backup();
                    WriteLine("Circle with random attributes has been added.");
                }
                else if(input.Contains("ellipse"))
                {
                    var currentState = originator.getCurrentState();
                    var newCanvas = new Canvas(canvas.getShapes(),1000,1000);
                    Ellipse ellipse = new Ellipse();
                    newCanvas.AddShape(ellipse);
                    originator.Restore(new memento.Memento(newCanvas));
                    caretaker.Backup();
                    WriteLine("Ellipse with random attributes has been added.");
                    
                }
                else if(input.Contains("line"))
                {
                    var currentState = originator.getCurrentState();
                    var newCanvas = new Canvas(canvas.getShapes(),1000,1000);
                    Line line = new Line();
                    newCanvas.AddShape(line);
                    originator.Restore(new memento.Memento(newCanvas));
                    caretaker.Backup();
                    WriteLine("Line with random attributes has been added.");
                }
                else if(input.Contains("polyline"))
                {
                    var currentState = originator.getCurrentState();
                    var newCanvas = new Canvas(canvas.getShapes(),1000,1000);
                    Polyline polyline = new Polyline();
                    newCanvas.AddShape(polyline);
                    originator.Restore(new memento.Memento(newCanvas));
                    caretaker.Backup();
                    WriteLine("Polyline has been added.");
                }
                else if(input.Contains("polygon"))
                {
                    var currentState = originator.getCurrentState();
                    var newCanvas = new Canvas(canvas.getShapes(),1000,1000);
                    Polygon polygon = new Polygon();
                    newCanvas.AddShape(polygon);
                    originator.Restore(new memento.Memento(newCanvas));
                    caretaker.Backup();
                    WriteLine("Polygon has been added.");
                }
                else if(input.Contains("path"))
                {
                    var currentState = originator.getCurrentState();
                    var newCanvas = new Canvas(canvas.getShapes(),1000,1000);
                    Path path = new Path();
                    newCanvas.AddShape(path);
                    originator.Restore(new memento.Memento(newCanvas));
                    caretaker.Backup();
                    WriteLine("Path has been added.");
                }
                else if(input.ToLower()=="u") //Undo
                {
                    caretaker.Undo();

                    WriteLine("Restored previous state");
                    
                }
                else if (input.ToLower()=="r")
                {
                    
                }
                else if(input.ToLower()=="q") //exits the program
                {
                    run=!run;
                }

                else WriteLine("Incorrect input, please try again!");
                
            }
            Canvas.SaveFile(canvas.ToSvg() + Environment.NewLine); //saves the SVG to current directory.
            
            
            

        }
    }


public abstract class AbstractShape{
    public abstract string ToSvg(); 
}

}