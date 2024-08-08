namespace VentoVoxKiosk.Pages.UserComponent
{
    partial class Menu_Comp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Comp));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbFoodName = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.RichTextBox();
            this.Button1 = new MyUserControl.KYBButton();
            this.Button2 = new MyUserControl.KYBButton();
            this.pbFood = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFood)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 150);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tbDescription, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbFoodName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Button1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Button2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.pbFood, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(387, 146);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbFoodName
            // 
            this.lbFoodName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbFoodName.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lbFoodName, 2);
            this.lbFoodName.Font = new System.Drawing.Font("휴먼엑스포", 14F);
            this.lbFoodName.Location = new System.Drawing.Point(3, 0);
            this.lbFoodName.Name = "lbFoodName";
            this.lbFoodName.Size = new System.Drawing.Size(120, 36);
            this.lbFoodName.TabIndex = 2;
            this.lbFoodName.Text = "FoodName";
            this.lbFoodName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbDescription
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tbDescription, 2);
            this.tbDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDescription.Location = new System.Drawing.Point(3, 39);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(186, 67);
            this.tbDescription.TabIndex = 3;
            this.tbDescription.Text = "";
            // 
            // Button1
            // 
            this.Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Button1.BackColor = System.Drawing.Color.Bisque;
            this.Button1.BackgroundColor = System.Drawing.Color.Bisque;
            this.Button1.BorderColor = System.Drawing.Color.White;
            this.Button1.BorderRadius = 10;
            this.Button1.BorderSize = 3;
            this.Button1.FlatAppearance.BorderSize = 0;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1.Font = new System.Drawing.Font("휴먼엑스포", 10F);
            this.Button1.ForeColor = System.Drawing.Color.Black;
            this.Button1.Location = new System.Drawing.Point(3, 112);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(90, 31);
            this.Button1.TabIndex = 34;
            this.Button1.Text = "Cancel";
            this.Button1.TextColor = System.Drawing.Color.Black;
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // Button2
            // 
            this.Button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Button2.BackColor = System.Drawing.Color.Bisque;
            this.Button2.BackgroundColor = System.Drawing.Color.Bisque;
            this.Button2.BorderColor = System.Drawing.Color.White;
            this.Button2.BorderRadius = 10;
            this.Button2.BorderSize = 3;
            this.Button2.FlatAppearance.BorderSize = 0;
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button2.Font = new System.Drawing.Font("휴먼엑스포", 10F);
            this.Button2.ForeColor = System.Drawing.Color.Black;
            this.Button2.Location = new System.Drawing.Point(99, 112);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(90, 31);
            this.Button2.TabIndex = 35;
            this.Button2.Text = "Confirm";
            this.Button2.TextColor = System.Drawing.Color.Black;
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // pbFood
            // 
            this.pbFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbFood.Image = ((System.Drawing.Image)(resources.GetObject("pbFood.Image")));
            this.pbFood.Location = new System.Drawing.Point(195, 3);
            this.pbFood.Name = "pbFood";
            this.tableLayoutPanel1.SetRowSpan(this.pbFood, 3);
            this.pbFood.Size = new System.Drawing.Size(189, 140);
            this.pbFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFood.TabIndex = 36;
            this.pbFood.TabStop = false;
            // 
            // Menu_Comp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Menu_Comp";
            this.Size = new System.Drawing.Size(391, 150);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbFoodName;
        private System.Windows.Forms.RichTextBox tbDescription;
        private MyUserControl.KYBButton Button1;
        private MyUserControl.KYBButton Button2;
        private System.Windows.Forms.PictureBox pbFood;
    }
}
