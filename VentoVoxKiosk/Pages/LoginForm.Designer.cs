namespace VentoVoxKiosk.Pages
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.kybGradationRow1 = new KYBController.KYBGradationRow();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPWVerification = new System.Windows.Forms.TextBox();
            this.tbIDVerification = new System.Windows.Forms.TextBox();
            this.btnLoginShow = new MyUserControl.KYBButton();
            this.btnClose = new MyUserControl.KYBButton();
            this.btnQRCheck = new MyUserControl.KYBButton();
            this.kybGradationRow1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kybGradationRow1
            // 
            this.kybGradationRow1.BorderRadius = 0;
            this.kybGradationRow1.ColorEnd = System.Drawing.Color.Lavender;
            this.kybGradationRow1.ColorInit = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.kybGradationRow1.Controls.Add(this.tableLayoutPanel1);
            this.kybGradationRow1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kybGradationRow1.GradientAngle = 60F;
            this.kybGradationRow1.Location = new System.Drawing.Point(0, 0);
            this.kybGradationRow1.Name = "kybGradationRow1";
            this.kybGradationRow1.Size = new System.Drawing.Size(800, 450);
            this.kybGradationRow1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Controls.Add(this.btnQRCheck, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbPWVerification, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.tbIDVerification, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnLoginShow, 6, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnClose, 7, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 4);
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label1.Location = new System.Drawing.Point(103, 56);
            this.label1.Name = "label1";
            this.tableLayoutPanel1.SetRowSpan(this.label1, 3);
            this.label1.Size = new System.Drawing.Size(241, 100);
            this.label1.TabIndex = 20;
            this.label1.Text = "Welcome to VentoVox";
            // 
            // tbPWVerification
            // 
            this.tbPWVerification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.tbPWVerification, 2);
            this.tbPWVerification.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbPWVerification.Location = new System.Drawing.Point(403, 292);
            this.tbPWVerification.Name = "tbPWVerification";
            this.tbPWVerification.Size = new System.Drawing.Size(194, 32);
            this.tbPWVerification.TabIndex = 22;
            this.tbPWVerification.Text = "1234";
            // 
            // tbIDVerification
            // 
            this.tbIDVerification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.tbIDVerification, 2);
            this.tbIDVerification.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbIDVerification.Location = new System.Drawing.Point(403, 236);
            this.tbIDVerification.Name = "tbIDVerification";
            this.tbIDVerification.Size = new System.Drawing.Size(194, 32);
            this.tbIDVerification.TabIndex = 21;
            this.tbIDVerification.Text = "yubi2023";
            // 
            // btnLoginShow
            // 
            this.btnLoginShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoginShow.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLoginShow.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btnLoginShow.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLoginShow.BorderRadius = 10;
            this.btnLoginShow.BorderSize = 0;
            this.btnLoginShow.FlatAppearance.BorderSize = 0;
            this.btnLoginShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginShow.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnLoginShow.ForeColor = System.Drawing.Color.White;
            this.btnLoginShow.Location = new System.Drawing.Point(603, 237);
            this.btnLoginShow.Name = "btnLoginShow";
            this.btnLoginShow.Size = new System.Drawing.Size(94, 30);
            this.btnLoginShow.TabIndex = 32;
            this.btnLoginShow.Text = "Login";
            this.btnLoginShow.TextColor = System.Drawing.Color.White;
            this.btnLoginShow.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnClose.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btnClose.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnClose.BorderRadius = 10;
            this.btnClose.BorderSize = 0;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(703, 406);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 30);
            this.btnClose.TabIndex = 33;
            this.btnClose.Text = "Close";
            this.btnClose.TextColor = System.Drawing.Color.White;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnQRCheck
            // 
            this.btnQRCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQRCheck.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnQRCheck.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btnQRCheck.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnQRCheck.BorderRadius = 10;
            this.btnQRCheck.BorderSize = 0;
            this.btnQRCheck.FlatAppearance.BorderSize = 0;
            this.btnQRCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQRCheck.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnQRCheck.ForeColor = System.Drawing.Color.White;
            this.btnQRCheck.Location = new System.Drawing.Point(3, 406);
            this.btnQRCheck.Name = "btnQRCheck";
            this.btnQRCheck.Size = new System.Drawing.Size(94, 30);
            this.btnQRCheck.TabIndex = 34;
            this.btnQRCheck.Text = "QR";
            this.btnQRCheck.TextColor = System.Drawing.Color.White;
            this.btnQRCheck.UseVisualStyleBackColor = false;
            this.btnQRCheck.Click += new System.EventHandler(this.btnQRCheck_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kybGradationRow1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.kybGradationRow1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private KYBController.KYBGradationRow kybGradationRow1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPWVerification;
        private System.Windows.Forms.TextBox tbIDVerification;
        private MyUserControl.KYBButton btnLoginShow;
        private MyUserControl.KYBButton btnClose;
        private MyUserControl.KYBButton btnQRCheck;
    }
}