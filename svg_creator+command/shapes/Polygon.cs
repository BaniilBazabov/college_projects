namespace cs264Ass2{

    public class Polygon: AbstractShape{

        Random r = new Random();
        private string Fill, Stroke, StrokeWidth, Points;
        
        public Polygon (abstractFactory.Style style){
            Points = "350,75  379,161 469,161 397,215 423,301 350,250 277,301 303,215 231,161 321,161"; 
            Fill = style.fill;
            Stroke = style.strokeColor;
            StrokeWidth = style.strokeWidth;
            

        }
        public override string ToSvg(){
            return $"<polygon points=\"{Points}\" " +
                    $"fill=\"{Fill}\" stroke = \"{Stroke}\" stroke-Width=\"{StrokeWidth}\"/>\n";
        }
    }
}