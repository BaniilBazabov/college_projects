using System.Drawing;
namespace finalexam
{
    public class Style
    {
        public string fill {get; set;}
        public string strokeWidth {get; set;}
        public string strokeColor {get; set;}

        
        public Style (string s)
        {
            if(s.ToLower() == "a")
            {
                fill="black";
                strokeWidth="3";
                strokeColor="black";
            }
            else if(s.ToLower()=="b")
            {
                fill="purple";
                strokeWidth="5";
                strokeColor="purple";
            }
            else
            { 
                fill="blue";
                strokeWidth="1";
                strokeColor="blue";
            }   
        }
       
    }
}