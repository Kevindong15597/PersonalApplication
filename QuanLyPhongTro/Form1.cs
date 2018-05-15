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
           // this.btnAddRoom.Click += new EventHandler(btnAddRoom_Click);
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("success");
            FormAddRoom addroom = new FormAddRoom();
            addroom.ShowDialog();
             
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            QuanLyPhongTroEntities1 db = new QuanLyPhongTroEntities1();
            this.frmRoom.DataSource = db.Rooms.ToList().Select(r => new model.RoomView(r)).ToList();
            
            this.frmSession.DataSource = db.Sessions.ToList();
            this.frmPrice.DataSource = db.Prices.ToList().Select(p => new model.PriceView(p)).ToList();
        }

    }
        
}
