namespace cs264Ass2{

    public class Line: AbstractShape{

        private int X1,Y1, X2, Y2;
        private string Stroke, StrokeWidth;
        
        public Line (int x1, int y1, int x2, int y2, string stroke, string strokewidth){
            X1=x1;
            Y1=y1;
            X2=x2;
            Y2=y2;
            Stroke = "orange";
            StrokeWidth = "5";

        }
        public override string ToSvg(){
            return $"<line x1=\"{X1}\" y1=\"{Y1}\" x2 = \"{X2}\" y2 =\"{Y2}\" " +
                    $" stroke = \"{Stroke}\" stroke-Width=\"{StrokeWidth}\"/>";
        }
    }
}