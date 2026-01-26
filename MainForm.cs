using System.Drawing;
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

        // ===== CORE HELPER =====
        private void ShowControl(UserControl control)
        {
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(control);
            control.Dock = DockStyle.Fill;
        }

        // ===== TRAFFIC CONTROLLER =====

        public void ShowHome()
        {
            ShowControl(new HomeControl(this));
        }

        public void ShowCamera()
        {
            var camera = new CameraControl(this);
            ShowControl(camera);
            camera.StartPhotoSession();
        }

        public void ShowPreview(Image image)
        {
            ShowControl(new PreviewControl(this, image));
        }

        public void ShowPayment(Image image)
        {
            var payment = new PaymentControl(this, image);
            ShowControl(payment);
            payment.StartDummyPayment();
        }

        public void ShowPrinting()
        {
            var printing = new PrintingControl(this);
            ShowControl(printing);
            printing.StartPrinting();
        }

        public void ShowThankYou()
        {
            var thankYou = new ThankYouControl(this);
            ShowControl(thankYou);
            thankYou.StartAutoReset();
        }
    }
}
