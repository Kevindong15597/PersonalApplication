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
    public partial class FormAddPrice : Form
    {
        public FormAddPrice()
        {
            InitializeComponent();
        }

        private void FormAddPrice_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string VName = txtVName.Text;
                int Value = int.Parse(txtValue.Text);
                Price p = new Price();
                p.ValueName = VName;
                p.Value = Value;

                var db = new QuanLyPhongTroEntities2();
                db.Prices.Add(p);
                db.SaveChanges();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("please input field :VALUE ");
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
