namespace panelMain
{
    partial class ToastMsg
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
            this.components = new System.ComponentModel.Container();
            this.ToastBorder = new System.Windows.Forms.Panel();
            this.pbToastImage = new System.Windows.Forms.PictureBox();
            this.lbLogLevel = new System.Windows.Forms.Label();
            this.lbMsg = new System.Windows.Forms.Label();
            this.timerHide = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbToastImage)).BeginInit();
            this.SuspendLayout();
            // 
            // ToastBorder
            // 
            this.ToastBorder.Dock = System.Windows.Forms.DockStyle.Left;
            this.ToastBorder.Location = new System.Drawing.Point(0, 0);
            this.ToastBorder.Name = "ToastBorder";
            this.ToastBorder.Size = new System.Drawing.Size(18, 60);
            this.ToastBorder.TabIndex = 0;
            // 
            // pbToastImage
            // 
            this.pbToastImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pbToastImage.Location = new System.Drawing.Point(24, 8);
            this.pbToastImage.Name = "pbToastImage";
            this.pbToastImage.Size = new System.Drawing.Size(40, 40);
            this.pbToastImage.TabIndex = 1;
            this.pbToastImage.TabStop = false;
            // 
            // lbLogLevel
            // 
            this.lbLogLevel.AutoSize = true;
            this.lbLogLevel.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogLevel.Location = new System.Drawing.Point(70, 8);
            this.lbLogLevel.Name = "lbLogLevel";
            this.lbLogLevel.Size = new System.Drawing.Size(58, 21);
            this.lbLogLevel.TabIndex = 2;
            this.lbLogLevel.Text = "label1";
            // 
            // lbMsg
            // 
            this.lbMsg.AutoSize = true;
            this.lbMsg.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMsg.Location = new System.Drawing.Point(72, 33);
            this.lbMsg.Name = "lbMsg";
            this.lbMsg.Size = new System.Drawing.Size(38, 15);
            this.lbMsg.TabIndex = 3;
            this.lbMsg.Text = "label2";
            // 
            // timerHide
            // 
            this.timerHide.Enabled = true;
            this.timerHide.Interval = 10;
            this.timerHide.Tick += new System.EventHandler(this.timerHide_Tick);
            // 
            // ToastMsg
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 60);
            this.Controls.Add(this.lbMsg);
            this.Controls.Add(this.lbLogLevel);
            this.Controls.Add(this.pbToastImage);
            this.Controls.Add(this.ToastBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ToastMsg";
            this.Text = "ToastMsg";
            this.Load += new System.EventHandler(this.ToastMsg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbToastImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ToastBorder;
        private System.Windows.Forms.PictureBox pbToastImage;
        private System.Windows.Forms.Label lbLogLevel;
        private System.Windows.Forms.Label lbMsg;
        private System.Windows.Forms.Timer timerHide;
    }
}