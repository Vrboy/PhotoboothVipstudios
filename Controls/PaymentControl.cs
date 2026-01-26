using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PhotoboothVipstudios.Controls
{
    public partial class PaymentControl : UserControl
    {
        private MainForm? _main;
        private Image? _image;
        private System.Windows.Forms.Timer? _timer;

        // Constructor untuk Designer (WAJIB)
        public PaymentControl()
        {
            InitializeComponent();
        }

        // Constructor untuk Runtime
        public PaymentControl(MainForm main, Image image) : this()
        {
            _main = main;
            _image = image;

            ShowQr();
        }

        // Papar QR Dummy
        private void ShowQr()
        {
            try
            {
                string baseDir = AppContext.BaseDirectory;
                string qrPath = Path.Combine(baseDir, "Assets", "Dummy QR.png");

                if (File.Exists(qrPath))
                {
                    pictureBoxQr.Image = Image.FromFile(qrPath);
                    pictureBoxQr.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            catch
            {
                // senyap – jangan crash kiosk
            }
        }

        // Dipanggil oleh MainForm
        public void StartDummyPayment()
        {
            _timer?.Stop();

            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 4000; // 4 saat simulasi bayaran
            _timer.Tick += Timer_Tick;
            _timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            _timer?.Stop();
            Cleanup();

            _main?.ShowPrinting();
        }

        // Bersihkan resource
        private void Cleanup()
        {
            pictureBoxQr.Image?.Dispose();
            pictureBoxQr.Image = null;

            _image = null;
        }
    }
}
