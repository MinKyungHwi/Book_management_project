namespace proto
{
    partial class Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Panel_Title = new System.Windows.Forms.Panel();
            this.Lbl_Clock = new System.Windows.Forms.Label();
            this.Btn_Minimize = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Maximize = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Close = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Timer_Clock = new System.Windows.Forms.Timer(this.components);
            this.Panel_Background = new System.Windows.Forms.Panel();
            this.Panel_Menu = new System.Windows.Forms.Panel();
            this.Select_Menu = new System.Windows.Forms.Panel();
            this.Btn_Order = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Customer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Sell = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Purchase = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Home = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Effect = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.orderPane1 = new proto.Panel.OrderPane();
            this.customerPane1 = new proto.Panel.CustomerPane();
            this.sellPane1 = new proto.Panel.SellPane();
            this.purchasePane1 = new proto.Panel.PurchasePane();
            this.mainPane1 = new proto.Panel.MainPane();
            this.Panel_Title.SuspendLayout();
            this.Panel_Background.SuspendLayout();
            this.Panel_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Title
            // 
            this.Panel_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(12)))), ((int)(((byte)(25)))));
            this.Panel_Title.Controls.Add(this.Lbl_Clock);
            this.Panel_Title.Controls.Add(this.Btn_Minimize);
            this.Panel_Title.Controls.Add(this.Btn_Maximize);
            this.Panel_Title.Controls.Add(this.Btn_Close);
            this.Effect.SetDecoration(this.Panel_Title, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Title.Location = new System.Drawing.Point(0, 0);
            this.Panel_Title.Name = "Panel_Title";
            this.Panel_Title.Size = new System.Drawing.Size(1280, 23);
            this.Panel_Title.TabIndex = 0;
            this.Panel_Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_Title_MouseDown);
            this.Panel_Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_Title_MouseMove);
            this.Panel_Title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_Title_MouseUp);
            // 
            // Lbl_Clock
            // 
            this.Lbl_Clock.AutoSize = true;
            this.Effect.SetDecoration(this.Lbl_Clock, BunifuAnimatorNS.DecorationType.None);
            this.Lbl_Clock.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Lbl_Clock.ForeColor = System.Drawing.Color.White;
            this.Lbl_Clock.Location = new System.Drawing.Point(951, 3);
            this.Lbl_Clock.Name = "Lbl_Clock";
            this.Lbl_Clock.Size = new System.Drawing.Size(49, 16);
            this.Lbl_Clock.TabIndex = 3;
            this.Lbl_Clock.Text = "Clock";
            // 
            // Btn_Minimize
            // 
            this.Btn_Minimize.Activecolor = System.Drawing.Color.Gray;
            this.Btn_Minimize.BackColor = System.Drawing.Color.Black;
            this.Btn_Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Minimize.BorderRadius = 0;
            this.Btn_Minimize.ButtonText = "-";
            this.Btn_Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Effect.SetDecoration(this.Btn_Minimize, BunifuAnimatorNS.DecorationType.None);
            this.Btn_Minimize.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Minimize.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btn_Minimize.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Minimize.Iconimage = null;
            this.Btn_Minimize.Iconimage_right = null;
            this.Btn_Minimize.Iconimage_right_Selected = null;
            this.Btn_Minimize.Iconimage_Selected = null;
            this.Btn_Minimize.IconMarginLeft = 0;
            this.Btn_Minimize.IconMarginRight = 0;
            this.Btn_Minimize.IconRightVisible = true;
            this.Btn_Minimize.IconRightZoom = 0D;
            this.Btn_Minimize.IconVisible = true;
            this.Btn_Minimize.IconZoom = 90D;
            this.Btn_Minimize.IsTab = false;
            this.Btn_Minimize.Location = new System.Drawing.Point(1199, 0);
            this.Btn_Minimize.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Minimize.Name = "Btn_Minimize";
            this.Btn_Minimize.Normalcolor = System.Drawing.Color.Black;
            this.Btn_Minimize.OnHovercolor = System.Drawing.Color.Gray;
            this.Btn_Minimize.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Minimize.selected = false;
            this.Btn_Minimize.Size = new System.Drawing.Size(27, 23);
            this.Btn_Minimize.TabIndex = 2;
            this.Btn_Minimize.Text = "-";
            this.Btn_Minimize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Minimize.Textcolor = System.Drawing.Color.White;
            this.Btn_Minimize.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Minimize.Click += new System.EventHandler(this.Btn_Minimize_Click);
            // 
            // Btn_Maximize
            // 
            this.Btn_Maximize.Activecolor = System.Drawing.Color.Gray;
            this.Btn_Maximize.BackColor = System.Drawing.Color.Black;
            this.Btn_Maximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Maximize.BorderRadius = 0;
            this.Btn_Maximize.ButtonText = "□";
            this.Btn_Maximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Effect.SetDecoration(this.Btn_Maximize, BunifuAnimatorNS.DecorationType.None);
            this.Btn_Maximize.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Maximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Maximize.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btn_Maximize.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Maximize.Iconimage = null;
            this.Btn_Maximize.Iconimage_right = null;
            this.Btn_Maximize.Iconimage_right_Selected = null;
            this.Btn_Maximize.Iconimage_Selected = null;
            this.Btn_Maximize.IconMarginLeft = 0;
            this.Btn_Maximize.IconMarginRight = 0;
            this.Btn_Maximize.IconRightVisible = true;
            this.Btn_Maximize.IconRightZoom = 0D;
            this.Btn_Maximize.IconVisible = true;
            this.Btn_Maximize.IconZoom = 90D;
            this.Btn_Maximize.IsTab = false;
            this.Btn_Maximize.Location = new System.Drawing.Point(1226, 0);
            this.Btn_Maximize.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Maximize.Name = "Btn_Maximize";
            this.Btn_Maximize.Normalcolor = System.Drawing.Color.Black;
            this.Btn_Maximize.OnHovercolor = System.Drawing.Color.Gray;
            this.Btn_Maximize.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Maximize.selected = false;
            this.Btn_Maximize.Size = new System.Drawing.Size(27, 23);
            this.Btn_Maximize.TabIndex = 1;
            this.Btn_Maximize.Text = "□";
            this.Btn_Maximize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Maximize.Textcolor = System.Drawing.Color.White;
            this.Btn_Maximize.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Btn_Close
            // 
            this.Btn_Close.Activecolor = System.Drawing.Color.Gray;
            this.Btn_Close.BackColor = System.Drawing.Color.Black;
            this.Btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Close.BorderRadius = 0;
            this.Btn_Close.ButtonText = "X";
            this.Btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Effect.SetDecoration(this.Btn_Close, BunifuAnimatorNS.DecorationType.None);
            this.Btn_Close.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Close.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btn_Close.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Close.Iconimage = null;
            this.Btn_Close.Iconimage_right = null;
            this.Btn_Close.Iconimage_right_Selected = null;
            this.Btn_Close.Iconimage_Selected = null;
            this.Btn_Close.IconMarginLeft = 0;
            this.Btn_Close.IconMarginRight = 0;
            this.Btn_Close.IconRightVisible = true;
            this.Btn_Close.IconRightZoom = 0D;
            this.Btn_Close.IconVisible = true;
            this.Btn_Close.IconZoom = 90D;
            this.Btn_Close.IsTab = false;
            this.Btn_Close.Location = new System.Drawing.Point(1253, 0);
            this.Btn_Close.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Normalcolor = System.Drawing.Color.Black;
            this.Btn_Close.OnHovercolor = System.Drawing.Color.Gray;
            this.Btn_Close.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Close.selected = false;
            this.Btn_Close.Size = new System.Drawing.Size(27, 23);
            this.Btn_Close.TabIndex = 0;
            this.Btn_Close.Text = "X";
            this.Btn_Close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Close.Textcolor = System.Drawing.Color.White;
            this.Btn_Close.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Timer_Clock
            // 
            this.Timer_Clock.Enabled = true;
            this.Timer_Clock.Interval = 1000;
            this.Timer_Clock.Tick += new System.EventHandler(this.Timer_Clock_Tick);
            // 
            // Panel_Background
            // 
            this.Panel_Background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(31)))), ((int)(((byte)(48)))));
            this.Panel_Background.Controls.Add(this.orderPane1);
            this.Panel_Background.Controls.Add(this.customerPane1);
            this.Panel_Background.Controls.Add(this.sellPane1);
            this.Panel_Background.Controls.Add(this.purchasePane1);
            this.Panel_Background.Controls.Add(this.mainPane1);
            this.Panel_Background.Controls.Add(this.Panel_Menu);
            this.Effect.SetDecoration(this.Panel_Background, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Background.Location = new System.Drawing.Point(0, 23);
            this.Panel_Background.Name = "Panel_Background";
            this.Panel_Background.Size = new System.Drawing.Size(1280, 697);
            this.Panel_Background.TabIndex = 1;
            // 
            // Panel_Menu
            // 
            this.Panel_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(23)))), ((int)(((byte)(38)))));
            this.Panel_Menu.Controls.Add(this.Select_Menu);
            this.Panel_Menu.Controls.Add(this.Btn_Order);
            this.Panel_Menu.Controls.Add(this.Btn_Customer);
            this.Panel_Menu.Controls.Add(this.Btn_Sell);
            this.Panel_Menu.Controls.Add(this.Btn_Purchase);
            this.Panel_Menu.Controls.Add(this.Btn_Home);
            this.Effect.SetDecoration(this.Panel_Menu, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Menu.Location = new System.Drawing.Point(0, 0);
            this.Panel_Menu.Name = "Panel_Menu";
            this.Panel_Menu.Size = new System.Drawing.Size(1280, 54);
            this.Panel_Menu.TabIndex = 0;
            // 
            // Select_Menu
            // 
            this.Select_Menu.BackColor = System.Drawing.Color.White;
            this.Effect.SetDecoration(this.Select_Menu, BunifuAnimatorNS.DecorationType.None);
            this.Select_Menu.Location = new System.Drawing.Point(12, 48);
            this.Select_Menu.Name = "Select_Menu";
            this.Select_Menu.Size = new System.Drawing.Size(92, 5);
            this.Select_Menu.TabIndex = 5;
            this.Select_Menu.Visible = false;
            // 
            // Btn_Order
            // 
            this.Btn_Order.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(23)))), ((int)(((byte)(38)))));
            this.Btn_Order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(23)))), ((int)(((byte)(38)))));
            this.Btn_Order.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Order.BorderRadius = 0;
            this.Btn_Order.ButtonText = "주문관리";
            this.Btn_Order.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Effect.SetDecoration(this.Btn_Order, BunifuAnimatorNS.DecorationType.None);
            this.Btn_Order.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Order.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btn_Order.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btn_Order.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Order.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_Order.Iconimage")));
            this.Btn_Order.Iconimage_right = null;
            this.Btn_Order.Iconimage_right_Selected = null;
            this.Btn_Order.Iconimage_Selected = null;
            this.Btn_Order.IconMarginLeft = 0;
            this.Btn_Order.IconMarginRight = 0;
            this.Btn_Order.IconRightVisible = true;
            this.Btn_Order.IconRightZoom = 0D;
            this.Btn_Order.IconVisible = true;
            this.Btn_Order.IconZoom = 75D;
            this.Btn_Order.IsTab = false;
            this.Btn_Order.Location = new System.Drawing.Point(497, 0);
            this.Btn_Order.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Order.Name = "Btn_Order";
            this.Btn_Order.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(23)))), ((int)(((byte)(38)))));
            this.Btn_Order.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(23)))), ((int)(((byte)(38)))));
            this.Btn_Order.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Order.selected = false;
            this.Btn_Order.Size = new System.Drawing.Size(153, 54);
            this.Btn_Order.TabIndex = 4;
            this.Btn_Order.Text = "주문관리";
            this.Btn_Order.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Order.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(134)))), ((int)(((byte)(163)))));
            this.Btn_Order.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Order.Click += new System.EventHandler(this.Btn_Order_Click);
            // 
            // Btn_Customer
            // 
            this.Btn_Customer.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(23)))), ((int)(((byte)(38)))));
            this.Btn_Customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(23)))), ((int)(((byte)(38)))));
            this.Btn_Customer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Customer.BorderRadius = 0;
            this.Btn_Customer.ButtonText = "회원관리";
            this.Btn_Customer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Effect.SetDecoration(this.Btn_Customer, BunifuAnimatorNS.DecorationType.None);
            this.Btn_Customer.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Customer.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btn_Customer.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btn_Customer.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Customer.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_Customer.Iconimage")));
            this.Btn_Customer.Iconimage_right = null;
            this.Btn_Customer.Iconimage_right_Selected = null;
            this.Btn_Customer.Iconimage_Selected = null;
            this.Btn_Customer.IconMarginLeft = 0;
            this.Btn_Customer.IconMarginRight = 0;
            this.Btn_Customer.IconRightVisible = true;
            this.Btn_Customer.IconRightZoom = 0D;
            this.Btn_Customer.IconVisible = true;
            this.Btn_Customer.IconZoom = 70D;
            this.Btn_Customer.IsTab = false;
            this.Btn_Customer.Location = new System.Drawing.Point(344, 0);
            this.Btn_Customer.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Customer.Name = "Btn_Customer";
            this.Btn_Customer.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(23)))), ((int)(((byte)(38)))));
            this.Btn_Customer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(23)))), ((int)(((byte)(38)))));
            this.Btn_Customer.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Customer.selected = false;
            this.Btn_Customer.Size = new System.Drawing.Size(153, 54);
            this.Btn_Customer.TabIndex = 3;
            this.Btn_Customer.Text = "회원관리";
            this.Btn_Customer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Customer.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(134)))), ((int)(((byte)(163)))));
            this.Btn_Customer.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Customer.Click += new System.EventHandler(this.Btn_Customer_Click);
            // 
            // Btn_Sell
            // 
            this.Btn_Sell.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(23)))), ((int)(((byte)(38)))));
            this.Btn_Sell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(23)))), ((int)(((byte)(38)))));
            this.Btn_Sell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Sell.BorderRadius = 0;
            this.Btn_Sell.ButtonText = "판매";
            this.Btn_Sell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Effect.SetDecoration(this.Btn_Sell, BunifuAnimatorNS.DecorationType.None);
            this.Btn_Sell.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Sell.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btn_Sell.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btn_Sell.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Sell.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_Sell.Iconimage")));
            this.Btn_Sell.Iconimage_right = null;
            this.Btn_Sell.Iconimage_right_Selected = null;
            this.Btn_Sell.Iconimage_Selected = null;
            this.Btn_Sell.IconMarginLeft = 0;
            this.Btn_Sell.IconMarginRight = 0;
            this.Btn_Sell.IconRightVisible = true;
            this.Btn_Sell.IconRightZoom = 0D;
            this.Btn_Sell.IconVisible = true;
            this.Btn_Sell.IconZoom = 60D;
            this.Btn_Sell.IsTab = false;
            this.Btn_Sell.Location = new System.Drawing.Point(232, 0);
            this.Btn_Sell.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Sell.Name = "Btn_Sell";
            this.Btn_Sell.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(23)))), ((int)(((byte)(38)))));
            this.Btn_Sell.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(23)))), ((int)(((byte)(38)))));
            this.Btn_Sell.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Sell.selected = false;
            this.Btn_Sell.Size = new System.Drawing.Size(112, 54);
            this.Btn_Sell.TabIndex = 2;
            this.Btn_Sell.Text = "판매";
            this.Btn_Sell.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Sell.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(134)))), ((int)(((byte)(163)))));
            this.Btn_Sell.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Sell.Click += new System.EventHandler(this.Btn_Sell_Click);
            // 
            // Btn_Purchase
            // 
            this.Btn_Purchase.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(23)))), ((int)(((byte)(38)))));
            this.Btn_Purchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(23)))), ((int)(((byte)(38)))));
            this.Btn_Purchase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Purchase.BorderRadius = 0;
            this.Btn_Purchase.ButtonText = "매입";
            this.Btn_Purchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Effect.SetDecoration(this.Btn_Purchase, BunifuAnimatorNS.DecorationType.None);
            this.Btn_Purchase.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Purchase.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btn_Purchase.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btn_Purchase.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Purchase.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_Purchase.Iconimage")));
            this.Btn_Purchase.Iconimage_right = null;
            this.Btn_Purchase.Iconimage_right_Selected = null;
            this.Btn_Purchase.Iconimage_Selected = null;
            this.Btn_Purchase.IconMarginLeft = 0;
            this.Btn_Purchase.IconMarginRight = 0;
            this.Btn_Purchase.IconRightVisible = true;
            this.Btn_Purchase.IconRightZoom = 0D;
            this.Btn_Purchase.IconVisible = true;
            this.Btn_Purchase.IconZoom = 60D;
            this.Btn_Purchase.IsTab = false;
            this.Btn_Purchase.Location = new System.Drawing.Point(120, 0);
            this.Btn_Purchase.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Purchase.Name = "Btn_Purchase";
            this.Btn_Purchase.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(23)))), ((int)(((byte)(38)))));
            this.Btn_Purchase.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(23)))), ((int)(((byte)(38)))));
            this.Btn_Purchase.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Purchase.selected = false;
            this.Btn_Purchase.Size = new System.Drawing.Size(112, 54);
            this.Btn_Purchase.TabIndex = 1;
            this.Btn_Purchase.Text = "매입";
            this.Btn_Purchase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Purchase.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(134)))), ((int)(((byte)(163)))));
            this.Btn_Purchase.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Purchase.Click += new System.EventHandler(this.Btn_Purchase_Click);
            // 
            // Btn_Home
            // 
            this.Btn_Home.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(23)))), ((int)(((byte)(38)))));
            this.Btn_Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(23)))), ((int)(((byte)(38)))));
            this.Btn_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Home.BorderRadius = 0;
            this.Btn_Home.ButtonText = "Home";
            this.Btn_Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Effect.SetDecoration(this.Btn_Home, BunifuAnimatorNS.DecorationType.None);
            this.Btn_Home.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Home.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btn_Home.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btn_Home.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Home.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_Home.Iconimage")));
            this.Btn_Home.Iconimage_right = null;
            this.Btn_Home.Iconimage_right_Selected = null;
            this.Btn_Home.Iconimage_Selected = null;
            this.Btn_Home.IconMarginLeft = 0;
            this.Btn_Home.IconMarginRight = 0;
            this.Btn_Home.IconRightVisible = true;
            this.Btn_Home.IconRightZoom = 0D;
            this.Btn_Home.IconVisible = true;
            this.Btn_Home.IconZoom = 50D;
            this.Btn_Home.IsTab = false;
            this.Btn_Home.Location = new System.Drawing.Point(0, 0);
            this.Btn_Home.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Home.Name = "Btn_Home";
            this.Btn_Home.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(23)))), ((int)(((byte)(38)))));
            this.Btn_Home.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(23)))), ((int)(((byte)(38)))));
            this.Btn_Home.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Home.selected = false;
            this.Btn_Home.Size = new System.Drawing.Size(120, 54);
            this.Btn_Home.TabIndex = 0;
            this.Btn_Home.Text = "Home";
            this.Btn_Home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Home.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(134)))), ((int)(((byte)(163)))));
            this.Btn_Home.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Home.Click += new System.EventHandler(this.Btn_Home_Click);
            // 
            // Effect
            // 
            this.Effect.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.Effect.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.Effect.DefaultAnimation = animation1;
            // 
            // orderPane1
            // 
            this.Effect.SetDecoration(this.orderPane1, BunifuAnimatorNS.DecorationType.None);
            this.orderPane1.Location = new System.Drawing.Point(40, 65);
            this.orderPane1.Name = "orderPane1";
            this.orderPane1.Size = new System.Drawing.Size(1200, 620);
            this.orderPane1.TabIndex = 5;
            this.orderPane1.Visible = false;
            // 
            // customerPane1
            // 
            this.Effect.SetDecoration(this.customerPane1, BunifuAnimatorNS.DecorationType.None);
            this.customerPane1.Location = new System.Drawing.Point(40, 65);
            this.customerPane1.Name = "customerPane1";
            this.customerPane1.Size = new System.Drawing.Size(1200, 620);
            this.customerPane1.TabIndex = 4;
            this.customerPane1.Visible = false;
            // 
            // sellPane1
            // 
            this.Effect.SetDecoration(this.sellPane1, BunifuAnimatorNS.DecorationType.None);
            this.sellPane1.Location = new System.Drawing.Point(40, 65);
            this.sellPane1.Name = "sellPane1";
            this.sellPane1.Size = new System.Drawing.Size(1200, 620);
            this.sellPane1.TabIndex = 3;
            this.sellPane1.Visible = false;
            // 
            // purchasePane1
            // 
            this.Effect.SetDecoration(this.purchasePane1, BunifuAnimatorNS.DecorationType.None);
            this.purchasePane1.Location = new System.Drawing.Point(40, 65);
            this.purchasePane1.Name = "purchasePane1";
            this.purchasePane1.Size = new System.Drawing.Size(1200, 620);
            this.purchasePane1.TabIndex = 2;
            this.purchasePane1.Visible = false;
            // 
            // mainPane1
            // 
            this.mainPane1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(31)))), ((int)(((byte)(48)))));
            this.Effect.SetDecoration(this.mainPane1, BunifuAnimatorNS.DecorationType.None);
            this.mainPane1.Location = new System.Drawing.Point(40, 64);
            this.mainPane1.Name = "mainPane1";
            this.mainPane1.Size = new System.Drawing.Size(1200, 620);
            this.mainPane1.TabIndex = 1;
            this.mainPane1.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.Panel_Background);
            this.Controls.Add(this.Panel_Title);
            this.Effect.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "도서 관리";
            this.Panel_Title.ResumeLayout(false);
            this.Panel_Title.PerformLayout();
            this.Panel_Background.ResumeLayout(false);
            this.Panel_Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Title;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Close;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Minimize;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Maximize;
        private System.Windows.Forms.Label Lbl_Clock;
        private System.Windows.Forms.Timer Timer_Clock;
        private System.Windows.Forms.Panel Panel_Background;
        private System.Windows.Forms.Panel Panel_Menu;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Home;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Order;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Customer;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Sell;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Purchase;
        private Panel.MainPane mainPane1;
        private BunifuAnimatorNS.BunifuTransition Effect;
        private System.Windows.Forms.Panel Select_Menu;
        private Panel.PurchasePane purchasePane1;
        private Panel.SellPane sellPane1;
        private Panel.CustomerPane customerPane1;
        private Panel.OrderPane orderPane1;
    }
}

