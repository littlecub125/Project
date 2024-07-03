namespace VentoVox.View.UserComponent
{
    partial class menuOption
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
            this.Button2 = new MaterialSkin.Controls.MaterialButton();
            this.Button1 = new MaterialSkin.Controls.MaterialButton();
            this.lbFoodDescription = new System.Windows.Forms.ListBox();
            this.picFood = new System.Windows.Forms.PictureBox();
            this.lbMenuTitle = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picFood)).BeginInit();
            this.SuspendLayout();
            // 
            // Button2
            // 
            this.Button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Button2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Button2.Depth = 0;
            this.Button2.HighEmphasis = true;
            this.Button2.Icon = null;
            this.Button2.Location = new System.Drawing.Point(148, 397);
            this.Button2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Button2.MouseState = MaterialSkin.MouseState.HOVER;
            this.Button2.Name = "Button2";
            this.Button2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Button2.Size = new System.Drawing.Size(80, 36);
            this.Button2.TabIndex = 11;
            this.Button2.Text = "Remove";
            this.Button2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Button2.UseAccentColor = false;
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Button1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Button1.Depth = 0;
            this.Button1.HighEmphasis = true;
            this.Button1.Icon = null;
            this.Button1.Location = new System.Drawing.Point(83, 397);
            this.Button1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Button1.MouseState = MaterialSkin.MouseState.HOVER;
            this.Button1.Name = "Button1";
            this.Button1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Button1.Size = new System.Drawing.Size(64, 36);
            this.Button1.TabIndex = 10;
            this.Button1.Text = "Add";
            this.Button1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Button1.UseAccentColor = false;
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lbFoodDescription
            // 
            this.lbFoodDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbFoodDescription.FormattingEnabled = true;
            this.lbFoodDescription.ItemHeight = 12;
            this.lbFoodDescription.Location = new System.Drawing.Point(23, 303);
            this.lbFoodDescription.Name = "lbFoodDescription";
            this.lbFoodDescription.Size = new System.Drawing.Size(200, 88);
            this.lbFoodDescription.TabIndex = 9;
            // 
            // picFood
            // 
            this.picFood.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picFood.Image = global::VentoVox.Properties.Resources.vegan_2;
            this.picFood.Location = new System.Drawing.Point(23, 72);
            this.picFood.Name = "picFood";
            this.picFood.Size = new System.Drawing.Size(200, 200);
            this.picFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFood.TabIndex = 8;
            this.picFood.TabStop = false;
            // 
            // lbMenuTitle
            // 
            this.lbMenuTitle.AutoSize = true;
            this.lbMenuTitle.Depth = 0;
            this.lbMenuTitle.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbMenuTitle.Location = new System.Drawing.Point(24, 47);
            this.lbMenuTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbMenuTitle.Name = "lbMenuTitle";
            this.lbMenuTitle.Size = new System.Drawing.Size(41, 19);
            this.lbMenuTitle.TabIndex = 7;
            this.lbMenuTitle.Text = "Menu";
            // 
            // menuOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.lbFoodDescription);
            this.Controls.Add(this.picFood);
            this.Controls.Add(this.lbMenuTitle);
            this.Name = "menuOption";
            this.Size = new System.Drawing.Size(250, 480);
            ((System.ComponentModel.ISupportInitialize)(this.picFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton Button2;
        private MaterialSkin.Controls.MaterialButton Button1;
        private System.Windows.Forms.ListBox lbFoodDescription;
        private System.Windows.Forms.PictureBox picFood;
        private MaterialSkin.Controls.MaterialLabel lbMenuTitle;
    }
}
