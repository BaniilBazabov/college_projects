namespace cs264Ass2{

    public class Ellipse: AbstractShape{

        private int CX,CY, RX, RY;
        private string Fill, Stroke, StrokeWidth;
        
        public Ellipse (int cx, int cy, int rx,int ry, string fill, string stroke, string strokewidth){
            CX=cx;
            CY=cy;
            RX=rx;
            RY=ry;
            Fill = "pink";
            Stroke = "black";
            StrokeWidth = "5";

        }
        public override string ToSvg(){
            return $"<ellipse cx=\"{CX}\" cy=\"{CY}\" rx =\"{RX}\" ry =\"{RY}\" " +
                    $"fill=\"{Fill}\" stroke = \"{Stroke}\" stroke-Width=\"{StrokeWidth}\"/>";
        }
    }
}