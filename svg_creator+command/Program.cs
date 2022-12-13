using System;
using static System.Console;
using cs264Ass2.Command;
using cs264Ass2.abstractFactory;
namespace cs264Ass2
{

    //Users can add , update and delete shapes from here.
    class Program {         
        static void Main(string[] args)
        {

            var canvas = new Canvas(1000,1000);
            Invoker invoker = new Invoker();
            bool run =true;
            Console.Clear();
            WriteLine("Good Day Dear Demonstrator! \n");
            Thread.Sleep(1000);
            WriteLine("What would you like to do? :D \n"+ "(H for help)");

            RectangleFactory rectangleFactory = new RectangleFactory();  //init all factories that are going to be used
            CircleFactory circleFactory = new CircleFactory();           //Style factory is created with each shape since its random
            EllipseFactory ellipseFactory = new EllipseFactory();        //to be optimised in lab!
            PolygonFactory polygonFactory = new PolygonFactory();
            PolylineFactory polylineFactory = new PolylineFactory();
            LineFactory lineFactory = new LineFactory();
            PathFactory pathFactory = new PathFactory();

            CreateStyle styleFactory = new CreateStyle();
            
            
            

            
            while(run) //when user needs is done, quits the program
            {

                
                string input = ReadLine(); //reads what user wants to do
                if(input.ToLower()==("a rectangle"))
                {
                    var rectangle = rectangleFactory.CreateShape(styleFactory.giveStyle());
                    var cmnd = new AddShapeCmnd(canvas, rectangle);
                    invoker.AddCommand(cmnd);
                    Console.Clear();
                    WriteLine("Rectangle with random attributes has been added.");
                }
                else if(input.ToLower()==("a circle"))
                {   
                    var circle = circleFactory.CreateShape(styleFactory.giveStyle());
                    var cmnd = new AddShapeCmnd(canvas, circle);
                    invoker.AddCommand(cmnd);
                    Console.Clear();
                    WriteLine("Circle with random attributes has been added.");
                }
                else if(input.ToLower()==("a ellipse"))
                {
                    var ellipse = ellipseFactory.CreateShape(styleFactory.giveStyle());
                    var cmnd = new AddShapeCmnd(canvas, ellipse);
                    invoker.AddCommand(cmnd);
                    Console.Clear();
                    WriteLine("Ellipse with random attributes has been added.");
                    
                }
                else if(input.ToLower()==("a line"))
                {
                    
                    var line = lineFactory.CreateShape(styleFactory.giveStyle());
                    var cmnd = new AddShapeCmnd(canvas, line);
                    invoker.AddCommand(cmnd);
                    Console.Clear();
                    WriteLine("Line with random attributes has been added.");
                }
                else if(input.ToLower()==("a polyline"))
                {
                    var polyline = polygonFactory.CreateShape(styleFactory.giveStyle());
                    var cmnd = new AddShapeCmnd(canvas, polyline);
                    invoker.AddCommand(cmnd);
                    Console.Clear();
                    WriteLine("Polyline has been added.");
                }
                else if(input.ToLower()==("a polygon"))
                {
                    var polygon =  polygonFactory.CreateShape(styleFactory.giveStyle());
                    var cmnd = new AddShapeCmnd(canvas, polygon);
                    invoker.AddCommand(cmnd);
                    Console.Clear();
                    WriteLine("Polygon has been added.");
                }
                else if(input.ToLower()==("a path"))
                {
                    var path = pathFactory.CreateShape(styleFactory.giveStyle());
                    var cmnd = new AddShapeCmnd(canvas, path);
                    invoker.AddCommand(cmnd);
                    Console.Clear();
                    WriteLine("Path has been added.");
                }
                else if(input.ToLower()=="u") //Undo
                {
                    invoker.Undo();
                    Console.Clear();
                    WriteLine("Restored previous state");
                }
                else if (input.ToLower()=="r")
                {  
                    invoker.Redo();
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
                    "S: Display canvas in terminal \n" +
	 	            "A <shape>: Add <shape>	to canvas \n" +
	 	            "U: Undo last operation \n" +
                    "R: Redo last operation \n" +
	 	            "Q: Quit application \n ");
                
                }
                else if (input.ToLower()=="s")
                {
                    WriteLine(canvas.ToSvg());
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