using System.Windows.Forms;
using PhotoboothVipstudios.Controls;

namespace PhotoboothVipstudios
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ShowHome();
        }

        public void ShowHome()
        {
            ShowControl(new HomeControl(this));
        }

        public void ShowControl(UserControl control)
        {
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(control);
            control.Dock = DockStyle.Fill;
        }
    }
}

