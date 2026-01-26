using System;
using System.Windows.Forms;

namespace PhotoboothVipstudios.Controls
{
    public partial class HomeControl : UserControl
    {
        private MainForm _main;

        // Constructor untuk Designer
        public HomeControl()
        {
            InitializeComponent();
        }

        // Constructor untuk Runtime
        public HomeControl(MainForm main) : this()
        {
            _main = main;
        }

        private void btnMula_Click(object sender, EventArgs e)
        {
            _main.ShowCamera();
        }
    }
}
