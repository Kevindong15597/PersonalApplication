using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongTro
{
    public partial class FormEditSession : Form
    {
        public FormEditSession(int ID)
        {
            InitializeComponent();
            var db = new QuanLyPhongTroEntities2();
            session = db.Sessions.Single(st => st.ID == ID);
        }
        private Session session;
        //
        private void FormEditSession_Load(object sender, EventArgs e)
        {
            var db = new QuanLyPhongTroEntities2();
            this.cboRoomName.DataSource = db.Rooms.ToList();
            this.cboRoomName.ValueMember = "id";
            this.cboRoomName.DisplayMember = "RoomName";
            this.cboRoomName.SelectedValue = session.Room.ID;
            this.dtpStart.Value = session.DateStart;
            this.dtpEnd.Value = session.DateEnd.Value;
            this.txtDuration.Text = session.Duration.ToString();
            this.txtBill.Text = session.Total.ToString();
            this.txtName.Text = session.TenantName;
            this.txtIDN.Text = session.TenantId;
        }
        //
        private void txtRoomType_TextChanged(object sender, EventArgs e)
        {
            int temp = int.Parse(txtDuration.Text);
            int Value = int.Parse(txtRoomType.Text);
            int? total;
            total = Value * temp;
            txtBill.Text = (" " + total);
        }
        //
        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            txtDuration.Text = (dtpEnd.Value - dtpStart.Value).TotalDays.ToString("#");
        }
        //

        //
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new QuanLyPhongTroEntities2();
                int RoomName = (int)(this.cboRoomName.SelectedValue);
                DateTime dateStart = dtpStart.Value;
                DateTime dateEnd = dtpEnd.Value;
                //
                int? duration;
                txtDuration.Text = (dtpEnd.Value - dtpStart.Value).TotalDays.ToString("#");
                duration = int.Parse(txtDuration.Text);
                //
                int? Bill = int.Parse(txtBill.Text);
                //
                var newSession = db.Sessions.Find(this.session.ID);
                newSession.RoomID = RoomName;
                newSession.DateStart = dateStart;
                newSession.DateEnd = dateEnd;
                newSession.Duration = duration;
                newSession.TenantName = txtName.Text;
                newSession.TenantId = txtIDN.Text;
                newSession.Total = Bill;
                //
                db.Entry(newSession).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input : please dont let any field empty");
            }
        }
        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
