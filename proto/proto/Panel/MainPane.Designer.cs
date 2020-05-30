namespace proto.Panel
{
    partial class MainPane
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
            this.RoundRectPane = new System.Windows.Forms.Panel();
            this.RoundRect = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SuspendLayout();
            // 
            // RoundRectPane
            // 
            this.RoundRectPane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(67)))));
            this.RoundRectPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoundRectPane.Location = new System.Drawing.Point(0, 0);
            this.RoundRectPane.Name = "RoundRectPane";
            this.RoundRectPane.Size = new System.Drawing.Size(1200, 620);
            this.RoundRectPane.TabIndex = 0;
            // 
            // RoundRect
            // 
            this.RoundRect.ElipseRadius = 100;
            this.RoundRect.TargetControl = this;
            // 
            // MainPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(31)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.RoundRectPane);
            this.Name = "MainPane";
            this.Size = new System.Drawing.Size(1200, 620);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel RoundRectPane;
        private Bunifu.Framework.UI.BunifuElipse RoundRect;
    }
}
