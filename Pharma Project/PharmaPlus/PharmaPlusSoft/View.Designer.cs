namespace PharmaPlusSoft
{
    partial class View
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblLoginName = new System.Windows.Forms.Label();
            this.lblSeparator = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnUpdateUserInfo = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnAdminControls = new System.Windows.Forms.Button();
            this.dGVOrders = new System.Windows.Forms.DataGridView();
            this.clientMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifyOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVOrders)).BeginInit();
            this.clientMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLoginName
            // 
            this.lblLoginName.AutoSize = true;
            this.lblLoginName.Location = new System.Drawing.Point(13, 9);
            this.lblLoginName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoginName.Name = "lblLoginName";
            this.lblLoginName.Size = new System.Drawing.Size(47, 15);
            this.lblLoginName.TabIndex = 0;
            this.lblLoginName.Text = "Hello,";
            // 
            // lblSeparator
            // 
            this.lblSeparator.AutoSize = true;
            this.lblSeparator.Location = new System.Drawing.Point(-7, 24);
            this.lblSeparator.Name = "lblSeparator";
            this.lblSeparator.Size = new System.Drawing.Size(938, 15);
            this.lblSeparator.TabIndex = 1;
            this.lblSeparator.Text = "*********************************************************************************" +
    "****************************************************";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(605, 1);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 10;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnUpdateUserInfo
            // 
            this.btnUpdateUserInfo.Location = new System.Drawing.Point(468, 1);
            this.btnUpdateUserInfo.Name = "btnUpdateUserInfo";
            this.btnUpdateUserInfo.Size = new System.Drawing.Size(131, 23);
            this.btnUpdateUserInfo.TabIndex = 1;
            this.btnUpdateUserInfo.Text = "Update My Info";
            this.btnUpdateUserInfo.UseVisualStyleBackColor = true;
            this.btnUpdateUserInfo.Click += new System.EventHandler(this.btnUpdateUserInfo_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(13, 43);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(75, 39);
            this.btnPlaceOrder.TabIndex = 11;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnAdminControls
            // 
            this.btnAdminControls.Location = new System.Drawing.Point(12, 252);
            this.btnAdminControls.Name = "btnAdminControls";
            this.btnAdminControls.Size = new System.Drawing.Size(75, 38);
            this.btnAdminControls.TabIndex = 15;
            this.btnAdminControls.Text = "Admin Controls";
            this.btnAdminControls.UseVisualStyleBackColor = true;
            // 
            // dGVOrders
            // 
            this.dGVOrders.AllowUserToAddRows = false;
            this.dGVOrders.AllowUserToDeleteRows = false;
            this.dGVOrders.AllowUserToOrderColumns = true;
            this.dGVOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGVOrders.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGVOrders.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dGVOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVOrders.ContextMenuStrip = this.clientMenu;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVOrders.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGVOrders.Location = new System.Drawing.Point(110, 42);
            this.dGVOrders.Name = "dGVOrders";
            this.dGVOrders.ReadOnly = true;
            this.dGVOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVOrders.Size = new System.Drawing.Size(570, 208);
            this.dGVOrders.TabIndex = 16;
            // 
            // clientMenu
            // 
            this.clientMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewOrderToolStripMenuItem,
            this.modifyOrderToolStripMenuItem,
            this.cancelOrderToolStripMenuItem});
            this.clientMenu.Name = "clientMenu";
            this.clientMenu.Size = new System.Drawing.Size(146, 70);
            // 
            // modifyOrderToolStripMenuItem
            // 
            this.modifyOrderToolStripMenuItem.Name = "modifyOrderToolStripMenuItem";
            this.modifyOrderToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.modifyOrderToolStripMenuItem.Text = "Modify Order";
            // 
            // cancelOrderToolStripMenuItem
            // 
            this.cancelOrderToolStripMenuItem.Name = "cancelOrderToolStripMenuItem";
            this.cancelOrderToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cancelOrderToolStripMenuItem.Text = "Cancel Order";
            // 
            // viewOrderToolStripMenuItem
            // 
            this.viewOrderToolStripMenuItem.Name = "viewOrderToolStripMenuItem";
            this.viewOrderToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.viewOrderToolStripMenuItem.Text = "View Order";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(605, 256);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 43);
            this.btnRefresh.TabIndex = 17;
            this.btnRefresh.Text = "Refresh Table";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 302);
            this.ControlBox = false;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dGVOrders);
            this.Controls.Add(this.btnAdminControls);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.btnUpdateUserInfo);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lblSeparator);
            this.Controls.Add(this.lblLoginName);
            this.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View";
            this.Load += new System.EventHandler(this.View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVOrders)).EndInit();
            this.clientMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblSeparator;
        public System.Windows.Forms.Button btnLogOut;
        public System.Windows.Forms.Button btnUpdateUserInfo;
        public System.Windows.Forms.Button btnPlaceOrder;
        public System.Windows.Forms.Button btnAdminControls;
        public System.Windows.Forms.DataGridView dGVOrders;
        public System.Windows.Forms.Label lblLoginName;
        private System.Windows.Forms.ContextMenuStrip clientMenu;
        private System.Windows.Forms.ToolStripMenuItem viewOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelOrderToolStripMenuItem;
        public System.Windows.Forms.Button btnRefresh;
    }
}