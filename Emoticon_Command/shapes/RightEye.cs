using static System.Console;
namespace finalexam{

    public class RightEye: AbstractShape{
        Random r = new Random();
        private int CX,CY, Radius;
        private string Fill, Stroke, StrokeWidth,id;
        
       
        public RightEye (Style style){
            CX=350;
            CY=170;
            Radius=25;
            Fill = style.fill;
            Stroke = style.strokeColor;
            StrokeWidth = style.strokeWidth;
            id="righteye";
        }

        public override void UpdateShape(String direction, int value)
        {
            if(direction=="up")
            {
                CY-=value;
            }
            else if (direction=="down")
            {
                CY+=value;
            }
            else if(direction=="left")
            {
                CX-=value;
            }
            else if(direction=="right")
            {
                CX+=value;
            }
            else{WriteLine("Invalid Input!");}
        }
        public override void UpdateStyle(string color)
        {
            Fill = color;
        }
        public override string getId()
        {
            return id;
        }
        public override string ToSvg(){
            return $"<circle cx=\"{CX}\" cy=\"{CY}\" r =\"{Radius}\" " +
                    $"fill=\"{Fill}\" stroke = \"{Stroke}\" stroke-Width=\"{StrokeWidth}\"/>\n";
        }
    }
}