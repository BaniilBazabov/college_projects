namespace cs264Ass2{

    public class Rectangle: AbstractShape{
        Random r = new Random();
        private int X,Y, Height, Width;
        private string Fill, Stroke, StrokeWidth;
        
        
        public Rectangle (){
            X=r.Next(1,1000);
            Y=r.Next(1,1000);
            Width=r.Next(1,100);
            Height=r.Next(1,100);
            Fill = "blue";
            Stroke = "yellow";
            StrokeWidth = "5";

        }
        public override string ToSvg(){
            return $"<rect x=\"{X}\" y=\"{Y}\" width = \"{Width}\" height =\"{Height}\" " +
                    $"fill=\"{Fill}\" stroke = \"{Stroke}\" stroke-Width=\"{StrokeWidth}\"/>\n";
        }
    } 
}