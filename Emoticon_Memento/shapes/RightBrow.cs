using static System.Console;
namespace finalexam{

    public class RightBrow: AbstractShape{
        Random r = new Random();
        private int X1,Y1, X2, Y2;
        private string Stroke, StrokeWidth,id;
        
        public RightBrow (Style style){
            X1=320;
            Y1=140;
            X2=400;
            Y2=120;
            Stroke = style.strokeColor;
            StrokeWidth = style.strokeWidth;
            id="rightbrow";
        }

        public override void UpdateShape(String direction, int value)
        {
            if(direction=="up")
            {
                Y1-=value;
                Y2-=value;
            }
            else if (direction=="down")
            {
                Y1+=value;
                Y2+=value;
            }
            else if(direction=="left")
            {
                X1-=value;
                X2-=value;
            }
            else if(direction=="right")
            {
                X1+=value;
                X2+=value;
            }
            else{WriteLine("Invalid Input!");}
        }
        public override void UpdateStyle(string color)
        {
            Stroke = color;
        }

        public override string getId()
        {
            return id;
        }
        public override string ToSvg(){
            return $"<line x1=\"{X1}\" y1=\"{Y1}\" x2 = \"{X2}\" y2 =\"{Y2}\" " +
                    $" stroke = \"{Stroke}\" stroke-Width=\"{StrokeWidth}\"/>\n";
        }
    }
}  