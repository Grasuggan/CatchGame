using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace CatchGame
{
    class Window2 : Window1
    {

        public Window2()
        {

            Image hamburger = Image.FromFile("Hamburger.jpg");
            Image pizza = Image.FromFile("Pizza.jpg");
            Image muffin = Image.FromFile("Muffin.jpg");
            Image sushi = Image.FromFile("Sushi.jpg");

           

            
        }
    }
}
