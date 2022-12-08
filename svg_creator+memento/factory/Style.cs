using System.Drawing;
namespace cs264Ass2.abstractFactory
{
    public class Style
    {
        Random r = new Random();
        KnownColor[] colors  = (KnownColor[])Enum.GetValues(typeof(KnownColor));
        public Style ()
        {
            fill=colors[r.Next(colors.Length)].ToString();
            strokeWidth=r.Next(1,10).ToString();
            strokeColor=colors[r.Next(colors.Length)].ToString();
        }

        public string fill {get; set;}
        public string strokeWidth {get; set;}
        public string strokeColor {get; set;}

    }
}