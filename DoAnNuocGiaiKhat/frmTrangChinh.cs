using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnNuocGiaiKhat;
using Microsoft.Win32;

namespace DoAnNuocGiaiKhat
{
    public partial class frmTrangChinh : Form
    {
        private Form activeForm;
        private UserPreferenceChangedEventHandler UserPreferenceChanged;
        public frmTrangChinh()
        {
            InitializeComponent();
            LoadTheme();

            timer1.Start();
            timer2.Start();

            slTimer.Alignment = ToolStripItemAlignment.Right;
            StatusStrip.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;

            DayNow.Alignment = ToolStripItemAlignment.Right;
            StatusStrip.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;

            UserPreferenceChanged = new UserPreferenceChangedEventHandler(SystemEvents_UserPreferenceChanged);
            SystemEvents.UserPreferenceChanged += UserPreferenceChanged;
            this.Disposed += new EventHandler(Form_Disposed);
        }

        private void Form_Disposed(object sender, EventArgs e)
        {
            SystemEvents.UserPreferenceChanged -= UserPreferenceChanged;
        }

        private void SystemEvents_UserPreferenceChanged(object sender, UserPreferenceChangedEventArgs e)
        {
            if(e.Category == UserPreferenceCategory.General || e.Category == UserPreferenceCategory.VisualStyle)
            {
                LoadTheme();
            } 
        }

        private void LoadTheme()
        {
            var themeColor = Theme.LayMauNhan();//Windows Accent Color
            var lightColer = ControlPaint.Light(themeColor);
            var darkColer = ControlPaint.Dark(themeColor);

            var lightColor = ControlPaint.Light(themeColor);
            var darkColor = ControlPaint.Dark(themeColor);
            pnTieuDe.BackColor = themeColor;

            //Buttons
            foreach (Button button in this.Controls.OfType<Button>())
            {
                button.BackColor = themeColor;
            }
            foreach (Button button in this.pnMenu.Controls.OfType<Button>())
            {
                button.FlatAppearance.MouseOverBackColor = themeColor;
                button.FlatAppearance.MouseDownBackColor = lightColor;
            }
        }

        private void openChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnMain.Controls.Add(childForm);
            this.pnMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            frmLapHoaDon frmHoaDon = new frmLapHoaDon();
            lblTieuDe.Text = btnLapHoaDon.Text.ToUpper();
            openChildForm(frmHoaDon, sender);
        }

        private void btnXemHoaDon_Click(object sender, EventArgs e)
        {
            frmXemHoaDon frmXemHoaDon = new frmXemHoaDon();
            lblTieuDe.Text = btnXemHoaDon.Text.ToUpper();
            openChildForm(frmXemHoaDon, sender);
        }

        private void btnXemSanPham_Click(object sender, EventArgs e)
        {
            frmXemSanPham frmXemSP = new frmXemSanPham();
            lblTieuDe.Text = btnXemSanPham.Text.ToUpper();
            openChildForm(frmXemSP, sender);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            slTimer.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DayNow.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDangNhap frmDangNhap = new frmDangNhap();
            if(MessageBox.Show("Bạn có muốn đăng xuất","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
            {
                frmDangNhap.Show();
                this.Hide();
            }
            
        }
    }
}


