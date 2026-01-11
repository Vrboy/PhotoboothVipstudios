using System;
using System.Windows.Forms;

namespace PhotoboothVipstudios.Controls
{
    public partial class HomeControl : UserControl
    {
        private readonly MainForm? _main;

        // Untuk WinForms Designer
        public HomeControl()
        {
            InitializeComponent();
        }

        // Digunakan oleh MainForm
        public HomeControl(MainForm main) : this()
        {
            _main = main;
        }

        private void btnMula_Click(object sender, EventArgs e)
        {
            if (_main == null) return;

            _main.ShowControl(new CameraControl(_main));
        }
    }
}
