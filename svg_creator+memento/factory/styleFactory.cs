using System.Drawing;
namespace cs264Ass2.abstractFactory
{
    public abstract class styleFactory
    {
        public abstract Style giveStyle();
    } 


    public class CreateStyle:styleFactory
    {
        
        public override Style giveStyle()
        {
            return new Style();
        }

        

    }
}