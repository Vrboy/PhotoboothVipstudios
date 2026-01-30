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
            tableLayoutPanel1 = new TableLayoutPanel();
            btnContinue = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPreview).BeginInit();
            tableLayoutPanel1.SuspendLayout();
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
            btnRetake.Anchor = AnchorStyles.None;
            btnRetake.BackColor = SystemColors.ActiveCaptionText;
            btnRetake.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRetake.ForeColor = SystemColors.ButtonHighlight;
            btnRetake.Location = new Point(68, 8);
            btnRetake.Name = "btnRetake";
            btnRetake.Size = new Size(186, 84);
            btnRetake.TabIndex = 1;
            btnRetake.Text = "AMBIL SEMULA";
            btnRetake.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnRetake, 0, 0);
            tableLayoutPanel1.Controls.Add(btnContinue, 1, 0);
            tableLayoutPanel1.Location = new Point(105, 302);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(645, 100);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // btnContinue
            // 
            btnContinue.Anchor = AnchorStyles.None;
            btnContinue.BackColor = SystemColors.MenuHighlight;
            btnContinue.Font = new Font("Impact", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnContinue.ForeColor = SystemColors.ButtonHighlight;
            btnContinue.Location = new Point(366, 3);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(234, 94);
            btnContinue.TabIndex = 2;
            btnContinue.Text = "TERUSKAN";
            btnContinue.UseVisualStyleBackColor = false;
            // 
            // PreviewControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(pictureBoxPreview);
            Name = "PreviewControl";
            Size = new Size(864, 434);
            ((System.ComponentModel.ISupportInitialize)pictureBoxPreview).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxPreview;
        private Button btnRetake;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnContinue;
    }
}
