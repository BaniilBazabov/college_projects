namespace cs264Ass2{

    public class Rectangle: AbstractShape{

        private int X,Y, Height, Width;
        private string Fill, Stroke, StrokeWidth;
        
        
        public Rectangle (int x, int y, int width, int height, string fill, string stroke, string strokewidth){
            X=x;
            Y=y;
            Width=width;
            Height=height;
            Fill = "blue";
            Stroke = "yellow";
            StrokeWidth = "5";

        }
        public override string ToSvg(){
            return $"<rect x=\"{X}\" y=\"{Y}\" width = \"{Width}\" height =\"{Height}\" " +
                    $"fill=\"{Fill}\" stroke = \"{Stroke}\" stroke-Width=\"{StrokeWidth}\"/>";
        }
    } 
}