namespace cs264Ass2{

    public class Polyline: AbstractShape{

        
        private string Fill, Stroke, StrokeWidth, Points;
        
        public Polyline (Style style){
            Points = "50,375, 150,375 150,325 250,325 250,375,350,375 350,250 450,250 450,375 550,375 550,175 650,175";
            Fill = style.fill;
            Stroke = style.strokeColor;
            StrokeWidth = style.strokeWidth;

        }
        public override string ToSvg(){
            return $"<polyline points=\"{Points}\" " +
                    $"fill=\"{Fill}\" stroke = \"{Stroke}\" stroke-Width=\"{StrokeWidth}\"/>\n";
        }
    }
}