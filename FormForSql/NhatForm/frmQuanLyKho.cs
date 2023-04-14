using FormForSql.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormForSql.NhatForm
{
    public partial class frmQuanLyKho : Form
    {
        public frmQuanLyKho()
        {
            InitializeComponent();
        }
        private dcQuanLyKho db;
        private void frmQuanLyKho_Load(object sender, EventArgs e)
        {
            db = new dcQuanLyKho();
            Showdata();
        }
        private void Showdata()
        {
            dgvQuanLyKho.DataSource = db.Khos.ToList();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dgvQuanLyKho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
