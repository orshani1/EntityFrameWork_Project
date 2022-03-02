using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalATM.UI
{
    public static class LabelExstensionMethods
    {
        public static void Greet(this Label label)
        {
            
            var currentHour = DateTime.Now.Hour;
            if (currentHour >=5 && currentHour <= 12)
            {
                label.Text = "Good Morning !\nWelcome Back";
            }
            if (currentHour > 12 && currentHour <=16)
            {
                label.Text = "Good Noon !\nWelcome Back";

            }
            if (currentHour >16 && currentHour <= 18)
            {
                label.Text = "Good After Noon !\nWelcome Back";

            }
            if (currentHour >18 && currentHour <21)
            {
                label.Text = "Good Evening !\nWelcome Back";

            }
            if (currentHour >=21 && currentHour <=4)
            {
                label.Text = "Good Night !\nWelcome Back";

            }
            else
            {
                label.Text = "Good Night !\nWelcome Back";

            }
        }
    }
}
