using System;
using static System.Console;
using cs264Ass2.abstractFactory;
namespace cs264Ass2
{

    //Users can add , update and delete shapes from here.
    class Program {         
        static void Main(string[] args)
        {
            RectangleFactory rectangleFactory = new RectangleFactory();  //init all factories that are going to be used
            CircleFactory circleFactory = new CircleFactory();           //Style factory is created with each shape since its random
            EllipseFactory ellipseFactory = new EllipseFactory();        //to be optimised in lab!
            PolygonFactory polygonFactory = new PolygonFactory();
            PolylineFactory polylineFactory = new PolylineFactory();
            LineFactory lineFactory = new LineFactory();
            PathFactory pathFactory = new PathFactory();
            Canvas canvas = new Canvas(1000,1000);
            bool run =true;
            WriteLine("Good Day Dear Demonstrator!");
            WriteLine("Please input the shape you would like to add:");
            WriteLine("(Rectangle | Circle | Ellipse | Line | Polyline | Polygon | Path)");
            WriteLine("Input (Update | Delete) if you wish to do some changes :D");

            
            while(run) //when user needs is done, quits the program
            {
                
                string input = ReadLine(); //reads what user wants to do
                if(input.ToLower()=="rectangle")
                {
                    var rectangle = rectangleFactory.CreateShape(new Style());
                    canvas.AddShape(rectangle);
                    WriteLine("Any other shapes/changes would you like to make? (Y|N)");
                    if(ReadLine().ToLower() == "n"){
                        WriteLine("Thanks for grading me, SVG file has been added to current directory!");
                        run = false;
                    }
                    else{WriteLine("Input the shape | Update | Delete");}
                }
                else if(input.ToLower()=="circle")
                {
                    var circle = circleFactory.CreateShape(new Style());
                    canvas.AddShape(circle);
                    WriteLine("Any other shapes/changes would you like to make? (Y|N)");
                    if(ReadLine().ToLower() == "n"){
                        WriteLine("Thanks for grading me, SVG file has been added to current directory!");
                        run = false;
                    }
                    else{WriteLine("Input the shape | Update | Delete");}
                }
                else if(input.ToLower()=="ellipse")
                {
                    var ellipse = ellipseFactory.CreateShape(new Style());
                    canvas.AddShape(ellipse);
                    WriteLine("Any other shapes/changes would you like to make? (Y|N)");
                    if(ReadLine() == "N"){
                        WriteLine("Thanks for grading me, SVG file has been added to current directory!");
                        run = false;
                    }
                    else{WriteLine("Input the shape | Update | Delete");}
                }
                else if(input.ToLower()=="line")
                {
                    var line = lineFactory.CreateShape(new Style());
                    canvas.AddShape(line);
                    WriteLine("Any other shapes/changes would you like to make? (Y|N)");
                    if(ReadLine().ToLower() == "n"){
                        WriteLine("Thanks for grading me, SVG file has been added to current directory!");
                        run = false;
                    }
                    else{WriteLine("Input the shape | Update | Delete");}
                }
                else if(input.ToLower()=="polyline")
                {
                    var polyline = polylineFactory.CreateShape(new Style());
                    canvas.AddShape(polyline);
                    WriteLine("Any other shapes/changes would you like to make? (Y|N)");
                    if(ReadLine().ToLower() == "n"){
                        WriteLine("Thanks for grading me, SVG file has been added to current directory!");
                        run = false;
                    }
                    else{WriteLine("Input the shape | Update | Delete");}
                }
                else if(input.ToLower()=="polygon")
                {
                    var polygon = polygonFactory.CreateShape(new Style());
                    canvas.AddShape(polygon);
                    WriteLine("Any other shapes/changes would you like to make? (Y|N)");
                    if(ReadLine().ToLower() == "n"){
                        WriteLine("Thanks for grading me, SVG file has been added to current directory!");
                        run = false;
                    }
                    else{WriteLine("Input the shape | Update | Delete");}
                }
                else if(input.ToLower()=="path")
                {
                    var path = pathFactory.CreateShape(new Style());
                    canvas.AddShape(path);
                    WriteLine("Any other shapes/changes would you like to make? (Y|N)");
                    if(ReadLine().ToLower() == "n"){
                        WriteLine("Thanks for grading me, SVG file has been added to current directory!");
                        run = false;
                    }
                    else{WriteLine("Input the shape | Update | Delete");}
                }
                else if(input.ToLower()=="update") //updates the shape by deleting it and replacing it with a new one in the same slot , my regex is too bad for doing it the other way around.
                {

                    for(int i=0;i<Canvas.Shapes.Count;i++)
                    {
                        WriteLine($"{i}."+Canvas.Shapes[i].ToSvg());
                    }
                    WriteLine("What shape would you like to update?");
                    int z = Int32.Parse(ReadLine());
                    string sh = Canvas.Shapes[z].ToSvg();
                    Canvas.deleteShape(z);
                    if (sh.Contains("rect")) {
                        var rectangle = rectangleFactory.CreateShape(new Style());
                        canvas.AddShape(z,rectangle);
                        WriteLine("Shape has been updated to new values!");
                        WriteLine("Any other shapes/changes would you like to make? (Y|N)");
                        if(ReadLine().ToLower() == "n"){
                        WriteLine("Thanks for grading me, SVG file has been added to current directory!");
                        run = false;
                        }
                        else{WriteLine("Input the shape | Update | Delete");}
                    }
                    else if(sh.Contains("circle")){
                        WriteLine("Shape has been updated to new values!");
                        var circle = circleFactory.CreateShape(new Style());
                        canvas.AddShape(z,circle);
                        WriteLine("Any other shapes/changes would you like to make? (Y|N)");
                        if(ReadLine().ToLower() == "n"){
                        WriteLine("Thanks for grading me, SVG file has been added to current directory!");
                        run = false;
                        }
                        else{WriteLine("Input the shape | Update | Delete");}
                    }
                    else if(sh.Contains("ellipse")){
                        WriteLine("Shape has been updated to new values!");
                        var ellipse = ellipseFactory.CreateShape(new Style());
                        canvas.AddShape(z,ellipse);
                        WriteLine("Any other shapes/changes would you like to make? (Y|N)");
                        if(ReadLine() == "N"){
                            WriteLine("Thanks for grading me, SVG file has been added to current directory!");
                            run = false;
                        }
                        else{WriteLine("Input the shape | Update | Delete");}
                    }
                    else if(sh.Contains("line")){
                    WriteLine("Shape has been updated to new values!");
                    var line = lineFactory.CreateShape(new Style());
                    canvas.AddShape(z,line);
                    WriteLine("Any other shapes/changes would you like to make? (Y|N)");
                    if(ReadLine().ToLower() == "n"){
                        WriteLine("Thanks for grading me, SVG file has been added to current directory!");
                        run = false;
                    }
                    else{WriteLine("Input the shape | Update | Delete");}
                    }
                    else if(sh.Contains("polyline")){
                    WriteLine("Shape has been updated to new values!");
                    var polyline = polylineFactory.CreateShape(new Style());
                    canvas.AddShape(z,polyline);
                    WriteLine("Any other shapes/changes would you like to make? (Y|N)");
                    if(ReadLine().ToLower() == "n"){
                        WriteLine("Thanks for grading me, SVG file has been added to current directory!");
                        run = false;
                    }
                    else{WriteLine("Input the shape | Update | Delete");}
                    }
                    else if(sh.Contains("polygon")){
                    WriteLine("Shape has been updated to new values!");
                    var polygon = polygonFactory.CreateShape(new Style());
                    canvas.AddShape(z,polygon);
                    WriteLine("Any other shapes/changes would you like to make? (Y|N)");
                    if(ReadLine().ToLower() == "n"){
                        WriteLine("Thanks for grading me, SVG file has been added to current directory!");
                        run = false;
                    }
                    else{WriteLine("Input the shape | Update | Delete");}
                    }
                    else if(sh.Contains("path")){
                    WriteLine("Shape has been updated to new values!");
                    var path = pathFactory.CreateShape(new Style());
                    canvas.AddShape(z,path);
                    WriteLine("Any other shapes/changes would you like to make? (Y|N)");
                    if(ReadLine().ToLower() == "n"){
                        WriteLine("Thanks for grading me, SVG file has been added to current directory!");
                        run = false;
                    }
                    else{WriteLine("Input the shape | Update | Delete");}
                    }
                }
                else if(input.ToLower()=="delete") //deletes the shape 
                {
                    if(Canvas.Shapes.Count<0){WriteLine("No shapes to Delete!");}
                    else{
                        for(int i=0;i<Canvas.Shapes.Count;i++){
                            WriteLine($"{i}."+Canvas.Shapes[i].ToSvg());
                        }
                        WriteLine("Which shape to remove?");
                        int z = Int32.Parse(ReadLine());
                        Canvas.deleteShape(z);
                        WriteLine("Shape deleted! Would you like to do anything else? (Y|N)");
                        if(ReadLine().ToLower() == "n"){
                        WriteLine("Thanks for grading me, SVG file has been added to current directory!");
                        run = false;
                        }
                         else{WriteLine("Input the shape | Update | Delete");}
                        
                    }
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