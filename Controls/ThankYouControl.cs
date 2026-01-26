using System;
using System.Windows.Forms;

namespace PhotoboothVipstudios.Controls
{
    public partial class ThankYouControl : UserControl
    {
        private MainForm? _main;
        private System.Windows.Forms.Timer _timer;

        // Constructor untuk Designer (WAJIB)
        public ThankYouControl()
        {
            InitializeComponent();
        }

        // Constructor untuk Runtime
        public ThankYouControl(MainForm main) : this()
        {
            _main = main;
        }

        // Dipanggil oleh MainForm
        public void StartAutoReset()
        {
            _timer?.Stop();

            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 5000; // 5 saat lepas tu reset
            _timer.Tick += (sender, e) =>
            {
                _timer.Stop();
                _main?.ShowHome();
            };
            _timer.Start();
        }
    }
}
