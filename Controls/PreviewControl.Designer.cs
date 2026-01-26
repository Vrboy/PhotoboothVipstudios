namespace PhotoboothVipstudios.Controls
{
    partial class PreviewControl
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
            pictureBoxPreview = new PictureBox();
            btnRetake = new Button();
            btnContinue = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPreview).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxPreview
            // 
            pictureBoxPreview.Location = new Point(105, 12);
            pictureBoxPreview.Name = "pictureBoxPreview";
            pictureBoxPreview.Size = new Size(645, 284);
            pictureBoxPreview.TabIndex = 0;
            pictureBoxPreview.TabStop = false;
            // 
            // btnRetake
            // 
            btnRetake.BackColor = SystemColors.ActiveCaptionText;
            btnRetake.Font = new Font("Shrikhand", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRetake.ForeColor = SystemColors.ButtonHighlight;
            btnRetake.Location = new Point(166, 319);
            btnRetake.Name = "btnRetake";
            btnRetake.Size = new Size(186, 84);
            btnRetake.TabIndex = 1;
            btnRetake.Text = "Ambil Semula ";
            btnRetake.UseVisualStyleBackColor = false;
            // 
            // btnContinue
            // 
            btnContinue.BackColor = SystemColors.MenuHighlight;
            btnContinue.Font = new Font("Shrikhand", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnContinue.Location = new Point(436, 302);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(234, 101);
            btnContinue.TabIndex = 2;
            btnContinue.Text = "TERUSKAN";
            btnContinue.UseVisualStyleBackColor = false;
            // 
            // PreviewControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnContinue);
            Controls.Add(btnRetake);
            Controls.Add(pictureBoxPreview);
            Name = "PreviewControl";
            Size = new Size(864, 434);
            ((System.ComponentModel.ISupportInitialize)pictureBoxPreview).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxPreview;
        private Button btnRetake;
        private Button btnContinue;
    }
}
