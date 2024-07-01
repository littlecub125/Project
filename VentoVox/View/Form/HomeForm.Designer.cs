namespace VentoVox.View
{

    public class TableLayoutPanel : System.Windows.Forms.TableLayoutPanel
    {
        public TableLayoutPanel()
        {
            base.DoubleBuffered = true;
        }
    }
    partial class HomeForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLogOff = new MaterialSkin.Controls.MaterialButton();
            this.panelVideo2 = new KYBController.KYBGradationRow();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.picProfile = new System.Windows.Forms.PictureBox();
            this.tbIDInput = new MaterialSkin.Controls.MaterialTextBox();
            this.btnLogin = new MaterialSkin.Controls.MaterialButton();
            this.panelPersonalInfo1 = new KYBController.KYBGradationRow();
            this.lbHistory = new System.Windows.Forms.Label();
            this.panelPersonalInfo2 = new KYBController.KYBGradationRow();
            this.lbFoodTicketNum = new System.Windows.Forms.Label();
            this.panelPersonalInfo3 = new KYBController.KYBGradationRow();
            this.lbCalories = new System.Windows.Forms.Label();
            this.panelVideo1 = new KYBController.KYBGradationRow();
            this.btnStartOrder = new MaterialSkin.Controls.MaterialButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            this.panelPersonalInfo1.SuspendLayout();
            this.panelPersonalInfo2.SuspendLayout();
            this.panelPersonalInfo3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.493274F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.46188F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.btnLogOff, 8, 5);
            this.tableLayoutPanel1.Controls.Add(this.panelVideo2, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel2, 8, 1);
            this.tableLayoutPanel1.Controls.Add(this.picProfile, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbIDInput, 7, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnLogin, 8, 4);
            this.tableLayoutPanel1.Controls.Add(this.panelPersonalInfo1, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelPersonalInfo2, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.panelPersonalInfo3, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.panelVideo1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnStartOrder, 8, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 13;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.079826F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.7881F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.20755F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.173077F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.01282F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.33672F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.93324F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.54717F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1784, 689);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // btnLogOff
            // 
            this.btnLogOff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogOff.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogOff.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLogOff.Depth = 0;
            this.btnLogOff.HighEmphasis = true;
            this.btnLogOff.Icon = null;
            this.btnLogOff.Location = new System.Drawing.Point(1428, 321);
            this.btnLogOff.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogOff.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogOff.Name = "btnLogOff";
            this.btnLogOff.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLogOff.Size = new System.Drawing.Size(170, 36);
            this.btnLogOff.TabIndex = 23;
            this.btnLogOff.Text = "Log Off";
            this.btnLogOff.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLogOff.UseAccentColor = false;
            this.btnLogOff.UseVisualStyleBackColor = true;
            this.btnLogOff.Click += new System.EventHandler(this.btnLogOff_Click);
            // 
            // panelVideo2
            // 
            this.panelVideo2.BorderRadius = 20;
            this.panelVideo2.ColorEnd = System.Drawing.Color.Lavender;
            this.panelVideo2.ColorInit = System.Drawing.Color.SkyBlue;
            this.tableLayoutPanel1.SetColumnSpan(this.panelVideo2, 3);
            this.panelVideo2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelVideo2.GradientAngle = 30F;
            this.panelVideo2.Location = new System.Drawing.Point(101, 318);
            this.panelVideo2.Name = "panelVideo2";
            this.tableLayoutPanel1.SetRowSpan(this.panelVideo2, 3);
            this.panelVideo2.Size = new System.Drawing.Size(608, 208);
            this.panelVideo2.TabIndex = 21;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(3, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(43, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Home";
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(1427, 32);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(73, 86);
            this.materialLabel2.TabIndex = 11;
            this.materialLabel2.Text = "Login Info";
            // 
            // picProfile
            // 
            this.picProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picProfile.Image = global::VentoVox.Properties.Resources.profile;
            this.picProfile.Location = new System.Drawing.Point(1249, 35);
            this.picProfile.Name = "picProfile";
            this.tableLayoutPanel1.SetRowSpan(this.picProfile, 3);
            this.picProfile.Size = new System.Drawing.Size(172, 226);
            this.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProfile.TabIndex = 12;
            this.picProfile.TabStop = false;
            // 
            // tbIDInput
            // 
            this.tbIDInput.AnimateReadOnly = false;
            this.tbIDInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbIDInput.Depth = 0;
            this.tbIDInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbIDInput.LeadingIcon = null;
            this.tbIDInput.Location = new System.Drawing.Point(1249, 267);
            this.tbIDInput.MaxLength = 50;
            this.tbIDInput.MouseState = MaterialSkin.MouseState.OUT;
            this.tbIDInput.Multiline = false;
            this.tbIDInput.Name = "tbIDInput";
            this.tableLayoutPanel1.SetRowSpan(this.tbIDInput, 2);
            this.tbIDInput.Size = new System.Drawing.Size(172, 50);
            this.tbIDInput.TabIndex = 8;
            this.tbIDInput.Text = "yubi2023";
            this.tbIDInput.TrailingIcon = null;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLogin.Depth = 0;
            this.btnLogin.Enabled = false;
            this.btnLogin.HighEmphasis = true;
            this.btnLogin.Icon = null;
            this.btnLogin.Location = new System.Drawing.Point(1428, 270);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLogin.Size = new System.Drawing.Size(170, 36);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Logged In";
            this.btnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLogin.UseAccentColor = false;
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // panelPersonalInfo1
            // 
            this.panelPersonalInfo1.BorderRadius = 20;
            this.panelPersonalInfo1.ColorEnd = System.Drawing.Color.Black;
            this.panelPersonalInfo1.ColorInit = System.Drawing.Color.SkyBlue;
            this.tableLayoutPanel1.SetColumnSpan(this.panelPersonalInfo1, 2);
            this.panelPersonalInfo1.Controls.Add(this.lbHistory);
            this.panelPersonalInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPersonalInfo1.GradientAngle = 30F;
            this.panelPersonalInfo1.Location = new System.Drawing.Point(893, 35);
            this.panelPersonalInfo1.Name = "panelPersonalInfo1";
            this.tableLayoutPanel1.SetRowSpan(this.panelPersonalInfo1, 2);
            this.panelPersonalInfo1.Size = new System.Drawing.Size(350, 143);
            this.panelPersonalInfo1.TabIndex = 17;
            // 
            // lbHistory
            // 
            this.lbHistory.AutoSize = true;
            this.lbHistory.BackColor = System.Drawing.Color.Transparent;
            this.lbHistory.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHistory.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.lbHistory.Location = new System.Drawing.Point(15, 46);
            this.lbHistory.Name = "lbHistory";
            this.lbHistory.Size = new System.Drawing.Size(150, 50);
            this.lbHistory.TabIndex = 1;
            this.lbHistory.Text = "History";
            // 
            // panelPersonalInfo2
            // 
            this.panelPersonalInfo2.BorderRadius = 20;
            this.panelPersonalInfo2.ColorEnd = System.Drawing.Color.Black;
            this.panelPersonalInfo2.ColorInit = System.Drawing.Color.SkyBlue;
            this.tableLayoutPanel1.SetColumnSpan(this.panelPersonalInfo2, 2);
            this.panelPersonalInfo2.Controls.Add(this.lbFoodTicketNum);
            this.panelPersonalInfo2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPersonalInfo2.GradientAngle = 30F;
            this.panelPersonalInfo2.Location = new System.Drawing.Point(893, 184);
            this.panelPersonalInfo2.Name = "panelPersonalInfo2";
            this.tableLayoutPanel1.SetRowSpan(this.panelPersonalInfo2, 2);
            this.panelPersonalInfo2.Size = new System.Drawing.Size(350, 128);
            this.panelPersonalInfo2.TabIndex = 18;
            // 
            // lbFoodTicketNum
            // 
            this.lbFoodTicketNum.AutoSize = true;
            this.lbFoodTicketNum.BackColor = System.Drawing.Color.Transparent;
            this.lbFoodTicketNum.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFoodTicketNum.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.lbFoodTicketNum.Location = new System.Drawing.Point(15, 41);
            this.lbFoodTicketNum.Name = "lbFoodTicketNum";
            this.lbFoodTicketNum.Size = new System.Drawing.Size(320, 50);
            this.lbFoodTicketNum.TabIndex = 0;
            this.lbFoodTicketNum.Text = "Food Ticket Num";
            // 
            // panelPersonalInfo3
            // 
            this.panelPersonalInfo3.BorderRadius = 20;
            this.panelPersonalInfo3.ColorEnd = System.Drawing.Color.Black;
            this.panelPersonalInfo3.ColorInit = System.Drawing.Color.SkyBlue;
            this.tableLayoutPanel1.SetColumnSpan(this.panelPersonalInfo3, 2);
            this.panelPersonalInfo3.Controls.Add(this.lbCalories);
            this.panelPersonalInfo3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPersonalInfo3.GradientAngle = 30F;
            this.panelPersonalInfo3.Location = new System.Drawing.Point(893, 318);
            this.panelPersonalInfo3.Name = "panelPersonalInfo3";
            this.tableLayoutPanel1.SetRowSpan(this.panelPersonalInfo3, 2);
            this.panelPersonalInfo3.Size = new System.Drawing.Size(350, 121);
            this.panelPersonalInfo3.TabIndex = 19;
            // 
            // lbCalories
            // 
            this.lbCalories.AutoSize = true;
            this.lbCalories.BackColor = System.Drawing.Color.Transparent;
            this.lbCalories.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCalories.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.lbCalories.Location = new System.Drawing.Point(15, 35);
            this.lbCalories.Name = "lbCalories";
            this.lbCalories.Size = new System.Drawing.Size(161, 50);
            this.lbCalories.TabIndex = 1;
            this.lbCalories.Text = "Calories";
            // 
            // panelVideo1
            // 
            this.panelVideo1.BorderRadius = 20;
            this.panelVideo1.ColorEnd = System.Drawing.Color.Lavender;
            this.panelVideo1.ColorInit = System.Drawing.Color.SkyBlue;
            this.tableLayoutPanel1.SetColumnSpan(this.panelVideo1, 3);
            this.panelVideo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelVideo1.GradientAngle = 30F;
            this.panelVideo1.Location = new System.Drawing.Point(101, 35);
            this.panelVideo1.Name = "panelVideo1";
            this.tableLayoutPanel1.SetRowSpan(this.panelVideo1, 3);
            this.panelVideo1.Size = new System.Drawing.Size(608, 226);
            this.panelVideo1.TabIndex = 20;
            // 
            // btnStartOrder
            // 
            this.btnStartOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartOrder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStartOrder.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnStartOrder.Depth = 0;
            this.btnStartOrder.HighEmphasis = true;
            this.btnStartOrder.Icon = null;
            this.btnStartOrder.Location = new System.Drawing.Point(1428, 371);
            this.btnStartOrder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnStartOrder.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStartOrder.Name = "btnStartOrder";
            this.btnStartOrder.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnStartOrder.Size = new System.Drawing.Size(170, 36);
            this.btnStartOrder.TabIndex = 22;
            this.btnStartOrder.Text = "Start Order";
            this.btnStartOrder.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnStartOrder.UseAccentColor = false;
            this.btnStartOrder.UseVisualStyleBackColor = true;
            this.btnStartOrder.Click += new System.EventHandler(this.btnStartOrder_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1784, 689);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.VisibleChanged += new System.EventHandler(this.HomeForm_VisibleChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            this.panelPersonalInfo1.ResumeLayout(false);
            this.panelPersonalInfo1.PerformLayout();
            this.panelPersonalInfo2.ResumeLayout(false);
            this.panelPersonalInfo2.PerformLayout();
            this.panelPersonalInfo3.ResumeLayout(false);
            this.panelPersonalInfo3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox tbIDInput;
        private MaterialSkin.Controls.MaterialButton btnLogin;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.PictureBox picProfile;
        private KYBController.KYBGradationRow panelVideo2;
        private KYBController.KYBGradationRow panelPersonalInfo1;
        private KYBController.KYBGradationRow panelPersonalInfo2;
        private KYBController.KYBGradationRow panelPersonalInfo3;
        private KYBController.KYBGradationRow panelVideo1;
        private MaterialSkin.Controls.MaterialButton btnStartOrder;
        private MaterialSkin.Controls.MaterialButton btnLogOff;
        private System.Windows.Forms.Label lbFoodTicketNum;
        private System.Windows.Forms.Label lbHistory;
        private System.Windows.Forms.Label lbCalories;
    }
}