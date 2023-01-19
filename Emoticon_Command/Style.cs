using System.Drawing;
namespace finalexam
{
    public class Style
    {
        public string fill {get; set;}
        public string strokeWidth {get; set;}
        public string strokeColor {get; set;}

        
        public Style ()
        {
            fill="black";
            strokeWidth="5";
            strokeColor="black";   
        }
        public string getColor(string letter)
        {
            if(letter.ToLower() == "a")
            {
                return "black";
            }
            else if(letter.ToLower()=="b")
            {
                return "purple";
            }
            else {return "blue";}
        }
    }
}