using System.Drawing;
namespace finalexam.abstractFactory
{
    public abstract class styleFactory
    {
        public abstract Style giveStyle(string sake);
    } 


    public class CreateStyle:styleFactory
    {
        
        public override Style giveStyle(string s)
        {
            return new Style(s);
        }

        

    }
}