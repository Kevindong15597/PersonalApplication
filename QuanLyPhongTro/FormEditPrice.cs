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
    public partial class FormEditPrice : Form
    {
        public FormEditPrice(int ID)
        {
            var db = new QuanLyPhongTroEntities2();
            InitializeComponent();
            price = db.Prices.Single(st => st.ID == ID);
        }
        //
        private Price price;
        private void FormEditPrice_Load(object sender, EventArgs e)
        {
            var db = new QuanLyPhongTroEntities2();
            this.txtValue.Text = price.Value.ToString();
            this.txtVName.Text = price.ValueName.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var db = new QuanLyPhongTroEntities2();
            var newPrice = db.Prices.Find(this.price.ID);
            int tempValue = int.Parse(txtValue.Text);           
            newPrice.Value = tempValue;
            newPrice.ValueName = txtVName.Text;          
            db.Entry(newPrice).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
