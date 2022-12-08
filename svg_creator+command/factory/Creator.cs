namespace cs264Ass2.abstractFactory
{
    public abstract class abstractFactory
    {
        public abstract AbstractShape CreateShape(Style style);
    }

    class RectangleFactory: abstractFactory
    {
        public override AbstractShape CreateShape(Style style)
        {
            return new Rectangle(style);
        }
    }
    class CircleFactory: abstractFactory
    {
        public override AbstractShape CreateShape(Style style)
        {
            return new Circle(style);
        }
    }
    class EllipseFactory: abstractFactory
    {
        public override AbstractShape CreateShape(Style style)
        {
            return new Ellipse(style);
        }
    }
    class LineFactory: abstractFactory
    {
        public override AbstractShape CreateShape(Style style)
        {
            return new Line(style);
        }
    }
    class PathFactory: abstractFactory
    {
        public override AbstractShape CreateShape(Style style)
        {
            return new Path(style);
        }
    }
    class PolygonFactory: abstractFactory
    {
        public override AbstractShape CreateShape(Style style)
        {
            return new Polygon(style);
        }
    }
    class PolylineFactory: abstractFactory
    {
        public override AbstractShape CreateShape(Style style)
        {
            return new Polyline(style);
        }
    }
} 