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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            this.Load += new EventHandler(FormMain_Load);
        }       
        //event for loading data to the main form
        private void FormMain_Load(object sender, EventArgs e)
        {
            QuanLyPhongTroEntities2 db = new QuanLyPhongTroEntities2();
            this.frmRoom.DataSource = db.Rooms.ToList().Select(r => new model.RoomView(r)).ToList();
            this.frmSession.DataSource = db.Sessions.ToList().Select(s=> new model.SessionView(s)).ToList();
            this.frmPrice.DataSource = db.Prices.ToList().Select(p => new model.PriceView(p)).ToList();
        }
        //function to refresh the data after add,edit or delete room after changes
        private void LoadFrmRoom()//Room
        {
            QuanLyPhongTroEntities2 db = new QuanLyPhongTroEntities2();
            this.frmRoom.DataSource = db.Rooms.ToList().Select(r => new model.RoomView(r)).ToList();
        }
        private void LoadFrmPrice()//Price
        {
            QuanLyPhongTroEntities2 db = new QuanLyPhongTroEntities2();
            this.frmPrice.DataSource = db.Prices.ToList().Select(p => new model.PriceView(p)).ToList();
        }
        private void LoadFrmSession()//Session
        {
            QuanLyPhongTroEntities2 db = new QuanLyPhongTroEntities2();
            this.frmSession.DataSource = db.Sessions.ToList().Select(s => new model.SessionView(s)).ToList();
        }
        //
        //
        //Add function for price , room and session
        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            FormAddRoom addroom = new FormAddRoom();
            addroom.ShowDialog();
            LoadFrmRoom();
        }
        private void btnAddPrice_Click(object sender, EventArgs e)
        {
            FormAddPrice addprice = new FormAddPrice();
            addprice.ShowDialog();
            LoadFrmPrice();
        }

        private void btnAddSession_Click(object sender, EventArgs e)
        {
            FormAddSession addsession = new FormAddSession();
            addsession.ShowDialog();
            LoadFrmSession();
        }
        //Edit function for price and room
        //Room
        private void frmRoom_DoubleClick(object sender, EventArgs e)
        {
            if (frmRoom.SelectedRows.Count==1)
            {
                var row = frmRoom.SelectedRows[0];
                var cell = row.Cells["id"];
                int id = (int)cell.Value;
                FormEditRoom editroom = new FormEditRoom(id);
                editroom.ShowDialog();
                LoadFrmRoom();
            }            
        }
        //Price
        private void frmPrice_DoubleClick(object sender, EventArgs e)
        {
            if (frmPrice.SelectedRows.Count == 1)
            {
                var row = frmPrice.SelectedRows[0];
                var cell = row.Cells["id"];
                int id = (int)cell.Value;
                FormEditPrice editprice = new FormEditPrice(id);
                editprice.ShowDialog();
                LoadFrmPrice();
            }
        }
        //Session
        private void frmSession_DoubleClick(object sender, EventArgs e)
        {
            if (frmSession.SelectedRows.Count == 1)
            {
                var row = frmSession.SelectedRows[0];
                var cell = row.Cells["ID"];
                int id = (int)cell.Value;
                FormEditSession editsession = new FormEditSession(id);
                editsession.ShowDialog();
                LoadFrmSession();
            }
        }
        //Delete funciton for price , room and session

        //Room
        private void btnDELETE_Click(object sender, EventArgs e)
        {
            var db = new QuanLyPhongTroEntities2();
            if (frmRoom.SelectedRows.Count==1)
            {
                var row = frmRoom.SelectedRows[0]; 
                var cell = row.Cells["id"];
                int id = (int)cell.Value;
                
                Room room = db.Rooms.Single(st => st.ID == id);
                db.Rooms.Remove(room);
                db.SaveChanges(); 
                this.LoadFrmRoom();
            }
        }
        //Price
        private void btnDeleteP_Click(object sender, EventArgs e)
        {
            var db = new QuanLyPhongTroEntities2();
            if (frmPrice.SelectedRows.Count == 1)
            {
                var row = frmPrice.SelectedRows[0];
                var cell = row.Cells["ID"];
                int id = (int)cell.Value;
                Price price = db.Prices.Single(st => st.ID == id);
                db.Prices.Remove(price);
                db.SaveChanges();
                this.LoadFrmPrice();
            }
        }
        //Session
        private void btnDeleteS_Click(object sender, EventArgs e)
        {
            var db = new QuanLyPhongTroEntities2();
            if (frmSession.SelectedRows.Count == 1)
            {
                var row = frmSession.SelectedRows[0];
                var cell = row.Cells["id"];
                int id = (int)cell.Value;
                Session session = db.Sessions.Single(st => st.ID == id);
                db.Sessions.Remove(session);
                db.SaveChanges();
                this.LoadFrmSession();
            }
        }

       
    }
        
}
