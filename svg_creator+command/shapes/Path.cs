namespace cs264Ass2{

    public class Path: AbstractShape{

        
        private string Fill, Stroke, StrokeWidth, Points;
        
        public Path (abstractFactory.Style style){
            Points = "M 10 80 C 40 10, 65 10, 95 80 S 150 150, 180 80";
            Fill = style.fill;
            Stroke = style.strokeColor;
            StrokeWidth = style.strokeWidth;

        }
        public override string ToSvg(){
            return $"<path d=\"{Points}\" " +
                    $"fill=\"{Fill}\" stroke = \"{Stroke}\" stroke-Width=\"{StrokeWidth}\"/>\n";
        }
    }
}