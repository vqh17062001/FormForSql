using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormForSql
{
    public partial class FormforSQL : Form
    {
        public FormforSQL()
        {
            InitializeComponent();
        }

        private void listBox_choose_SelectedIndexChanged(object sender, EventArgs e)
        {
            if( listBox_choose.SelectedIndex == 0 ) {
                string SQLconmand = "select * from THUOC ";
                dataGridViewfordata.DataSource = filldata(SQLconmand).Tables[0];
               
            
            }if (listBox_choose.SelectedIndex == 1) {
                string SQLconmand = "select * from NhaSanXuat ";
                dataGridViewfordata.DataSource = filldata(SQLconmand).Tables[0];
            }
        }

        DataSet filldata(string SQLconmand) { 
            DataSet data = new DataSet();
            string connetionstring = "Data Source=ZEPHYRUSG14\\MSSQLSERVER01;Initial Catalog=QL_THUOC;Persist Security Info=True;User ID=sa;Password=Qnvn16062001@";
            
            using (SqlConnection sqlConnection = new SqlConnection(connetionstring)) { 
                sqlConnection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(SQLconmand,connetionstring);

                adapter.Fill(data);
                sqlConnection.Close();

            }
              return data;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (listBox_choose.SelectedIndex == 0) {
                MessageBox.Show("choosed 0 hello ");

            
            }
            if (listBox_choose.SelectedIndex == 1) { 
                MessageBox.Show("choosed 1");
            }

        }
    }
}
