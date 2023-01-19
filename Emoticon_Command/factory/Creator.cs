namespace finalexam.abstractFactory
{
    public abstract class abstractFactory
    {
        public abstract AbstractShape CreateShape(Style style);
    }

    class LeftEyeFactory:abstractFactory
    {
        public override AbstractShape CreateShape(Style style)
        {
            return new LeftEye(style);
        }
    }
    class RightEyeFactory:abstractFactory
    {
        public override AbstractShape CreateShape(Style style)
        {
            return new RightEye(style);
        }
    }
    class LeftBrowFactory:abstractFactory
    {
        public override AbstractShape CreateShape(Style style)
        {
            return new LeftBrow(style);
        }
    }
    class RightBrowFactory:abstractFactory
    {
        public override AbstractShape CreateShape(Style style)
        {
            return new RightBrow(style);
        }
    }
    
    
    class MouthFactory: abstractFactory
    {
        public override AbstractShape CreateShape(Style style)
        {
            return new Mouth(style);
        }
    }
    
    
} 