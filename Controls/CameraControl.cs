using PhotoboothVipstudios.Services;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PhotoboothVipstudios.Controls
{
    public partial class CameraControl : UserControl
    {
        private readonly MainForm? _main;

        private int _countdown = 3;
        private readonly System.Windows.Forms.Timer _countdownTimer;


        // =========================
        // Constructor (Designer)
        // =========================
        public CameraControl()
        {
            InitializeComponent();

            // Countdown label default
            label1.Visible = false;

            // Countdown timer
            _countdownTimer = new System.Windows.Forms.Timer();

            {
                _countdownTimer.Interval = 1000;

            }
            ;
            _countdownTimer.Tick += CountdownTimer_Tick;
        }

        // =========================
        // Constructor (Runtime)
        // =========================
        public CameraControl(MainForm main) : this()
        {
            _main = main;
        }

        // =========================
        // Start photo session
        // =========================
        public void StartPhotoSession(int startFrom = 3)
        {
            _countdownTimer.Stop();

            _countdown = startFrom;
            label1.Text = _countdown.ToString();
            label1.Visible = true;

            _countdownTimer.Start();
        }

        // =========================
        // Countdown tick
        // =========================
        private void CountdownTimer_Tick(object? sender, EventArgs e)
        {
            _countdown--;

            if (_countdown > 0)
            {
                label1.Text = _countdown.ToString();
                return;
            }

            _countdownTimer.Stop();
            label1.Visible = false;

            CaptureImage();
        }

        // =========================
        // Capture image (Dummy for now)
        // =========================
        private void CaptureImage()
        {
            try
            {
                if (_main == null)
                    throw new InvalidOperationException("MainForm reference is null.");

                Image image = CameraService.CaptureDummy();

                _main.ShowPreview(image);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Camera Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
