namespace PharmaPlusSoft
{
    partial class Order
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
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lblSatus = new System.Windows.Forms.Label();
            this.txtDeliveryAdress = new System.Windows.Forms.TextBox();
            this.txtOrderDescription = new System.Windows.Forms.TextBox();
            this.cbDeliveryStatus = new System.Windows.Forms.ComboBox();
            this.btnPOrder = new System.Windows.Forms.Button();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.DTPDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.lblDeliveryDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(33, 49);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(86, 15);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Description";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(0, 134);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(119, 15);
            this.lblAdress.TabIndex = 1;
            this.lblAdress.Text = "Delivery Adress";
            // 
            // lblSatus
            // 
            this.lblSatus.AutoSize = true;
            this.lblSatus.Location = new System.Drawing.Point(4, 177);
            this.lblSatus.Name = "lblSatus";
            this.lblSatus.Size = new System.Drawing.Size(115, 15);
            this.lblSatus.TabIndex = 2;
            this.lblSatus.Text = "Delivery Status";
            // 
            // txtDeliveryAdress
            // 
            this.txtDeliveryAdress.Location = new System.Drawing.Point(125, 134);
            this.txtDeliveryAdress.Name = "txtDeliveryAdress";
            this.txtDeliveryAdress.Size = new System.Drawing.Size(270, 22);
            this.txtDeliveryAdress.TabIndex = 2;
            // 
            // txtOrderDescription
            // 
            this.txtOrderDescription.Location = new System.Drawing.Point(125, 12);
            this.txtOrderDescription.Multiline = true;
            this.txtOrderDescription.Name = "txtOrderDescription";
            this.txtOrderDescription.Size = new System.Drawing.Size(270, 91);
            this.txtOrderDescription.TabIndex = 1;
            // 
            // cbDeliveryStatus
            // 
            this.cbDeliveryStatus.Enabled = false;
            this.cbDeliveryStatus.FormattingEnabled = true;
            this.cbDeliveryStatus.Location = new System.Drawing.Point(125, 174);
            this.cbDeliveryStatus.Name = "cbDeliveryStatus";
            this.cbDeliveryStatus.Size = new System.Drawing.Size(270, 23);
            this.cbDeliveryStatus.TabIndex = 5;
            // 
            // btnPOrder
            // 
            this.btnPOrder.Location = new System.Drawing.Point(274, 255);
            this.btnPOrder.Name = "btnPOrder";
            this.btnPOrder.Size = new System.Drawing.Size(121, 43);
            this.btnPOrder.TabIndex = 6;
            this.btnPOrder.Text = "Place Order";
            this.btnPOrder.UseVisualStyleBackColor = true;
            this.btnPOrder.Click += new System.EventHandler(this.btnPOrder_Click);
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Location = new System.Drawing.Point(125, 255);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(128, 43);
            this.btnCancelOrder.TabIndex = 7;
            this.btnCancelOrder.Text = "Cancel";
            this.btnCancelOrder.UseVisualStyleBackColor = true;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // DTPDeliveryDate
            // 
            this.DTPDeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPDeliveryDate.Location = new System.Drawing.Point(125, 216);
            this.DTPDeliveryDate.Name = "DTPDeliveryDate";
            this.DTPDeliveryDate.Size = new System.Drawing.Size(270, 22);
            this.DTPDeliveryDate.TabIndex = 3;
            // 
            // lblDeliveryDate
            // 
            this.lblDeliveryDate.AutoSize = true;
            this.lblDeliveryDate.Location = new System.Drawing.Point(13, 222);
            this.lblDeliveryDate.Name = "lblDeliveryDate";
            this.lblDeliveryDate.Size = new System.Drawing.Size(106, 15);
            this.lblDeliveryDate.TabIndex = 9;
            this.lblDeliveryDate.Text = "Delivery Date";
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 302);
            this.ControlBox = false;
            this.Controls.Add(this.lblDeliveryDate);
            this.Controls.Add(this.DTPDeliveryDate);
            this.Controls.Add(this.btnCancelOrder);
            this.Controls.Add(this.btnPOrder);
            this.Controls.Add(this.cbDeliveryStatus);
            this.Controls.Add(this.txtOrderDescription);
            this.Controls.Add(this.txtDeliveryAdress);
            this.Controls.Add(this.lblSatus);
            this.Controls.Add(this.lblAdress);
            this.Controls.Add(this.lblDescription);
            this.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblSatus;
        private System.Windows.Forms.TextBox txtDeliveryAdress;
        private System.Windows.Forms.TextBox txtOrderDescription;
        private System.Windows.Forms.ComboBox cbDeliveryStatus;
        private System.Windows.Forms.Button btnPOrder;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.DateTimePicker DTPDeliveryDate;
        private System.Windows.Forms.Label lblDeliveryDate;
    }
}