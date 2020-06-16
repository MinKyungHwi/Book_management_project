namespace proto.Panel
{
    partial class OrderPane
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderPane));
            this.RoundRect = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.bunifuCustomLabel18 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.order_book_amount_2 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel16 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.combo_order_book_category = new System.Windows.Forms.ComboBox();
            this.Btn_samebook_modify = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Btn_All_order_check = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_company_order_check = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_date_order_check = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel17 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel15 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Btn_book_order_cancle = new Bunifu.Framework.UI.BunifuFlatButton();
            this.order_store_name = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel14 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_store_delete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.store_name = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Btn_store_modify = new Bunifu.Framework.UI.BunifuFlatButton();
            this.text_store_addr = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Btn_store_add = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.text_store_tel = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.text_store_name = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.orderDataSet1 = new proto.orderDataSet1();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // RoundRect
            // 
            this.RoundRect.ElipseRadius = 100;
            this.RoundRect.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(67)))));
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 620);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(441, 392);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(709, 170);
            this.dataGridView2.TabIndex = 89;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(441, 246);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(709, 140);
            this.dataGridView1.TabIndex = 88;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bunifuCustomLabel5);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.bunifuCustomLabel17);
            this.groupBox3.Controls.Add(this.bunifuCustomLabel15);
            this.groupBox3.Controls.Add(this.dateTimePicker2);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.Btn_book_order_cancle);
            this.groupBox3.Controls.Add(this.order_store_name);
            this.groupBox3.Controls.Add(this.bunifuCustomLabel14);
            this.groupBox3.Controls.Add(this.bunifuCustomLabel7);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(441, 45);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox3.Size = new System.Drawing.Size(709, 195);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "주문";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.bunifuCustomLabel18);
            this.groupBox5.Controls.Add(this.order_book_amount_2);
            this.groupBox5.Controls.Add(this.bunifuCustomLabel16);
            this.groupBox5.Controls.Add(this.combo_order_book_category);
            this.groupBox5.Controls.Add(this.Btn_samebook_modify);
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(18, 94);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(306, 80);
            this.groupBox5.TabIndex = 49;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "동종 도서 주문량 일괄 변경";
            // 
            // bunifuCustomLabel18
            // 
            this.bunifuCustomLabel18.AutoSize = true;
            this.bunifuCustomLabel18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bunifuCustomLabel18.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.bunifuCustomLabel18.Location = new System.Drawing.Point(150, 22);
            this.bunifuCustomLabel18.Name = "bunifuCustomLabel18";
            this.bunifuCustomLabel18.Size = new System.Drawing.Size(31, 15);
            this.bunifuCustomLabel18.TabIndex = 89;
            this.bunifuCustomLabel18.Text = "수량";
            // 
            // order_book_amount_2
            // 
            this.order_book_amount_2.BorderColorFocused = System.Drawing.SystemColors.ScrollBar;
            this.order_book_amount_2.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.order_book_amount_2.BorderColorMouseHover = System.Drawing.SystemColors.ScrollBar;
            this.order_book_amount_2.BorderThickness = 3;
            this.order_book_amount_2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.order_book_amount_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.order_book_amount_2.ForeColor = System.Drawing.Color.White;
            this.order_book_amount_2.isPassword = false;
            this.order_book_amount_2.Location = new System.Drawing.Point(149, 36);
            this.order_book_amount_2.Margin = new System.Windows.Forms.Padding(4);
            this.order_book_amount_2.Name = "order_book_amount_2";
            this.order_book_amount_2.Size = new System.Drawing.Size(56, 30);
            this.order_book_amount_2.TabIndex = 88;
            this.order_book_amount_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel16
            // 
            this.bunifuCustomLabel16.AutoSize = true;
            this.bunifuCustomLabel16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bunifuCustomLabel16.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.bunifuCustomLabel16.Location = new System.Drawing.Point(11, 22);
            this.bunifuCustomLabel16.Name = "bunifuCustomLabel16";
            this.bunifuCustomLabel16.Size = new System.Drawing.Size(58, 15);
            this.bunifuCustomLabel16.TabIndex = 88;
            this.bunifuCustomLabel16.Text = "도서 종류";
            // 
            // combo_order_book_category
            // 
            this.combo_order_book_category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(67)))));
            this.combo_order_book_category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_order_book_category.ForeColor = System.Drawing.SystemColors.Window;
            this.combo_order_book_category.FormattingEnabled = true;
            this.combo_order_book_category.Location = new System.Drawing.Point(13, 40);
            this.combo_order_book_category.Name = "combo_order_book_category";
            this.combo_order_book_category.Size = new System.Drawing.Size(121, 23);
            this.combo_order_book_category.TabIndex = 25;
            // 
            // Btn_samebook_modify
            // 
            this.Btn_samebook_modify.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_samebook_modify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_samebook_modify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_samebook_modify.BorderRadius = 0;
            this.Btn_samebook_modify.ButtonText = "변경";
            this.Btn_samebook_modify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_samebook_modify.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_samebook_modify.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_samebook_modify.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_samebook_modify.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_samebook_modify.Iconimage")));
            this.Btn_samebook_modify.Iconimage_right = null;
            this.Btn_samebook_modify.Iconimage_right_Selected = null;
            this.Btn_samebook_modify.Iconimage_Selected = null;
            this.Btn_samebook_modify.IconMarginLeft = 0;
            this.Btn_samebook_modify.IconMarginRight = 0;
            this.Btn_samebook_modify.IconRightVisible = true;
            this.Btn_samebook_modify.IconRightZoom = 0D;
            this.Btn_samebook_modify.IconVisible = true;
            this.Btn_samebook_modify.IconZoom = 90D;
            this.Btn_samebook_modify.IsTab = false;
            this.Btn_samebook_modify.Location = new System.Drawing.Point(219, 30);
            this.Btn_samebook_modify.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Btn_samebook_modify.Name = "Btn_samebook_modify";
            this.Btn_samebook_modify.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_samebook_modify.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Btn_samebook_modify.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_samebook_modify.selected = false;
            this.Btn_samebook_modify.Size = new System.Drawing.Size(74, 36);
            this.Btn_samebook_modify.TabIndex = 88;
            this.Btn_samebook_modify.Text = "변경";
            this.Btn_samebook_modify.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_samebook_modify.Textcolor = System.Drawing.Color.White;
            this.Btn_samebook_modify.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_samebook_modify.Click += new System.EventHandler(this.Btn_samebook_modify_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Btn_All_order_check);
            this.groupBox4.Controls.Add(this.Btn_company_order_check);
            this.groupBox4.Controls.Add(this.Btn_date_order_check);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(330, 94);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(346, 80);
            this.groupBox4.TabIndex = 47;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "조회";
            // 
            // Btn_All_order_check
            // 
            this.Btn_All_order_check.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_All_order_check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_All_order_check.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_All_order_check.BorderRadius = 0;
            this.Btn_All_order_check.ButtonText = "전체 조회";
            this.Btn_All_order_check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_All_order_check.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_All_order_check.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_All_order_check.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_All_order_check.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_All_order_check.Iconimage")));
            this.Btn_All_order_check.Iconimage_right = null;
            this.Btn_All_order_check.Iconimage_right_Selected = null;
            this.Btn_All_order_check.Iconimage_Selected = null;
            this.Btn_All_order_check.IconMarginLeft = 0;
            this.Btn_All_order_check.IconMarginRight = 0;
            this.Btn_All_order_check.IconRightVisible = true;
            this.Btn_All_order_check.IconRightZoom = 0D;
            this.Btn_All_order_check.IconVisible = true;
            this.Btn_All_order_check.IconZoom = 90D;
            this.Btn_All_order_check.IsTab = false;
            this.Btn_All_order_check.Location = new System.Drawing.Point(237, 30);
            this.Btn_All_order_check.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Btn_All_order_check.Name = "Btn_All_order_check";
            this.Btn_All_order_check.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_All_order_check.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Btn_All_order_check.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_All_order_check.selected = false;
            this.Btn_All_order_check.Size = new System.Drawing.Size(103, 36);
            this.Btn_All_order_check.TabIndex = 43;
            this.Btn_All_order_check.Text = "전체 조회";
            this.Btn_All_order_check.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_All_order_check.Textcolor = System.Drawing.Color.White;
            this.Btn_All_order_check.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_All_order_check.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // Btn_company_order_check
            // 
            this.Btn_company_order_check.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_company_order_check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_company_order_check.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_company_order_check.BorderRadius = 0;
            this.Btn_company_order_check.ButtonText = "매입처별 조회";
            this.Btn_company_order_check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_company_order_check.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_company_order_check.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_company_order_check.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_company_order_check.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_company_order_check.Iconimage")));
            this.Btn_company_order_check.Iconimage_right = null;
            this.Btn_company_order_check.Iconimage_right_Selected = null;
            this.Btn_company_order_check.Iconimage_Selected = null;
            this.Btn_company_order_check.IconMarginLeft = 0;
            this.Btn_company_order_check.IconMarginRight = 0;
            this.Btn_company_order_check.IconRightVisible = true;
            this.Btn_company_order_check.IconRightZoom = 0D;
            this.Btn_company_order_check.IconVisible = true;
            this.Btn_company_order_check.IconZoom = 90D;
            this.Btn_company_order_check.IsTab = false;
            this.Btn_company_order_check.Location = new System.Drawing.Point(115, 30);
            this.Btn_company_order_check.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.Btn_company_order_check.Name = "Btn_company_order_check";
            this.Btn_company_order_check.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_company_order_check.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Btn_company_order_check.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_company_order_check.selected = false;
            this.Btn_company_order_check.Size = new System.Drawing.Size(117, 36);
            this.Btn_company_order_check.TabIndex = 46;
            this.Btn_company_order_check.Text = "매입처별 조회";
            this.Btn_company_order_check.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_company_order_check.Textcolor = System.Drawing.Color.White;
            this.Btn_company_order_check.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_company_order_check.Click += new System.EventHandler(this.Btn_company_order_check_Click);
            // 
            // Btn_date_order_check
            // 
            this.Btn_date_order_check.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_date_order_check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_date_order_check.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_date_order_check.BorderRadius = 0;
            this.Btn_date_order_check.ButtonText = "날짜별 조회";
            this.Btn_date_order_check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_date_order_check.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_date_order_check.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_date_order_check.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_date_order_check.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_date_order_check.Iconimage")));
            this.Btn_date_order_check.Iconimage_right = null;
            this.Btn_date_order_check.Iconimage_right_Selected = null;
            this.Btn_date_order_check.Iconimage_Selected = null;
            this.Btn_date_order_check.IconMarginLeft = 0;
            this.Btn_date_order_check.IconMarginRight = 0;
            this.Btn_date_order_check.IconRightVisible = true;
            this.Btn_date_order_check.IconRightZoom = 0D;
            this.Btn_date_order_check.IconVisible = true;
            this.Btn_date_order_check.IconZoom = 90D;
            this.Btn_date_order_check.IsTab = false;
            this.Btn_date_order_check.Location = new System.Drawing.Point(7, 30);
            this.Btn_date_order_check.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.Btn_date_order_check.Name = "Btn_date_order_check";
            this.Btn_date_order_check.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_date_order_check.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Btn_date_order_check.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_date_order_check.selected = false;
            this.Btn_date_order_check.Size = new System.Drawing.Size(103, 36);
            this.Btn_date_order_check.TabIndex = 48;
            this.Btn_date_order_check.Text = "날짜별 조회";
            this.Btn_date_order_check.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_date_order_check.Textcolor = System.Drawing.Color.White;
            this.Btn_date_order_check.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_date_order_check.Click += new System.EventHandler(this.Btn_date_order_check_Click);
            // 
            // bunifuCustomLabel17
            // 
            this.bunifuCustomLabel17.AutoSize = true;
            this.bunifuCustomLabel17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel17.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.bunifuCustomLabel17.Location = new System.Drawing.Point(328, 46);
            this.bunifuCustomLabel17.Name = "bunifuCustomLabel17";
            this.bunifuCustomLabel17.Size = new System.Drawing.Size(18, 20);
            this.bunifuCustomLabel17.TabIndex = 87;
            this.bunifuCustomLabel17.Text = "~";
            // 
            // bunifuCustomLabel15
            // 
            this.bunifuCustomLabel15.AutoSize = true;
            this.bunifuCustomLabel15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bunifuCustomLabel15.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.bunifuCustomLabel15.Location = new System.Drawing.Point(347, 23);
            this.bunifuCustomLabel15.Name = "bunifuCustomLabel15";
            this.bunifuCustomLabel15.Size = new System.Drawing.Size(126, 15);
            this.bunifuCustomLabel15.TabIndex = 86;
            this.bunifuCustomLabel15.Text = "( 날짜별 조회 시 사용 )";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(67)))));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(350, 42);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(142, 21);
            this.dateTimePicker2.TabIndex = 85;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(67)))));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(182, 42);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(142, 21);
            this.dateTimePicker1.TabIndex = 84;
            // 
            // Btn_book_order_cancle
            // 
            this.Btn_book_order_cancle.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_book_order_cancle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_book_order_cancle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_book_order_cancle.BorderRadius = 0;
            this.Btn_book_order_cancle.ButtonText = "주문 취소";
            this.Btn_book_order_cancle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_book_order_cancle.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_book_order_cancle.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_book_order_cancle.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_book_order_cancle.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_book_order_cancle.Iconimage")));
            this.Btn_book_order_cancle.Iconimage_right = null;
            this.Btn_book_order_cancle.Iconimage_right_Selected = null;
            this.Btn_book_order_cancle.Iconimage_Selected = null;
            this.Btn_book_order_cancle.IconMarginLeft = 0;
            this.Btn_book_order_cancle.IconMarginRight = 0;
            this.Btn_book_order_cancle.IconRightVisible = true;
            this.Btn_book_order_cancle.IconRightZoom = 0D;
            this.Btn_book_order_cancle.IconVisible = true;
            this.Btn_book_order_cancle.IconZoom = 90D;
            this.Btn_book_order_cancle.IsTab = false;
            this.Btn_book_order_cancle.Location = new System.Drawing.Point(528, 65);
            this.Btn_book_order_cancle.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Btn_book_order_cancle.Name = "Btn_book_order_cancle";
            this.Btn_book_order_cancle.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_book_order_cancle.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Btn_book_order_cancle.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_book_order_cancle.selected = false;
            this.Btn_book_order_cancle.Size = new System.Drawing.Size(148, 31);
            this.Btn_book_order_cancle.TabIndex = 74;
            this.Btn_book_order_cancle.Text = "주문 취소";
            this.Btn_book_order_cancle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_book_order_cancle.Textcolor = System.Drawing.Color.White;
            this.Btn_book_order_cancle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_book_order_cancle.Click += new System.EventHandler(this.Btn_book_order_cancle_Click_1);
            // 
            // order_store_name
            // 
            this.order_store_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(67)))));
            this.order_store_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.order_store_name.ForeColor = System.Drawing.SystemColors.Window;
            this.order_store_name.FormattingEnabled = true;
            this.order_store_name.Location = new System.Drawing.Point(18, 40);
            this.order_store_name.Name = "order_store_name";
            this.order_store_name.Size = new System.Drawing.Size(156, 23);
            this.order_store_name.TabIndex = 75;
            // 
            // bunifuCustomLabel14
            // 
            this.bunifuCustomLabel14.AutoSize = true;
            this.bunifuCustomLabel14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bunifuCustomLabel14.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.bunifuCustomLabel14.Location = new System.Drawing.Point(179, 23);
            this.bunifuCustomLabel14.Name = "bunifuCustomLabel14";
            this.bunifuCustomLabel14.Size = new System.Drawing.Size(33, 15);
            this.bunifuCustomLabel14.TabIndex = 83;
            this.bunifuCustomLabel14.Text = "Date";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(15, 24);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(31, 15);
            this.bunifuCustomLabel7.TabIndex = 77;
            this.bunifuCustomLabel7.Text = "사명";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_store_delete);
            this.groupBox1.Controls.Add(this.store_name);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel4);
            this.groupBox1.Controls.Add(this.Btn_store_modify);
            this.groupBox1.Controls.Add(this.text_store_addr);
            this.groupBox1.Controls.Add(this.Btn_store_add);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel3);
            this.groupBox1.Controls.Add(this.text_store_tel);
            this.groupBox1.Controls.Add(this.text_store_name);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel2);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(37, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 313);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "매입처 등록/수정";
            // 
            // Btn_store_delete
            // 
            this.Btn_store_delete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_store_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_store_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_store_delete.BorderRadius = 0;
            this.Btn_store_delete.ButtonText = "삭제";
            this.Btn_store_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_store_delete.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_store_delete.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_store_delete.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_store_delete.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_store_delete.Iconimage")));
            this.Btn_store_delete.Iconimage_right = null;
            this.Btn_store_delete.Iconimage_right_Selected = null;
            this.Btn_store_delete.Iconimage_Selected = null;
            this.Btn_store_delete.IconMarginLeft = 0;
            this.Btn_store_delete.IconMarginRight = 0;
            this.Btn_store_delete.IconRightVisible = true;
            this.Btn_store_delete.IconRightZoom = 0D;
            this.Btn_store_delete.IconVisible = true;
            this.Btn_store_delete.IconZoom = 90D;
            this.Btn_store_delete.IsTab = false;
            this.Btn_store_delete.Location = new System.Drawing.Point(11, 259);
            this.Btn_store_delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_store_delete.Name = "Btn_store_delete";
            this.Btn_store_delete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_store_delete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Btn_store_delete.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_store_delete.selected = false;
            this.Btn_store_delete.Size = new System.Drawing.Size(157, 30);
            this.Btn_store_delete.TabIndex = 24;
            this.Btn_store_delete.Text = "삭제";
            this.Btn_store_delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_store_delete.Textcolor = System.Drawing.Color.White;
            this.Btn_store_delete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_store_delete.Click += new System.EventHandler(this.Btn_store_delete_Click);
            // 
            // store_name
            // 
            this.store_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(67)))));
            this.store_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.store_name.ForeColor = System.Drawing.SystemColors.Window;
            this.store_name.FormattingEnabled = true;
            this.store_name.Location = new System.Drawing.Point(11, 172);
            this.store_name.Name = "store_name";
            this.store_name.Size = new System.Drawing.Size(121, 23);
            this.store_name.TabIndex = 23;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(8, 153);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(115, 15);
            this.bunifuCustomLabel4.TabIndex = 22;
            this.bunifuCustomLabel4.Text = "Name(수정 시 사용)";
            // 
            // Btn_store_modify
            // 
            this.Btn_store_modify.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_store_modify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_store_modify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_store_modify.BorderRadius = 0;
            this.Btn_store_modify.ButtonText = "수정";
            this.Btn_store_modify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_store_modify.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_store_modify.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_store_modify.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_store_modify.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_store_modify.Iconimage")));
            this.Btn_store_modify.Iconimage_right = null;
            this.Btn_store_modify.Iconimage_right_Selected = null;
            this.Btn_store_modify.Iconimage_Selected = null;
            this.Btn_store_modify.IconMarginLeft = 0;
            this.Btn_store_modify.IconMarginRight = 0;
            this.Btn_store_modify.IconRightVisible = true;
            this.Btn_store_modify.IconRightZoom = 0D;
            this.Btn_store_modify.IconVisible = true;
            this.Btn_store_modify.IconZoom = 90D;
            this.Btn_store_modify.IsTab = false;
            this.Btn_store_modify.Location = new System.Drawing.Point(174, 220);
            this.Btn_store_modify.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_store_modify.Name = "Btn_store_modify";
            this.Btn_store_modify.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_store_modify.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Btn_store_modify.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_store_modify.selected = false;
            this.Btn_store_modify.Size = new System.Drawing.Size(157, 30);
            this.Btn_store_modify.TabIndex = 21;
            this.Btn_store_modify.Text = "수정";
            this.Btn_store_modify.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_store_modify.Textcolor = System.Drawing.Color.White;
            this.Btn_store_modify.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_store_modify.Click += new System.EventHandler(this.Btn_store_modify_Click);
            // 
            // text_store_addr
            // 
            this.text_store_addr.BorderColorFocused = System.Drawing.SystemColors.ScrollBar;
            this.text_store_addr.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.text_store_addr.BorderColorMouseHover = System.Drawing.SystemColors.ScrollBar;
            this.text_store_addr.BorderThickness = 3;
            this.text_store_addr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_store_addr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.text_store_addr.ForeColor = System.Drawing.Color.White;
            this.text_store_addr.isPassword = false;
            this.text_store_addr.Location = new System.Drawing.Point(9, 102);
            this.text_store_addr.Margin = new System.Windows.Forms.Padding(4);
            this.text_store_addr.Name = "text_store_addr";
            this.text_store_addr.Size = new System.Drawing.Size(335, 30);
            this.text_store_addr.TabIndex = 20;
            this.text_store_addr.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Btn_store_add
            // 
            this.Btn_store_add.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_store_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_store_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_store_add.BorderRadius = 0;
            this.Btn_store_add.ButtonText = "등록";
            this.Btn_store_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_store_add.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_store_add.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_store_add.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_store_add.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_store_add.Iconimage")));
            this.Btn_store_add.Iconimage_right = null;
            this.Btn_store_add.Iconimage_right_Selected = null;
            this.Btn_store_add.Iconimage_Selected = null;
            this.Btn_store_add.IconMarginLeft = 0;
            this.Btn_store_add.IconMarginRight = 0;
            this.Btn_store_add.IconRightVisible = true;
            this.Btn_store_add.IconRightZoom = 0D;
            this.Btn_store_add.IconVisible = true;
            this.Btn_store_add.IconZoom = 90D;
            this.Btn_store_add.IsTab = false;
            this.Btn_store_add.Location = new System.Drawing.Point(11, 220);
            this.Btn_store_add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_store_add.Name = "Btn_store_add";
            this.Btn_store_add.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_store_add.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Btn_store_add.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_store_add.selected = false;
            this.Btn_store_add.Size = new System.Drawing.Size(157, 30);
            this.Btn_store_add.TabIndex = 14;
            this.Btn_store_add.Text = "등록";
            this.Btn_store_add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_store_add.Textcolor = System.Drawing.Color.White;
            this.Btn_store_add.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_store_add.Click += new System.EventHandler(this.Btn_store_add_Click);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(182, 25);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(138, 15);
            this.bunifuCustomLabel3.TabIndex = 19;
            this.bunifuCustomLabel3.Text = "Tel. (\'-\' 없이 입력하세요)";
            // 
            // text_store_tel
            // 
            this.text_store_tel.BorderColorFocused = System.Drawing.SystemColors.ScrollBar;
            this.text_store_tel.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.text_store_tel.BorderColorMouseHover = System.Drawing.SystemColors.ScrollBar;
            this.text_store_tel.BorderThickness = 3;
            this.text_store_tel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_store_tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.text_store_tel.ForeColor = System.Drawing.Color.White;
            this.text_store_tel.isPassword = false;
            this.text_store_tel.Location = new System.Drawing.Point(185, 40);
            this.text_store_tel.Margin = new System.Windows.Forms.Padding(4);
            this.text_store_tel.Name = "text_store_tel";
            this.text_store_tel.Size = new System.Drawing.Size(159, 30);
            this.text_store_tel.TabIndex = 18;
            this.text_store_tel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // text_store_name
            // 
            this.text_store_name.BorderColorFocused = System.Drawing.SystemColors.ScrollBar;
            this.text_store_name.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.text_store_name.BorderColorMouseHover = System.Drawing.SystemColors.ScrollBar;
            this.text_store_name.BorderThickness = 3;
            this.text_store_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_store_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.text_store_name.ForeColor = System.Drawing.Color.White;
            this.text_store_name.isPassword = false;
            this.text_store_name.Location = new System.Drawing.Point(7, 40);
            this.text_store_name.Margin = new System.Windows.Forms.Padding(4);
            this.text_store_name.Name = "text_store_name";
            this.text_store_name.Size = new System.Drawing.Size(159, 30);
            this.text_store_name.TabIndex = 17;
            this.text_store_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(8, 88);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(31, 15);
            this.bunifuCustomLabel2.TabIndex = 16;
            this.bunifuCustomLabel2.Text = "주소";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(6, 25);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(31, 15);
            this.bunifuCustomLabel1.TabIndex = 15;
            this.bunifuCustomLabel1.Text = "사명";
            // 
            // orderDataSet1
            // 
            this.orderDataSet1.DataSetName = "orderDataSet1";
            this.orderDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(67)))));
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(528, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 23);
            this.comboBox1.TabIndex = 88;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(525, 16);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(73, 15);
            this.bunifuCustomLabel5.TabIndex = 89;
            this.bunifuCustomLabel5.Text = "취소 도서 명";
            // 
            // OrderPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "OrderPane";
            this.Size = new System.Drawing.Size(1200, 620);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse RoundRect;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_store_modify;
        private Bunifu.Framework.UI.BunifuMetroTextbox text_store_addr;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_store_add;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMetroTextbox text_store_tel;
        private Bunifu.Framework.UI.BunifuMetroTextbox text_store_name;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox store_name;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_store_delete;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_All_order_check;
        private orderDataSet1 orderDataSet1;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_company_order_check;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_date_order_check;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel15;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_book_order_cancle;
        private System.Windows.Forms.ComboBox order_store_name;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel14;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel17;
        private System.Windows.Forms.GroupBox groupBox5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel16;
        private System.Windows.Forms.ComboBox combo_order_book_category;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_samebook_modify;
        private System.Windows.Forms.GroupBox groupBox4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel18;
        private Bunifu.Framework.UI.BunifuMetroTextbox order_book_amount_2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox comboBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
    }
}
