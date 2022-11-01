namespace cs264Ass2{

    public class Ellipse: AbstractShape{
        Random r = new Random();
        private int CX,CY, RX, RY;
        private string Fill, Stroke, StrokeWidth;
        
        public Ellipse (){
            CX=r.Next(1,1000);
            CY=r.Next(1,1000);
            RX=r.Next(1,100);
            RY=r.Next(1,100);
            Fill = "pink";
            Stroke = "black";
            StrokeWidth = "5";

        }
        public override string ToSvg(){
            return $"<ellipse cx=\"{CX}\" cy=\"{CY}\" rx =\"{RX}\" ry =\"{RY}\" " +
                    $"fill=\"{Fill}\" stroke = \"{Stroke}\" stroke-Width=\"{StrokeWidth}\"/>\n";
        }
    }
}