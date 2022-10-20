using System;
using static System.Console;
namespace cs264Ass2
{

    //Users can add , update and delete shapes from here.
    class Program {         
        static void Main(string[] args)
        {
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
                    WriteLine("Please enter the variables in following order separated by comma: x-value,y-value,width,height");
                    string rec = ReadLine();
                    string [] ar = rec.Split(",");
                    int x= Int32.Parse(ar[0]), y= Int32.Parse(ar[1]), width= Int32.Parse(ar[2]), height= Int32.Parse(ar[3]);
                    Rectangle rectangle = new Rectangle(x,y,width,height,"","","");
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
                    WriteLine("Please enter the variables in following order separated by comma: cx-value,cy-value,radius");
                    string c = ReadLine();
                    string []car = c.Split(",");
                    int cx= Int32.Parse(car[0]), cy= Int32.Parse(car[1]), radius= Int32.Parse(car[2]);
                    Circle circle = new Circle(cx,cy,radius,"","","");
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
                    WriteLine("Please enter the variables in following order separated by comma: cx-value,cy-value,rx-value,ry-value");
                    string el = ReadLine();
                    string []ear = el.Split(",");
                    int cx= Int32.Parse(ear[0]), cy= Int32.Parse(ear[1]), rx= Int32.Parse(ear[2]),ry=Int32.Parse(ear[3]);
                    Ellipse ellipse = new Ellipse(cx,cy,rx,ry,"","","");
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
                    WriteLine("Please enter the variables in following order separated by comma: x1-value,y1-value,x2-value,y2-value");
                    string l = ReadLine();
                    string []lar = l.Split(",");
                    int x1= Int32.Parse(lar[0]), y1= Int32.Parse(lar[1]), x2= Int32.Parse(lar[2]),y2=Int32.Parse(lar[3]);
                    Line line = new Line(x1,y1,x2,y2,"","");
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
                    WriteLine("Please enter the variables in following format: x,y x1,x2 x2,y2......etc");
                    WriteLine("Also, please enter it in one line (here is example: 50,375, 150,375 150,325 250,325 250,375,350,375 350,250 450,250 450,375 550,375 550,175 650,175)");
                    string pol = ReadLine();
                    Polyline polyline = new Polyline(pol,"","","");
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
                    WriteLine("Please enter the variables in following format: x,y x1,x2 x2,y2......etc");
                    WriteLine("Also, please enter it in one line (here is example: 350,75  379,161 469,161 397,215 423,301 350,250 277,301 303,215 231,161 321,161)");
                    string polg = ReadLine();
                    Polygon polygon = new Polygon(polg,"","","");
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
                    WriteLine("Please enter the variables in one line (here is example: M 10 80 C 40 10, 65 10, 95 80 S 150 150, 180 80)");
                    string p = ReadLine();
                    Path path = new Path(p,"","","");
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
                        WriteLine("Please enter the variables in following order separated by comma: x-value,y-value,width,height");
                        string rec = ReadLine();
                        string [] ar = rec.Split(",");
                        int x= Int32.Parse(ar[0]), y= Int32.Parse(ar[1]), width= Int32.Parse(ar[2]), height= Int32.Parse(ar[3]);
                        Rectangle rectangle = new Rectangle(x,y,width,height,"","","");
                        canvas.AddShape(z,rectangle);
                        WriteLine("Any other shapes/changes would you like to make? (Y|N)");
                        if(ReadLine().ToLower() == "n"){
                        WriteLine("Thanks for grading me, SVG file has been added to current directory!");
                        run = false;
                        }
                        else{WriteLine("Input the shape | Update | Delete");}
                    }
                    else if(sh.Contains("circle")){
                        WriteLine("Please enter the variables in following order separated by comma: cx-value,cy-value,radius");
                        string c = ReadLine();
                        string []car = c.Split(",");
                        int cx= Int32.Parse(car[0]), cy= Int32.Parse(car[1]), radius= Int32.Parse(car[2]);
                        Circle circle = new Circle(cx,cy,radius,"","","");
                        canvas.AddShape(z,circle);
                        WriteLine("Any other shapes/changes would you like to make? (Y|N)");
                        if(ReadLine().ToLower() == "n"){
                        WriteLine("Thanks for grading me, SVG file has been added to current directory!");
                        run = false;
                        }
                        else{WriteLine("Input the shape | Update | Delete");}
                    }
                    else if(sh.Contains("ellipse")){
                        WriteLine("Please enter the variables in following order separated by comma: cx-value,cy-value,rx-value,ry-value");
                        string el = ReadLine();
                        string []ear = el.Split(",");
                        int cx= Int32.Parse(ear[0]), cy= Int32.Parse(ear[1]), rx= Int32.Parse(ear[2]),ry=Int32.Parse(ear[3]);
                        Ellipse ellipse = new Ellipse(cx,cy,rx,ry,"","","");
                        canvas.AddShape(z,ellipse);
                        WriteLine("Any other shapes/changes would you like to make? (Y|N)");
                        if(ReadLine() == "N"){
                            WriteLine("Thanks for grading me, SVG file has been added to current directory!");
                            run = false;
                        }
                        else{WriteLine("Input the shape | Update | Delete");}
                    }
                    else if(sh.Contains("line")){
                        WriteLine("Please enter the variables in following order separated by comma: x1-value,y1-value,x2-value,y2-value");
                    string l = ReadLine();
                    string []lar = l.Split(",");
                    int x1= Int32.Parse(lar[0]), y1= Int32.Parse(lar[1]), x2= Int32.Parse(lar[2]),y2=Int32.Parse(lar[3]);
                    Line line = new Line(x1,y1,x2,y2,"","");
                    canvas.AddShape(z,line);
                    WriteLine("Any other shapes/changes would you like to make? (Y|N)");
                    if(ReadLine().ToLower() == "n"){
                        WriteLine("Thanks for grading me, SVG file has been added to current directory!");
                        run = false;
                    }
                    else{WriteLine("Input the shape | Update | Delete");}
                    }
                    else if(sh.Contains("polyline")){
                    WriteLine("Please enter the variables in following format: x,y x1,x2 x2,y2......etc");
                    WriteLine("Also, please enter it in one line (here is example: 50,375, 150,375 150,325 250,325 250,375,350,375 350,250 450,250 450,375 550,375 550,175 650,175)");
                    string pol = ReadLine();
                    Polyline polyline = new Polyline(pol,"","","");
                    canvas.AddShape(z,polyline);
                    WriteLine("Any other shapes/changes would you like to make? (Y|N)");
                    if(ReadLine().ToLower() == "n"){
                        WriteLine("Thanks for grading me, SVG file has been added to current directory!");
                        run = false;
                    }
                    else{WriteLine("Input the shape | Update | Delete");}
                    }
                    else if(sh.Contains("polygon")){
                    WriteLine("Please enter the variables in following format: x,y x1,x2 x2,y2......etc");
                    WriteLine("Also, please enter it in one line (here is example: 350,75  379,161 469,161 397,215 423,301 350,250 277,301 303,215 231,161 321,161)");
                    string polg = ReadLine();
                    Polygon polygon = new Polygon(polg,"","","");
                    canvas.AddShape(z,polygon);
                    WriteLine("Any other shapes/changes would you like to make? (Y|N)");
                    if(ReadLine().ToLower() == "n"){
                        WriteLine("Thanks for grading me, SVG file has been added to current directory!");
                        run = false;
                    }
                    else{WriteLine("Input the shape | Update | Delete");}
                    }
                    else if(sh.Contains("path")){
                        WriteLine("Please enter the variables in one line (here is example: M 10 80 C 40 10, 65 10, 95 80 S 150 150, 180 80)");
                    string p = ReadLine();
                    Path path = new Path(p,"","","");
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