namespace cs264Ass2{

    public class Line: AbstractShape{
        Random r = new Random();
        private int X1,Y1, X2, Y2;
        private string Stroke, StrokeWidth;
        
        public Line (Style style){
            X1=r.Next(1,300);
            Y1=r.Next(1,300);
            X2=r.Next(1,700);
            Y2=r.Next(1,700);
            Stroke = style.strokeColor;
            StrokeWidth = style.strokeWidth;

        }
        public override string ToSvg(){
            return $"<line x1=\"{X1}\" y1=\"{Y1}\" x2 = \"{X2}\" y2 =\"{Y2}\" " +
                    $" stroke = \"{Stroke}\" stroke-Width=\"{StrokeWidth}\"/>\n";
        }
    }
}  