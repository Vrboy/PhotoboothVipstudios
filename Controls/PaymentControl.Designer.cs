namespace PhotoboothVipstudios.Controls
{
    partial class PaymentControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            pictureBoxQr = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxQr).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(312, 26);
            label1.Name = "label1";
            label1.Size = new Size(176, 32);
            label1.TabIndex = 0;
            label1.Text = "SILA IMBAS QR";
            // 
            // pictureBoxQr
            // 
            pictureBoxQr.Location = new Point(349, 100);
            pictureBoxQr.Name = "pictureBoxQr";
            pictureBoxQr.Size = new Size(100, 50);
            pictureBoxQr.TabIndex = 1;
            pictureBoxQr.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(312, 378);
            label2.Name = "label2";
            label2.Size = new Size(178, 15);
            label2.TabIndex = 2;
            label2.Text = "sila tunggu pengesahan bayaran";
            // 
            // PaymentControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(pictureBoxQr);
            Controls.Add(label1);
            Name = "PaymentControl";
            Size = new Size(830, 427);
            ((System.ComponentModel.ISupportInitialize)pictureBoxQr).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBoxQr;
        private Label label2;
    }
}
