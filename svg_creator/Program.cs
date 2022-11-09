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

            var canvas = new Canvas(1000,1000);
            bool run =true;
            Console.Clear();
            WriteLine("Good Day Dear Demonstrator! \n");
            Thread.Sleep(1000);
            WriteLine("What would you like to do? :D \n"+ "(H for help)");

            

            
            while(run) //when user needs is done, quits the program
            {

                
                string input = ReadLine(); //reads what user wants to do
                if(input.ToLower()==("a rectangle"))
                {
                    
                    var newCanvas = new Canvas(canvas.getShapes(),1000,1000);
                    Rectangle rectangle = new Rectangle();
                    newCanvas.AddShape(rectangle);
                    canvas.AddShape(rectangle);
                    originator.Restore(new memento.Memento(newCanvas));
                    caretaker.Backup();
                    Console.Clear();
                    WriteLine("Rectangle with random attributes has been added.");
                }
                else if(input.ToLower()==("a circle"))
                {   
                    var currentState = originator.getCurrentState();
                    var newCanvas = new Canvas(canvas.getShapes(),1000,1000);
                    Circle circle = new Circle();
                    newCanvas.AddShape(circle);
                    canvas.AddShape(circle);
                    originator.Restore(new memento.Memento(newCanvas));
                    caretaker.Backup();
                    Console.Clear();
                    WriteLine("Circle with random attributes has been added.");
                }
                else if(input.ToLower()==("a ellipse"))
                {
                    var currentState = originator.getCurrentState();
                    var newCanvas = new Canvas(canvas.getShapes(),1000,1000);
                    Ellipse ellipse = new Ellipse();
                    newCanvas.AddShape(ellipse);
                    canvas.AddShape(ellipse);
                    originator.Restore(new memento.Memento(newCanvas));
                    caretaker.Backup();
                    Console.Clear();
                    WriteLine("Ellipse with random attributes has been added.");
                    
                }
                else if(input.ToLower()==("a line"))
                {
                    var currentState = originator.getCurrentState();
                    var newCanvas = new Canvas(canvas.getShapes(),1000,1000);
                    Line line = new Line();
                    newCanvas.AddShape(line);
                    canvas.AddShape(line);
                    originator.Restore(new memento.Memento(newCanvas));
                    caretaker.Backup();
                    Console.Clear();
                    WriteLine("Line with random attributes has been added.");
                }
                else if(input.ToLower()==("a polyline"))
                {
                    var currentState = originator.getCurrentState();
                    var newCanvas = new Canvas(canvas.getShapes(),1000,1000);
                    Polyline polyline = new Polyline();
                    newCanvas.AddShape(polyline);
                    canvas.AddShape(polyline);
                    originator.Restore(new memento.Memento(newCanvas));
                    caretaker.Backup();
                    Console.Clear();
                    WriteLine("Polyline has been added.");
                }
                else if(input.ToLower()==("a polygon"))
                {
                    var currentState = originator.getCurrentState();
                    var newCanvas = new Canvas(canvas.getShapes(),1000,1000);
                    Polygon polygon = new Polygon();
                    newCanvas.AddShape(polygon);
                    canvas.AddShape(polygon);
                    originator.Restore(new memento.Memento(newCanvas));
                    caretaker.Backup();
                    Console.Clear();
                    WriteLine("Polygon has been added.");
                }
                else if(input.ToLower()==("a path"))
                {
                    var currentState = originator.getCurrentState();
                    var newCanvas = new Canvas(canvas.getShapes(),1000,1000);
                    Path path = new Path();
                    newCanvas.AddShape(path);
                    canvas.AddShape(path);
                    originator.Restore(new memento.Memento(newCanvas));
                    caretaker.Backup();
                    Console.Clear();
                    WriteLine("Path has been added.");
                }
                else if (input.ToLower()=="c")
                {
                    canvas.clearCanvas();
                    originator.Restore(new memento.Memento(canvas));
                    caretaker.Backup();
                    Console.Clear();
                    WriteLine("Canvas has been cleared");
                }
                else if(input.ToLower()=="u") //Undo
                {
                    
                    caretaker.Undo();
                    var zalupa = originator.getCurrentState();
                    canvas = zalupa;
                    Console.Clear();
                    WriteLine("Restored previous state");
                    
                    
                    
                }
                else if (input.ToLower()=="r")
                {
                    caretaker.Redo();
                    var zalupa = originator.getCurrentState();
                    canvas=zalupa;
                    Console.Clear();
                    WriteLine("Redo was successful");
                }
                else if(input.ToLower()=="q") //exits the program
                {
                    run=!run;
                }
                else if (input.ToLower()=="h")
                {
                    Console.Clear();
                    WriteLine("H: Help - displays this message \n" +
	 	            "A <shape>: Add	<shape>	to canvas \n" +
	 	            "U: Undo last operation \n" +
                    "R: Redo last operation \n" +
	 	            "C: Clear canvas \n" +
	 	            "Q: Quit application \n ");
                
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