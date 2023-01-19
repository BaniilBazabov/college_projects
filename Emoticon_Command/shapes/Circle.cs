namespace finalexam{

    public class Circle: AbstractShape{
        Random r = new Random();
        private int CX,CY, Radius;
        private string Fill, Stroke, StrokeWidth,id;
        
        public Circle (Style style){
            CX=250;
            CY=250;
            Radius=200;
            Fill = "yellow";
            Stroke = "black";
            StrokeWidth = "3";
            id="body";
        }
        public override void UpdateShape(String direction, int value)       //since this circle is not changed, we just return
        {
            return;
        }
        public override void UpdateStyle(string color)
        {
            return;
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