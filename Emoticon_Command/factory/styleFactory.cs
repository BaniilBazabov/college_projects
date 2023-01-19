using System.Drawing;
namespace finalexam.abstractFactory
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