using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Views.Login
{
    public partial class Login : Form
    {

        private int imageNumber = 1;
        public Login()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Slider();
        }

        private void Slider()
        {
            if (imageNumber == 4)
            {
                imageNumber = 1;
            }
            pictureBox2.ImageLocation = string.Format(@"Login\{0}.png", imageNumber);
            imageNumber++;
        }
    }
}
