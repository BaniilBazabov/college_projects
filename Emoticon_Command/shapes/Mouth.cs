using static System.Console;
namespace finalexam{

    public class Mouth: AbstractShape{

        
        private string Fill, Stroke, StrokeWidth, Points,id,transform;
        
        public Mouth (Style style){
            Points = "M 180 288 C 177 417 372 308 395 290";
            Fill = style.fill;
            Stroke = style.strokeColor;
            StrokeWidth = style.strokeWidth;
            transform = "translate(0,0)";
            id="mouth";
        }
        public override void UpdateShape(String direction, int value)
        {
            string[] parts = transform.Split(new char[] { '(', ',', ')' });
            double x = double.Parse(parts[1]);
            double y = double.Parse(parts[2]);
            
            if(direction=="up")
            {
                y-=value;
                transform = "translate(" + x.ToString() + "," + y.ToString() + ")";
            }
            else if (direction=="down")
            {
                y+=value;
                transform = "translate(" + x.ToString() + "," + y.ToString() + ")";
            }
            else if(direction=="left")
            {
                x-=value;
                transform = "translate(" + x.ToString() + "," + y.ToString() + ")";
            }
            else if(direction=="right")
            {
                x+=value;
                transform = "translate(" + x.ToString() + "," + y.ToString() + ")";
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
            return $"<path d=\"{Points}\" transform=\"{transform}\" " +
                    $"fill=\"{Fill}\" stroke = \"{Stroke}\" stroke-Width=\"{StrokeWidth}\"/>\n";
        }
    }
}