namespace VentoVox
{

    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.timerMenuExpand = new System.Windows.Forms.Timer(this.components);
            this.menuTimer = new System.Windows.Forms.Timer(this.components);
            this.PanelTop = new KYBController.KYBGradationRow();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuContainer = new KYBController.KYBGradationRow();
            this.menuPage1 = new System.Windows.Forms.Label();
            this.menuPage3 = new System.Windows.Forms.Label();
            this.menuPage4 = new System.Windows.Forms.Label();
            this.menuPage2 = new System.Windows.Forms.Label();
            this.PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Animated Menu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timerMenuExpand
            // 
            this.timerMenuExpand.Interval = 5;
            this.timerMenuExpand.Tick += new System.EventHandler(this.timerMenuExpand_Tick);
            // 
            // menuTimer
            // 
            this.menuTimer.Interval = 10;
            this.menuTimer.Tick += new System.EventHandler(this.menuTimer_Tick);
            // 
            // PanelTop
            // 
            this.PanelTop.BorderRadius = 0;
            this.PanelTop.ColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.PanelTop.ColorInit = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.PanelTop.Controls.Add(this.pictureBox1);
            this.PanelTop.Controls.Add(this.label1);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.GradientAngle = 30F;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(1784, 50);
            this.PanelTop.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // menuContainer
            // 
            this.menuContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuContainer.BorderRadius = 0;
            this.menuContainer.ColorEnd = System.Drawing.Color.Lavender;
            this.menuContainer.ColorInit = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.menuContainer.Controls.Add(this.menuPage1);
            this.menuContainer.Controls.Add(this.menuPage3);
            this.menuContainer.Controls.Add(this.menuPage4);
            this.menuContainer.Controls.Add(this.menuPage2);
            this.menuContainer.GradientAngle = 30F;
            this.menuContainer.Location = new System.Drawing.Point(0, 50);
            this.menuContainer.Name = "menuContainer";
            this.menuContainer.Size = new System.Drawing.Size(1784, 10);
            this.menuContainer.TabIndex = 9;
            // 
            // menuPage1
            // 
            this.menuPage1.BackColor = System.Drawing.Color.Transparent;
            this.menuPage1.ForeColor = System.Drawing.Color.White;
            this.menuPage1.Image = ((System.Drawing.Image)(resources.GetObject("menuPage1.Image")));
            this.menuPage1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menuPage1.Location = new System.Drawing.Point(12, 3);
            this.menuPage1.Name = "menuPage1";
            this.menuPage1.Size = new System.Drawing.Size(80, 65);
            this.menuPage1.TabIndex = 2;
            this.menuPage1.Text = "Home";
            this.menuPage1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.menuPage1.Click += new System.EventHandler(this.menuPage1_Click);
            // 
            // menuPage3
            // 
            this.menuPage3.BackColor = System.Drawing.Color.Transparent;
            this.menuPage3.ForeColor = System.Drawing.Color.White;
            this.menuPage3.Image = ((System.Drawing.Image)(resources.GetObject("menuPage3.Image")));
            this.menuPage3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menuPage3.Location = new System.Drawing.Point(184, 3);
            this.menuPage3.Name = "menuPage3";
            this.menuPage3.Size = new System.Drawing.Size(80, 65);
            this.menuPage3.TabIndex = 4;
            this.menuPage3.Text = "Check Out";
            this.menuPage3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.menuPage3.Click += new System.EventHandler(this.menuPage3_Click);
            // 
            // menuPage4
            // 
            this.menuPage4.BackColor = System.Drawing.Color.Transparent;
            this.menuPage4.ForeColor = System.Drawing.Color.White;
            this.menuPage4.Image = ((System.Drawing.Image)(resources.GetObject("menuPage4.Image")));
            this.menuPage4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menuPage4.Location = new System.Drawing.Point(270, 3);
            this.menuPage4.Name = "menuPage4";
            this.menuPage4.Size = new System.Drawing.Size(80, 65);
            this.menuPage4.TabIndex = 5;
            this.menuPage4.Text = "Tips";
            this.menuPage4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.menuPage4.Click += new System.EventHandler(this.menuPage4_Click);
            // 
            // menuPage2
            // 
            this.menuPage2.BackColor = System.Drawing.Color.Transparent;
            this.menuPage2.ForeColor = System.Drawing.Color.White;
            this.menuPage2.Image = ((System.Drawing.Image)(resources.GetObject("menuPage2.Image")));
            this.menuPage2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menuPage2.Location = new System.Drawing.Point(98, 3);
            this.menuPage2.Name = "menuPage2";
            this.menuPage2.Size = new System.Drawing.Size(80, 65);
            this.menuPage2.TabIndex = 3;
            this.menuPage2.Text = "Menu";
            this.menuPage2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.menuPage2.Click += new System.EventHandler(this.menuPage2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1784, 961);
            this.Controls.Add(this.menuContainer);
            this.Controls.Add(this.PanelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label menuPage4;
        private System.Windows.Forms.Label menuPage3;
        private System.Windows.Forms.Label menuPage2;
        private System.Windows.Forms.Label menuPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timerMenuExpand;
        private System.Windows.Forms.Timer menuTimer;
        private KYBController.KYBGradationRow PanelTop;
        private KYBController.KYBGradationRow menuContainer;
    }
}

