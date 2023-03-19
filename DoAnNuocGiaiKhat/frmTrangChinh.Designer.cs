namespace DoAnNuocGiaiKhat
{
    partial class frmTrangChinh
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnTieuDe = new System.Windows.Forms.Panel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.pnLogo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnMain = new System.Windows.Forms.Panel();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.slTimer = new System.Windows.Forms.ToolStripStatusLabel();
            this.DayNow = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btnXemSanPham = new System.Windows.Forms.Button();
            this.btnXemHoaDon = new System.Windows.Forms.Button();
            this.btnLapHoaDon = new System.Windows.Forms.Button();
            this.pnTieuDe.SuspendLayout();
            this.pnMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnMain.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTieuDe
            // 
            this.pnTieuDe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnTieuDe.Controls.Add(this.lblTieuDe);
            this.pnTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTieuDe.Location = new System.Drawing.Point(326, 0);
            this.pnTieuDe.Name = "pnTieuDe";
            this.pnTieuDe.Size = new System.Drawing.Size(1274, 75);
            this.pnTieuDe.TabIndex = 0;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(446, 9);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(390, 52);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "SPORT DRINK";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnMenu.Controls.Add(this.button1);
            this.pnMenu.Controls.Add(this.btnXemSanPham);
            this.pnMenu.Controls.Add(this.btnXemHoaDon);
            this.pnMenu.Controls.Add(this.btnLapHoaDon);
            this.pnMenu.Controls.Add(this.pnLogo);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(326, 900);
            this.pnMenu.TabIndex = 1;
            // 
            // pnLogo
            // 
            this.pnLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.pnLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLogo.Location = new System.Drawing.Point(0, 0);
            this.pnLogo.Name = "pnLogo";
            this.pnLogo.Size = new System.Drawing.Size(326, 75);
            this.pnLogo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pnMain);
            this.panel1.Controls.Add(this.pnTieuDe);
            this.panel1.Controls.Add(this.pnMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1600, 900);
            this.panel1.TabIndex = 2;
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.StatusStrip);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(326, 75);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1274, 825);
            this.pnMain.TabIndex = 2;
            // 
            // StatusStrip
            // 
            this.StatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DayNow,
            this.slTimer});
            this.StatusStrip.Location = new System.Drawing.Point(0, 799);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(1274, 26);
            this.StatusStrip.TabIndex = 0;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // slTimer
            // 
            this.slTimer.Name = "slTimer";
            this.slTimer.Size = new System.Drawing.Size(41, 20);
            this.slTimer.Text = "Date";
            // 
            // DayNow
            // 
            this.DayNow.Name = "DayNow";
            this.DayNow.Size = new System.Drawing.Size(42, 20);
            this.DayNow.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = global::DoAnNuocGiaiKhat.Properties.Resources.logout;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(0, 839);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(326, 61);
            this.button1.TabIndex = 4;
            this.button1.Text = "Đăng xuất         ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnXemSanPham
            // 
            this.btnXemSanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnXemSanPham.FlatAppearance.BorderSize = 0;
            this.btnXemSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemSanPham.ForeColor = System.Drawing.Color.Transparent;
            this.btnXemSanPham.Image = global::DoAnNuocGiaiKhat.Properties.Resources.water_bottle;
            this.btnXemSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemSanPham.Location = new System.Drawing.Point(0, 197);
            this.btnXemSanPham.Name = "btnXemSanPham";
            this.btnXemSanPham.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnXemSanPham.Size = new System.Drawing.Size(326, 61);
            this.btnXemSanPham.TabIndex = 3;
            this.btnXemSanPham.Text = "    Xem Sản Phẩm";
            this.btnXemSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemSanPham.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXemSanPham.UseVisualStyleBackColor = true;
            this.btnXemSanPham.Click += new System.EventHandler(this.btnXemSanPham_Click);
            // 
            // btnXemHoaDon
            // 
            this.btnXemHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnXemHoaDon.FlatAppearance.BorderSize = 0;
            this.btnXemHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemHoaDon.ForeColor = System.Drawing.Color.Transparent;
            this.btnXemHoaDon.Image = global::DoAnNuocGiaiKhat.Properties.Resources.bill;
            this.btnXemHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemHoaDon.Location = new System.Drawing.Point(0, 136);
            this.btnXemHoaDon.Name = "btnXemHoaDon";
            this.btnXemHoaDon.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnXemHoaDon.Size = new System.Drawing.Size(326, 61);
            this.btnXemHoaDon.TabIndex = 2;
            this.btnXemHoaDon.Text = "    Xem Hóa Đơn";
            this.btnXemHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemHoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXemHoaDon.UseVisualStyleBackColor = true;
            this.btnXemHoaDon.Click += new System.EventHandler(this.btnXemHoaDon_Click);
            // 
            // btnLapHoaDon
            // 
            this.btnLapHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLapHoaDon.FlatAppearance.BorderSize = 0;
            this.btnLapHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLapHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapHoaDon.ForeColor = System.Drawing.Color.Transparent;
            this.btnLapHoaDon.Image = global::DoAnNuocGiaiKhat.Properties.Resources.report__1_;
            this.btnLapHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLapHoaDon.Location = new System.Drawing.Point(0, 75);
            this.btnLapHoaDon.Name = "btnLapHoaDon";
            this.btnLapHoaDon.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnLapHoaDon.Size = new System.Drawing.Size(326, 61);
            this.btnLapHoaDon.TabIndex = 1;
            this.btnLapHoaDon.Text = "    Lập Hóa Đơn";
            this.btnLapHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLapHoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLapHoaDon.UseVisualStyleBackColor = true;
            this.btnLapHoaDon.Click += new System.EventHandler(this.btnLapHoaDon_Click);
            // 
            // frmTrangChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTrangChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTrangChinh";
            this.pnTieuDe.ResumeLayout(false);
            this.pnMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTieuDe;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Button btnLapHoaDon;
        private System.Windows.Forms.Panel pnLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXemSanPham;
        private System.Windows.Forms.Button btnXemHoaDon;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel slTimer;
        private System.Windows.Forms.ToolStripStatusLabel DayNow;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button1;
    }
}