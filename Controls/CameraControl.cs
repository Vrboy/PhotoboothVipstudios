using PhotoboothVipstudios.Services;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PhotoboothVipstudios.Controls
{
    public partial class CameraControl : UserControl
    {
        private readonly MainForm? _main;

        // Countdown
        private int _countdown = 3;
        private readonly System.Windows.Forms.Timer _countdownTimer;

        // Camera watcher
        private CameraWatcherService? _watcher;

        private bool _isWaitingPhoto = false;

        // =========================
        // DESIGNER CONSTRUCTOR
        // =========================
        public CameraControl()
        {
            InitializeComponent();

            label1.Visible = false;

            _countdownTimer = new System.Windows.Forms.Timer();
            _countdownTimer.Interval = 1000;
            _countdownTimer.Tick += CountdownTimer_Tick;

            btnCapture.Click += BtnCapture_Click;
        }

        // =========================
        // RUNTIME CONSTRUCTOR
        // =========================
        public CameraControl(MainForm main) : this()
        {
            _main = main;
        }

        // =========================
        // START SESSION
        // =========================
        public void StartPhotoSession()
        {
            try
            {
                StartWatcher();
                StartLiveMode();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Camera Start Error");
            }
        }

        // =========================
        // LIVE MODE READY
        // =========================
        private void StartLiveMode()
        {
            label1.Visible = false;
            btnCapture.Enabled = true;
            _isWaitingPhoto = false;
        }

        // =========================
        // USER PRESS CAPTURE
        // =========================
        private void BtnCapture_Click(object? sender, EventArgs e)
        {
            StartCountdown();
        }

        // =========================
        // START COUNTDOWN
        // =========================
        private void StartCountdown()
        {
            btnCapture.Enabled = false;

            _countdown = 3;
            label1.Text = _countdown.ToString();
            label1.Visible = true;

            _countdownTimer.Start();
        }

        // =========================
        // COUNTDOWN TICK
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

            _isWaitingPhoto = true;

            // 👉 REAL CAMERA WILL SHOOT NOW
            // EOS Utility / User press shutter / Pedal later
        }

        // =========================
        // START FOLDER WATCHER
        // =========================
        private void StartWatcher()
        {
            _watcher?.StopWatching();

            _watcher = new CameraWatcherService();
            _watcher.OnPhotoCaptured += Watcher_OnPhotoCaptured;

            string folder = @"C:\Users\Public\Photobooth\Incoming";
            _watcher.StartWatching(folder);
        }

        // =========================
        // WHEN PHOTO SAVED BY EOS
        // =========================
        private void Watcher_OnPhotoCaptured(string path)
        {
            try
            {
                if (!_isWaitingPhoto) return;
                if (!File.Exists(path)) return;

                Image img;

                using (var stream = new FileStream(
                    path,
                    FileMode.Open,
                    FileAccess.Read,
                    FileShare.ReadWrite))
                {
                    img = Image.FromStream(stream);
                }

                _isWaitingPhoto = false;

                this.Invoke(() =>
                {
                    _main?.ShowPreview(img);
                });
            }
            catch { }
        }
    }
}

