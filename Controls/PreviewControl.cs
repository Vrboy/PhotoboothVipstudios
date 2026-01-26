using System;
using System.Drawing;
using System.Windows.Forms;

namespace PhotoboothVipstudios.Controls
{
    public partial class PreviewControl : UserControl
    {
        private MainForm? _main;
        private Image? _image;

        // Constructor untuk Designer (WAJIB)
        public PreviewControl()
        {
            InitializeComponent();

            // Wire button SEKALI sahaja
            btnRetake.Click += BtnRetake_Click;
            btnContinue.Click += BtnContinue_Click;
        }

        // Constructor untuk Runtime
        public PreviewControl(MainForm main, Image image) : this()
        {
            _main = main;
            _image = image;

            ShowImage();
        }

        // Papar gambar dalam PictureBox
        private void ShowImage()
        {
            // Dispose image lama (safety net)
            pictureBoxPreview.Image?.Dispose();

            pictureBoxPreview.Image = _image;
            pictureBoxPreview.SizeMode = PictureBoxSizeMode.Zoom;
        }

        // 🔁 Ambil semula → balik ke Camera
        private void BtnRetake_Click(object? sender, EventArgs e)
        {
            Cleanup();
            _main?.ShowCamera();
        }

        // ✅ Teruskan → masuk Payment
        private void BtnContinue_Click(object? sender, EventArgs e)
        {
            if (_image == null) return;

            _main?.ShowPayment(_image);
        }

        // Bersihkan resource bila keluar screen
        private void Cleanup()
        {
            pictureBoxPreview.Image = null;
            _image = null;
        }
    }
}
