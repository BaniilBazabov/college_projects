namespace finalexam{
    public  class Canvas 
    {
        private List<AbstractShape> Shapes;
         private int Width, Height;
        public Canvas(int width, int height) 
        {
            Shapes = new List<AbstractShape>();
            Width = width;
            Height = height;

        }
        public Canvas(List<AbstractShape> shapes, int width, int height)
        {
            Shapes = new List<AbstractShape>(shapes);
            Width = width;
            Height = height;
        }

        private String BoilerSVG = $"<?xml version=\"1.0\" standalone\"no\"?>\n" + $"<svg width=\"{500}\" height=\"{500}\" version=\"1.1\" xmlns=\"http://www.w3.org/2000/svg\">\n";

        public void AddShape(AbstractShape shape)
        {
            Shapes.Add(shape);
        }
         public void DeleteShape(AbstractShape shape)
        {
            Shapes.Remove(shape);
        }
        public List<AbstractShape> getShapes()
        {
            return Shapes;
        }
        
        
        

        public AbstractShape getShape(string name)
        {
            foreach (var shape in Shapes)
            {
                if(shape.getId()==name)
                {
                    return shape;
                }
            }
            return null;
            
        }
            
        

        public string ToSvg() {
            var svg = BoilerSVG;
            foreach (var shape in Shapes)
            {
                svg = string.Concat(svg, shape.ToSvg());
            }
            svg = string.Concat(svg, "</svg>");
            return svg;
        }

        
        public static async Task SaveFile(string text)
        {
            await File.WriteAllTextAsync("Shape.svg", text);
        }
    }
}

