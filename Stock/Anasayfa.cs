using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace Stock
{
    public partial class Anasayfa : Form
    {
        SqlConnection con = new SqlConnection();
        ArrayList list = new ArrayList();
        public Anasayfa()
        {
            InitializeComponent();
            
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            label1.Text = login.UserName;
        }
     

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand sql = new SqlCommand("SELECT [UserName] FROM[Stock].[dbo].[login] ",con);
            SqlDataReader reader = sql.ExecuteReader();
            while(reader.Read())
            {
                list.Add(Convert.ToInt32(reader[0].ToString()));
            }
            con.Close();
            MessageBox.Show(list.ToString());
    }
}
