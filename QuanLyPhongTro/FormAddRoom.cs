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
    public partial class FormAddRoom : Form
    {
        public FormAddRoom()
        {
            InitializeComponent();
            this.Load += new EventHandler(FormAddRoom_Load);
            this.btnSave.Click += new EventHandler(btnSave_Click);
            this.btnCancel.Click += new EventHandler(btnCancel_Click);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            string RoomName = this.txtRoomName.Text;
            int RoomType = (int)this.cboRoomType.SelectedValue;
            int RoomStatus = (int)this.cboRoomStatus.SelectedValue;
            var db = new QuanLyPhongTroEntities1();
            Room room = new Room();
            room.StatusID = RoomStatus;
            room.RoomName = RoomName;
            room.TypeID = RoomType;
            db.Rooms.Add(room);
            db.SaveChanges();
            MessageBox.Show("Success");
            this.Close();
        }

        private void FormAddRoom_Load(object sender, EventArgs e)
        {
            
            QuanLyPhongTroEntities1 db = new QuanLyPhongTroEntities1();
            //loading data for combo box Room status
            this.cboRoomStatus.DataSource = db.RoomStatus.ToList();
            //display the status name into the combo box
            this.cboRoomStatus.ValueMember ="ID";
            this.cboRoomStatus.DisplayMember = "StatusName";
            //loading data for combo box Room Type
            this.cboRoomType.DataSource = db.Prices.ToList();
            this.cboRoomType.ValueMember = "ID";
            this.cboRoomType.DisplayMember = "ValueName";

        }
    }
}
