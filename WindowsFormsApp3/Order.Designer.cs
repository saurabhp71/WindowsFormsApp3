namespace WindowsFormsApp3
{
    partial class frmOrder
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
            this.lblmenuname = new System.Windows.Forms.Label();
            this.lblPrice1 = new System.Windows.Forms.Label();
            this.txtbxMenuName = new System.Windows.Forms.TextBox();
            this.txtbxMenuPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblmenuname
            // 
            this.lblmenuname.AutoSize = true;
            this.lblmenuname.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmenuname.Location = new System.Drawing.Point(136, 110);
            this.lblmenuname.Name = "lblmenuname";
            this.lblmenuname.Size = new System.Drawing.Size(104, 23);
            this.lblmenuname.TabIndex = 0;
            this.lblmenuname.Text = "Menu Name:";
            // 
            // lblPrice1
            // 
            this.lblPrice1.AutoSize = true;
            this.lblPrice1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice1.Location = new System.Drawing.Point(136, 209);
            this.lblPrice1.Name = "lblPrice1";
            this.lblPrice1.Size = new System.Drawing.Size(99, 23);
            this.lblPrice1.TabIndex = 1;
            this.lblPrice1.Text = "Menu Price:";
            // 
            // txtbxMenuName
            // 
            this.txtbxMenuName.Location = new System.Drawing.Point(265, 115);
            this.txtbxMenuName.Name = "txtbxMenuName";
            this.txtbxMenuName.Size = new System.Drawing.Size(156, 20);
            this.txtbxMenuName.TabIndex = 2;
            // 
            // txtbxMenuPrice
            // 
            this.txtbxMenuPrice.Location = new System.Drawing.Point(265, 214);
            this.txtbxMenuPrice.Name = "txtbxMenuPrice";
            this.txtbxMenuPrice.Size = new System.Drawing.Size(156, 20);
            this.txtbxMenuPrice.TabIndex = 3;
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 304);
            this.Controls.Add(this.txtbxMenuPrice);
            this.Controls.Add(this.txtbxMenuName);
            this.Controls.Add(this.lblPrice1);
            this.Controls.Add(this.lblmenuname);
            this.Name = "frmOrder";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmenuname;
        private System.Windows.Forms.Label lblPrice1;
        private System.Windows.Forms.TextBox txtbxMenuName;
        private System.Windows.Forms.TextBox txtbxMenuPrice;
    }
}