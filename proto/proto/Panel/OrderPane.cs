using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace proto.Panel
{
   
    public partial class OrderPane : UserControl
    {
        OleDbConnection con =new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source=C:\\AccessDB\\order.accdb; Persist Security Info=False");

        public OrderPane()
        {
            InitializeComponent();
        }

        private void Btn_store_add_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText= "INSERT INTO company (사명, 주소, 전화번호) VALUES ('"+text_store_name+"', '"+text_store_addr+"', "+text_store_tel+") ";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(" 등록 완료 ");
        }

        private void Btn_store_modify_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE company SET 사명='" + text_store_name + "', 주소='" + text_store_addr + "', 전화번호= " + text_store_tel + "' ";
            cmd.ExecuteNonQuery();
            cmd.Connection = con;
            con.Close();
            MessageBox.Show(" 수정 완료 ");
        }
    }
}


