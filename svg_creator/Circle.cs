namespace cs264Ass2{

    public class Circle: AbstractShape{

        private int CX,CY, Radius;
        private string Fill, Stroke, StrokeWidth;
        
        public Circle (int cx, int cy, int radius, string fill, string stroke, string strokewidth){
            CX=cx;
            CY=cy;
            Radius=radius;
            Fill = "red";
            Stroke = "green";
            StrokeWidth = "5";

        }
        public override string ToSvg(){
            return $"<circle cx=\"{CX}\" cy=\"{CY}\" r =\"{Radius}\" " +
                    $"fill=\"{Fill}\" stroke = \"{Stroke}\" stroke-Width=\"{StrokeWidth}\"/>";
        }
    }
}