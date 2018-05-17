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
    public partial class FormAddSession : Form
    {
        public FormAddSession()
        {
            InitializeComponent();
        }
        //
        //
        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            txtDuration.Text = (dtpEnd.Value - dtpStart.Value).TotalDays.ToString("#");
        }
        //Save function event
        private void btnSave_Click(object sender, EventArgs e)
        {
            //create var to store the inputed information 
            try
            {
                string Name = txtName.Text;
                string ID = txtIDN.Text;
                string duration;
                txtDuration.Text = (dtpEnd.Value - dtpStart.Value).TotalDays.ToString("#");
                duration = txtDuration.Text;
                int? totalday = int.Parse(duration);
                DateTime dateStart = dtpStart.Value;
                DateTime dateEnd = dtpEnd.Value;
                //string Bill = txtBill.Text;
                int BillTotal = int.Parse(txtBill.Text);
                int RoomName = (int)(this.cboRoomName.SelectedValue);
                //create the connect to database
                var db = new QuanLyPhongTroEntities2();
                Session s = new Session();
                //storing the data with the new session
                s.DateStart = dateStart;
                s.DateEnd = dateEnd;
                s.Duration = totalday;
                s.TenantId = ID;
                s.TenantName = Name;
                s.RoomID = RoomName;
                s.Total = BillTotal;
                //
                //add the new  session into database
                db.Sessions.Add(s);
                db.SaveChanges();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input : please dont let the field empty");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAddSession_Load(object sender, EventArgs e)
        {
            var db = new QuanLyPhongTroEntities2();
            this.cboRoomName.DataSource = db.Rooms.ToList();
            this.cboRoomName.ValueMember = "ID";
            this.cboRoomName.DisplayMember = "RoomName";
        }

        private void txtRoomType_TextChanged_1(object sender, EventArgs e)
        {
            int temp = int.Parse(txtDuration.Text);
            int Value = int.Parse(txtRoomType.Text);
            int? total;
            total = Value * temp;
            txtBill.Text = (" "+total);
        }
    }
}
