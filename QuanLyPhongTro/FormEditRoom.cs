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
    public partial class FormEditRoom : Form
    {
        public FormEditRoom(int ID)
        {
            var db = new QuanLyPhongTroEntities2();
            InitializeComponent();
            room = db.Rooms.Single(st => st.ID == ID );
        }
        private Room room;       
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int Type = (int)(this.cboRoomType.SelectedValue);
            int Status = (int)(this.cboRoomStatus.SelectedValue);
            var db = new QuanLyPhongTroEntities2();
            var newRoom = db.Rooms.Find(this.room.ID);
            newRoom.RoomName = txtRoomName.Text;
            newRoom.TypeID = Type;
            newRoom.StatusID = Status;
            db.Entry(newRoom).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //function for loading data to the Edit Form
        private void FormEditRoom_Load(object sender, EventArgs e)
        {
            QuanLyPhongTroEntities2 db = new QuanLyPhongTroEntities2();
            //loading the DataSource
            this.cboRoomStatus.DataSource = db.RoomStatus.ToList();
            this.cboRoomType.DataSource = db.Prices.ToList();
            //display the status name into the combobox
            this.cboRoomStatus.ValueMember = "ID";
            this.cboRoomStatus.DisplayMember = "StatusName";

            //loading current data to combobox /Room Type
            
            this.cboRoomType.ValueMember = "ID";
            this.cboRoomType.DisplayMember = "ValueName";
            //
            this.txtRoomName.Text = room.RoomName;
            //loading current data to combobox /Room status
            this.cboRoomStatus.SelectedValue = room.StatusID;
            this.cboRoomType.SelectedValue = room.TypeID;
            
           
            


        }
    }
}
