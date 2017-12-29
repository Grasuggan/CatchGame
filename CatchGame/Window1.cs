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
    class Window1 : Form
    {
        public Window1()
        {
            TableLayoutPanel panel = new TableLayoutPanel
            {
            ColumnCount = 2,
            Dock = DockStyle.Fill
        };
            Controls.Add(panel);

            PictureBox gameBox = new PictureBox
            {
                Dock = DockStyle.Fill
            };
            panel.Controls.Add(gameBox);

            Label score = new Label
            {
                Text = "Score"
            };
            panel.Controls.Add(score);

        }
       
        
        

    }
}
