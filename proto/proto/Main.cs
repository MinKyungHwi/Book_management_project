using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace proto
{
    public partial class Main : Form
    {
        Point mouse_down;
        bool click;
        BunifuFlatButton currentBtn;
        Control CurrentPanel;

        public Main()
        {
            InitializeComponent();

            //Initiallize
            click = false;
            Lbl_Clock.Text = DateTime.Now.ToString();
        }

        //닫기 버튼
        private void Btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //타이틀바 움직임 효과
        private void Panel_Title_MouseMove(object sender, MouseEventArgs e)
        {
            if (click)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - mouse_down.X, p.Y - mouse_down.Y);
            }
        }

        private void Panel_Title_MouseUp(object sender, MouseEventArgs e)
        {
            click = false;
        }

        private void Panel_Title_MouseDown(object sender, MouseEventArgs e)
        {
            click = true;
            mouse_down = new Point(e.X, e.Y);
        }

        //최소화 버튼
        private void Btn_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //시계
        private void Timer_Clock_Tick(object sender, EventArgs e)
        {
            Lbl_Clock.Text = DateTime.Now.ToString();
        }

        private void Btn_Home_Click(object sender, EventArgs e)
        {
            if (mainPane1.Visible == false)
            {
                if(CurrentPanel != null)
                    Effect.HideSync(CurrentPanel);
                CurrentPanel = mainPane1;

                if (currentBtn != null)
                    currentBtn.Textcolor = Color.FromArgb(121, 134, 163);
                Btn_Home.Textcolor = Color.White;
                currentBtn = Btn_Home;

                Select_Menu.Visible = true;
                Select_Menu.Location = new Point(Btn_Home.Location.X + 15, 48);
                Select_Menu.Size = new Size(Btn_Home.Size.Width - 30, 5);
                Effect.ShowSync(mainPane1);
            }
        }

        private void Btn_Purchase_Click(object sender, EventArgs e)
        {
            if (purchasePane1.Visible == false)
            {
                if (CurrentPanel != null)
                    Effect.HideSync(CurrentPanel);
                CurrentPanel = purchasePane1;

                if (currentBtn != null)
                    currentBtn.Textcolor = Color.FromArgb(121, 134, 163);
                Btn_Purchase.Textcolor = Color.White;
                currentBtn = Btn_Purchase;

                Select_Menu.Visible = true;
                Select_Menu.Location = new Point(Btn_Purchase.Location.X + 15, 48);
                Select_Menu.Size = new Size(Btn_Purchase.Size.Width - 30, 5);
                Effect.ShowSync(purchasePane1);
            }
        }

        private void Btn_Sell_Click(object sender, EventArgs e)
        {
            if (sellPane1.Visible == false)
            {
                if (CurrentPanel != null)
                    Effect.HideSync(CurrentPanel);
                CurrentPanel = sellPane1;

                if (currentBtn != null)
                    currentBtn.Textcolor = Color.FromArgb(121, 134, 163);
                Btn_Sell.Textcolor = Color.White;
                currentBtn = Btn_Sell;

                Select_Menu.Visible = true;
                Select_Menu.Location = new Point(Btn_Sell.Location.X + 15, 48);
                Select_Menu.Size = new Size(Btn_Sell.Size.Width - 30, 5);
                Effect.ShowSync(sellPane1);
            }
        }

        private void Btn_Customer_Click(object sender, EventArgs e)
        {
            if (customerPane1.Visible == false)
            {
                if (CurrentPanel != null)
                    Effect.HideSync(CurrentPanel);
                CurrentPanel = customerPane1;

                if (currentBtn != null)
                    currentBtn.Textcolor = Color.FromArgb(121, 134, 163);
                Btn_Customer.Textcolor = Color.White;
                currentBtn = Btn_Customer;

                Select_Menu.Visible = true;
                Select_Menu.Location = new Point(Btn_Customer.Location.X + 15, 48);
                Select_Menu.Size = new Size(Btn_Customer.Size.Width - 30, 5);
                Effect.ShowSync(customerPane1);
            }
        }

        private void Btn_Order_Click(object sender, EventArgs e)
        {
            if (orderPane1.Visible == false)
            {
                if (CurrentPanel != null)
                    Effect.HideSync(CurrentPanel);
                CurrentPanel = orderPane1;

                if (currentBtn != null)
                    currentBtn.Textcolor = Color.FromArgb(121, 134, 163);
                Btn_Order.Textcolor = Color.White;
                currentBtn = Btn_Order;

                Select_Menu.Visible = true;
                Select_Menu.Location = new Point(Btn_Order.Location.X + 15, 48);
                Select_Menu.Size = new Size(Btn_Order.Size.Width - 30, 5);
                Effect.ShowSync(orderPane1);
            }
        }
    }
}
