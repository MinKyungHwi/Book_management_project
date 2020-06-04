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

// 변수 3개중 2개 입력시 가능하게
// 콤보박스 load 함수
// 
   
namespace proto.Panel
{
   
    public partial class OrderPane : UserControl
    {
        OleDbConnection con =new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source=order.accdb; Persist Security Info=False");

        //
        //
        //등록 Group 시작
        //
        //
        public OrderPane()
        {
            InitializeComponent();

            // 매입처 사명 콤보박스 
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT 사명 from company";
            cmd.Connection = con;
            OleDbDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                store_name.Items.Add(read.GetString(0));
                order_store_name.Items.Add(read.GetString(0));
                mana_book_store_name.Items.Add(read.GetString(0));

            }

            // 도서관리 도서명 콤보박스
            OleDbCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "SELECT 도서명 from T_order";
            OleDbDataReader read2 = cmd2.ExecuteReader();
            while (read2.Read())
            {
                mana_book_name.Items.Add(read2.GetString(0));
                combo_order_book_category.Items.Add(read2.GetString(0));
            }


            // 주문 도서 종류 콤보박스
            OleDbCommand cmd3 = con.CreateCommand();
            cmd3.CommandType = CommandType.Text;
            cmd3.CommandText = "SELECT 장르 from T_order group by 장르";
            OleDbDataReader read3 = cmd3.ExecuteReader();
            while (read3.Read())
            {
                combo_order_book_category.Items.Add(read3.GetString(0));
            }

            con.Close();
        }

        //등록 버튼
        private void Btn_store_add_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO company (사명, 주소, 전화번호) VALUES ('" + text_store_name.Text + "', '" + text_store_addr.Text + "', " + text_store_tel.Text + ") ";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(" 등록 완료 ");
            }
            catch

            {
                MessageBox.Show(" 등록 실패 ");
            }
        }

        //수정 버튼
        private void Btn_store_modify_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                OleDbDataReader read = cmd.ExecuteReader();
                cmd.CommandText = "UPDATE company SET 주소='" + text_store_addr.Text + "', 전화번호= " + text_store_tel.Text + " where 사명= '" + store_name.Text + "' ";
                cmd.ExecuteNonQuery();
                cmd.Connection = con;
                con.Close();
                MessageBox.Show(" 수정 완료 ");
            }
            catch
            {
                MessageBox.Show(" 수정 실패 ");
            }
        }

        //삭제 버튼
        private void Btn_store_delete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM company where 사명='" + store_name.Text + "' ";
                cmd.ExecuteNonQuery();
                cmd.Connection = con;
                con.Close();
                MessageBox.Show(" 삭제 완료 ");
            }
            catch
            {
                MessageBox.Show(" 삭제 실패 ");
            }
        }





        //
        //
        //주문 Group 시작
        //
        //
        //주문 전체 조회 버튼
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * from T_order";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                bunifuCustomDataGrid1.AllowUserToResizeColumns = true;
                bunifuCustomDataGrid1.DataSource = dt;
                con.Close();
            }
            catch
            {
                MessageBox.Show("조회 실패");
            }
        }

        // 매입처별 조회 버튼
        private void Btn_company_order_check_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * from T_order where 사명 = '" + order_store_name.Text + "' ";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                bunifuCustomDataGrid1.AllowUserToResizeColumns = true;
                bunifuCustomDataGrid1.DataSource = dt;
                con.Close();
            }
            catch
            {
                MessageBox.Show(" 조회 실패 ");
            }
        }


        // 날짜별 주문 조회 버튼
        private void Btn_date_order_check_Click(object sender, EventArgs e)
        {

            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * FROM T_order WHERE 구매일 BETWEEN '" + dateTimePicker1.Text + "' AND '" + dateTimePicker2.Text + "' ";
            cmd.ExecuteNonQuery();
             
            //"Select * FROM T_order  '" + dateTimePicker1.Text + "' ";

            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            bunifuCustomDataGrid1.AllowUserToResizeColumns = true;
            bunifuCustomDataGrid1.DataSource = dt;
            con.Close();
        }



        //주문 취소 버튼
        private void Btn_book_order_cancle_Click_1(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE from T_order where 도서명= '" + order_book_name.Text + "' ";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("삭제 완료");
            }
            catch
            {
                MessageBox.Show("삭제 실패");
            }
        }



        //주문 주문 버튼
        private void Btn_book_order_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime setDay;
                dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                setDay = dateTimePicker1.Value;

                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO T_order (도서명, 사명, 장르, 갯수, 구매일)  " +
                "VALUES ('" + order_book_name.Text + "', '" + order_store_name.Text + "', '" + order_book_category.Text + "' , " + order_book_amount.Text + ", '" + dateTimePicker1.Text + "')";
                cmd.ExecuteNonQuery();
                cmd.Connection = con;
                con.Close();
                MessageBox.Show(" 주문 완료 ");
            }
            catch
            {
                MessageBox.Show(" 주문 실패 ");
            }
        }


        //동종 도서 수량 변경 버튼
        private void Btn_samebook_modify_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE T_order SET 갯수= "+ order_book_amount_2.Text +" where 장르= '" + combo_order_book_category.Text + "' ";
            cmd.ExecuteNonQuery();
            cmd.Connection = con;
            con.Close();
            MessageBox.Show(" 수정 완료 ");
        }






        //
        //
        //도서관리 Group 시작
        //
        //
        //도서 재고 조회 버튼
        private void Btn_bookmana_check_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM book where 판매 = 'No' ";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                bunifuCustomDataGrid1.AllowUserToResizeColumns = true;
                bunifuCustomDataGrid1.DataSource = dt;
                con.Close();
            }
            catch
            {
                MessageBox.Show("재고 조회 실패");
            }
            
        }

        //도서 관리 등록 버튼
        private void Btn_bookmana_add_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO book (도서명, 사명, 갯수, 보유, 판매) " +
                "VALUES ('" + mana_book_name.Text + "', '" + mana_book_store_name.Text + "', " + mana_book_amount.Text + " , '"+ mana_book_have.Text + "' , '"+mana_book_sell.Text+"') ";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(" 등록 완료 ");
        }


        //도서 관리 미입고 버튼
        private void Btn_bookmana_not_IN_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM book where 보유 = 'No' ";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            bunifuCustomDataGrid1.AllowUserToResizeColumns = true;
            bunifuCustomDataGrid1.DataSource = dt;
            con.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
        }
    }
}
