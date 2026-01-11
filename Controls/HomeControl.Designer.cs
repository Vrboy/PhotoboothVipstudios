namespace PhotoboothVipstudios.Controls
{
    partial class HomeControl
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
            tblHome = new TableLayoutPanel();
            btnMula = new Button();
            tblHome.SuspendLayout();
            SuspendLayout();
            // 
            // tblHome
            // 
            tblHome.ColumnCount = 1;
            tblHome.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblHome.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblHome.Controls.Add(btnMula, 0, 0);
            tblHome.Dock = DockStyle.Fill;
            tblHome.Location = new Point(0, 0);
            tblHome.Name = "tblHome";
            tblHome.RowCount = 1;
            tblHome.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblHome.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblHome.Size = new Size(808, 475);
            tblHome.TabIndex = 0;
            // 
            // btnMula
            // 
            btnMula.Anchor = AnchorStyles.None;
            btnMula.BackColor = SystemColors.ControlLight;
            btnMula.FlatStyle = FlatStyle.Flat;
            btnMula.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMula.Location = new Point(254, 177);
            btnMula.Name = "btnMula";
            btnMula.Size = new Size(300, 120);
            btnMula.TabIndex = 0;
            btnMula.Text = "MULA";
            btnMula.UseVisualStyleBackColor = false;
            btnMula.Click += btnMula_Click;
            // 
            // HomeControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            Controls.Add(tblHome);
            Name = "HomeControl";
            Size = new Size(808, 475);
            tblHome.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblHome;
        private Button btnMula;
    }
}
