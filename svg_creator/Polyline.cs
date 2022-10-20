namespace cs264Ass2{

    public class Polyline: AbstractShape{

        
        private string Fill, Stroke, StrokeWidth, Points;
        
        public Polyline ( string points, string fill, string stroke, string strokewidth){
            Points = points;
            Fill = "purple";
            Stroke = "brown";
            StrokeWidth = "2";

        }
        public override string ToSvg(){
            return $"<polyline points=\"{Points}\" " +
                    $"fill=\"{Fill}\" stroke = \"{Stroke}\" stroke-Width=\"{StrokeWidth}\"/>";
        }
    }
}