namespace cs264Ass2{

    public class Circle: AbstractShape{
        Random r = new Random();
        private int CX,CY, Radius;
        private string Fill, Stroke, StrokeWidth;
        
        public Circle (abstractFactory.Style style){
            CX=r.Next(1,1000);
            CY=r.Next(1,1000);
            Radius=r.Next(1,200);
            Fill = style.fill;
            Stroke = style.strokeColor;
            StrokeWidth = style.strokeWidth;

        }
        public override string ToSvg(){
            return $"<circle cx=\"{CX}\" cy=\"{CY}\" r =\"{Radius}\" " +
                    $"fill=\"{Fill}\" stroke = \"{Stroke}\" stroke-Width=\"{StrokeWidth}\"/>\n";
        }
    }
}