using System;
using System.Windows.Forms;

namespace PhotoboothVipstudios.Controls
{
    public partial class CameraControl : UserControl
    {
        private readonly MainForm? _main;

        private int _countdown = 3;
        private System.Windows.Forms.Timer _countdownTimer;

        public CameraControl()
        {
            InitializeComponent();

            label1.Visible = false;

            _countdownTimer = new System.Windows.Forms.Timer();
            _countdownTimer.Interval = 1000;
            _countdownTimer.Tick += CountdownTimer_Tick;
        }

        public CameraControl(MainForm main) : this()
        {
            _main = main;
        }

        // 📌 Dipanggil bila tekan MULA
        public void StartPhotoSession(int startFrom = 3)
        {
            _countdown = startFrom;
            label1.Text = _countdown.ToString();
            label1.Visible = true;

            _countdownTimer.Start();
        }

        // 📌 Setiap 1 saat
        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            _countdown--;

            if (_countdown > 0)
            {
                label1.Text = _countdown.ToString();
            }
            else
            {
                _countdownTimer.Stop();
                label1.Visible = false;

                CaptureImage(); // 📸 auto snap
            }
        }

        // 📌 Placeholder dulu
        public void CaptureImage()
        {
            MessageBox.Show("📸 SNAP! Countdown OK");
        }
    }
}
