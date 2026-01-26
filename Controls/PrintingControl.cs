using System;
using System.Windows.Forms;

namespace PhotoboothVipstudios.Controls
{
    public partial class PrintingControl : UserControl
    {
        private MainForm? _main;
        private System.Windows.Forms.Timer _timer;

        // Constructor untuk Designer (WAJIB)
        public PrintingControl()
        {
            InitializeComponent();
        }

        // Constructor untuk Runtime
        public PrintingControl(MainForm main) : this()
        {
            _main = main;
        }

        // Dipanggil oleh MainForm
        public void StartPrinting()
        {
            _timer?.Stop();

            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 3000; // 3 saat simulasi print
            _timer.Tick += (sender, e) =>
            {
                _timer.Stop();
                _main?.ShowThankYou();
            };
            _timer.Start();
        }
    }
}
