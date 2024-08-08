namespace VentoVoxKiosk.Pages
{
    partial class MenuForm
    {
        public class TableLayoutPanel : System.Windows.Forms.TableLayoutPanel
        {
            public TableLayoutPanel()
            {
                base.DoubleBuffered = true;
            }
        }

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
            this.panelFood = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new VentoVoxKiosk.Pages.MenuForm.TableLayoutPanel();
            this.ListBoxCart = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new VentoVoxKiosk.Pages.MenuForm.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBar_Comp1 = new VentoVoxKiosk.Pages.UserComponent.SearchBar_Comp();
            this.btnMoveToOrderConfirm = new MyUserControl.KYBButton();
            this.panelDrink = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFood
            // 
            this.panelFood.AutoScroll = true;
            this.tableLayoutPanel1.SetColumnSpan(this.panelFood, 3);
            this.panelFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFood.Location = new System.Drawing.Point(55, 150);
            this.panelFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelFood.Name = "panelFood";
            this.tableLayoutPanel1.SetRowSpan(this.panelFood, 7);
            this.panelFood.Size = new System.Drawing.Size(345, 424);
            this.panelFood.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.panelDrink, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.panelFood, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ListBoxCart, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnMoveToOrderConfirm, 8, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.10452F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.864275F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1043, 641);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // ListBoxCart
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.ListBoxCart, 2);
            this.ListBoxCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBoxCart.FormattingEnabled = true;
            this.ListBoxCart.ItemHeight = 12;
            this.ListBoxCart.Location = new System.Drawing.Point(757, 151);
            this.ListBoxCart.Name = "ListBoxCart";
            this.tableLayoutPanel1.SetRowSpan(this.ListBoxCart, 7);
            this.ListBoxCart.Size = new System.Drawing.Size(228, 422);
            this.ListBoxCart.TabIndex = 4;
            this.ListBoxCart.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListBoxCart_MouseDoubleClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 5);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.11688F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.88312F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 212F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.searchBar_Comp1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(55, 67);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(579, 78);
            this.tableLayoutPanel2.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("휴먼엑스포", 14F);
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu Selection";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchBar_Comp1
            // 
            this.searchBar_Comp1.Location = new System.Drawing.Point(3, 42);
            this.searchBar_Comp1.Name = "searchBar_Comp1";
            this.searchBar_Comp1.Size = new System.Drawing.Size(255, 33);
            this.searchBar_Comp1.TabIndex = 2;
            // 
            // btnMoveToOrderConfirm
            // 
            this.btnMoveToOrderConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoveToOrderConfirm.BackColor = System.Drawing.Color.Bisque;
            this.btnMoveToOrderConfirm.BackgroundColor = System.Drawing.Color.Bisque;
            this.btnMoveToOrderConfirm.BorderColor = System.Drawing.Color.White;
            this.btnMoveToOrderConfirm.BorderRadius = 10;
            this.btnMoveToOrderConfirm.BorderSize = 3;
            this.btnMoveToOrderConfirm.FlatAppearance.BorderSize = 0;
            this.btnMoveToOrderConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveToOrderConfirm.Font = new System.Drawing.Font("휴먼엑스포", 10F);
            this.btnMoveToOrderConfirm.ForeColor = System.Drawing.Color.Black;
            this.btnMoveToOrderConfirm.Location = new System.Drawing.Point(874, 84);
            this.btnMoveToOrderConfirm.Name = "btnMoveToOrderConfirm";
            this.btnMoveToOrderConfirm.Size = new System.Drawing.Size(111, 43);
            this.btnMoveToOrderConfirm.TabIndex = 35;
            this.btnMoveToOrderConfirm.Text = "Check Out";
            this.btnMoveToOrderConfirm.TextColor = System.Drawing.Color.Black;
            this.btnMoveToOrderConfirm.UseVisualStyleBackColor = false;
            this.btnMoveToOrderConfirm.Click += new System.EventHandler(this.btnMoveToCheckOutPage_Click);
            // 
            // panelDrink
            // 
            this.panelDrink.AutoScroll = true;
            this.tableLayoutPanel1.SetColumnSpan(this.panelDrink, 3);
            this.panelDrink.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDrink.Location = new System.Drawing.Point(406, 150);
            this.panelDrink.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDrink.Name = "panelDrink";
            this.tableLayoutPanel1.SetRowSpan(this.panelDrink, 7);
            this.panelDrink.Size = new System.Drawing.Size(345, 424);
            this.panelDrink.TabIndex = 36;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1043, 641);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelFood;
        private System.Windows.Forms.Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private UserComponent.SearchBar_Comp searchBar_Comp1;
        private MyUserControl.KYBButton btnMoveToOrderConfirm;
        private System.Windows.Forms.ListBox ListBoxCart;
        private System.Windows.Forms.Panel panelDrink;
    }
}