namespace cs264Ass2{

    public class Path: AbstractShape{

        
        private string Fill, Stroke, StrokeWidth, Points;
        
        public Path ( string points, string fill, string stroke, string strokewidth){
            Points = points;
            Fill = "white";
            Stroke = "brown";
            StrokeWidth = "2";

        }
        public override string ToSvg(){
            return $"<path d=\"{Points}\" " +
                    $"fill=\"{Fill}\" stroke = \"{Stroke}\" stroke-Width=\"{StrokeWidth}\"/>";
        }
    }
}