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
        public static PictureBox gameBox = new PictureBox();
        public Window1()
        {
            TableLayoutPanel panel = new TableLayoutPanel
            {
            ColumnCount = 2,
            Dock = DockStyle.Fill,
            BackColor = Color.Black
            };
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80));
            Controls.Add(panel);

            gameBox = new PictureBox
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White
            };
            panel.Controls.Add(gameBox);

            Label score = new Label
            {
                Text = "Score",
                ForeColor = Color.White
            };
            panel.Controls.Add(score);

        }
       
        
        

    }
}
