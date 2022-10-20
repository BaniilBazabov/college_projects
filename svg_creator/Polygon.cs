namespace cs264Ass2{

    public class Polygon: AbstractShape{

        
        private string Fill, Stroke, StrokeWidth, Points;
        
        public Polygon ( string points, string fill, string stroke, string strokewidth){
            Points = points;
            Fill = "red";
            Stroke = "blue";
            StrokeWidth = "5";

        }
        public override string ToSvg(){
            return $"<polygon points=\"{Points}\" " +
                    $"fill=\"{Fill}\" stroke = \"{Stroke}\" stroke-Width=\"{StrokeWidth}\"/>";
        }
    }
}