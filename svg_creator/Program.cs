using System;
using static System.Console;
namespace cs264Ass2
{

    //Users can add , update and delete shapes from here.
    class Program {         
        static void Main(string[] args)
        {
            List<memento.Memento> savedStates = new List<memento.Memento>();
            List<memento.Memento> undoneStates = new List<memento.Memento>();
            memento.Memento.Originator originator = new memento.Memento.Originator();
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
                    Rectangle rectangle = new Rectangle();
                    canvas.AddShape(rectangle);
                    originator.Set(Canvas.getShapes());
                    savedStates.Add(originator.SaveToMemento());
                    WriteLine("Rectangle with random attributes has been added.");
                }
                else if(input.Contains("circle"))
                { 
                    Circle circle = new Circle();
                    canvas.AddShape(circle);
                    originator.Set(Canvas.getShapes());
                    savedStates.Add(originator.SaveToMemento());
                    WriteLine("Circle with random attributes has been added.");
                }
                else if(input.Contains("ellipse"))
                {
                    Ellipse ellipse = new Ellipse();
                    canvas.AddShape(ellipse);
                    originator.Set(Canvas.getShapes());
                    savedStates.Add(originator.SaveToMemento());
                    WriteLine("Ellipse with random attributes has been added.");
                    
                }
                else if(input.Contains("line"))
                {
                    Line line = new Line();
                    canvas.AddShape(line);
                    originator.Set(Canvas.getShapes());
                    savedStates.Add(originator.SaveToMemento());
                    WriteLine("Line with random attributes has been added.");
                }
                else if(input.Contains("polyline"))
                {
                    Polyline polyline = new Polyline();
                    canvas.AddShape(polyline);
                    originator.Set(Canvas.getShapes());
                    savedStates.Add(originator.SaveToMemento());
                    WriteLine("Polyline has been added.");
                }
                else if(input.Contains("polygon"))
                {
                    Polygon polygon = new Polygon();
                    canvas.AddShape(polygon);
                    originator.Set(Canvas.getShapes());
                    savedStates.Add(originator.SaveToMemento());
                    WriteLine("Polygon has been added.");
                }
                else if(input.Contains("path"))
                {
                    Path path = new Path();
                    canvas.AddShape(path); 
                    originator.Set(Canvas.getShapes());
                    savedStates.Add(originator.SaveToMemento());
                    WriteLine("Path has been added.");
                }
                else if(input.ToLower()=="u") //Undo
                {
                    Int32 i = (savedStates.Count()-2);
                    undoneStates.Add(originator.SaveToMemento());
                    originator.RestoreFromMemento(savedStates[i]);
                    originator.removeMemento();
                    savedStates.RemoveAt(i+1);
                    Canvas.setCanvas(originator.getState());

                    WriteLine("Restored previous state");
                    foreach(var hueta in originator.getState())
                    {
                        WriteLine(hueta.ToString() + i);

                    }
                }
                else if (input.ToLower()=="r")
                {
                    savedStates.Add(undoneStates[undoneStates.Count()-1]);
                    originator.RestoreFromMemento(savedStates[savedStates.Count()-1]);
                    undoneStates.RemoveAt(undoneStates.Count()-1);
                    
                    

                    WriteLine("Undone previous change");
                    foreach(var hueta in originator.getState())
                    {
                        WriteLine(hueta.ToString());

                    }

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