namespace AmeKhanoom
{
    partial class OrderDeliver
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.DeliverBtn = new System.Windows.Forms.ToolStripButton();
            this.SellBtn = new System.Windows.Forms.ToolStripButton();
            this.OrderTable = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliverytime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subscode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delivercode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderTable)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeliverBtn,
            this.SellBtn});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 501);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(866, 39);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // DeliverBtn
            // 
            this.DeliverBtn.AutoSize = false;
            this.DeliverBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeliverBtn.Image = global::AmeKhanoom.Properties.Resources.check;
            this.DeliverBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DeliverBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeliverBtn.Name = "DeliverBtn";
            this.DeliverBtn.Size = new System.Drawing.Size(37, 37);
            this.DeliverBtn.Text = "Deliver";
            this.DeliverBtn.Click += new System.EventHandler(this.DeliverBtn_Click);
            // 
            // SellBtn
            // 
            this.SellBtn.AutoSize = false;
            this.SellBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SellBtn.Image = global::AmeKhanoom.Properties.Resources.check_1_;
            this.SellBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SellBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SellBtn.Name = "SellBtn";
            this.SellBtn.Size = new System.Drawing.Size(37, 37);
            this.SellBtn.Text = "Sell";
            this.SellBtn.Click += new System.EventHandler(this.SellBtn_Click);
            // 
            // OrderTable
            // 
            this.OrderTable.AllowUserToAddRows = false;
            this.OrderTable.AllowUserToDeleteRows = false;
            this.OrderTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderTable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.OrderTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.deliverytime,
            this.Subscode,
            this.price,
            this.delivercode});
            this.OrderTable.Location = new System.Drawing.Point(13, 12);
            this.OrderTable.Name = "OrderTable";
            this.OrderTable.ReadOnly = true;
            this.OrderTable.Size = new System.Drawing.Size(841, 472);
            this.OrderTable.TabIndex = 4;
            // 
            // number
            // 
            this.number.HeaderText = "No.";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.Visible = false;
            // 
            // deliverytime
            // 
            this.deliverytime.HeaderText = "Delivery Time";
            this.deliverytime.Name = "deliverytime";
            this.deliverytime.ReadOnly = true;
            this.deliverytime.Visible = false;
            // 
            // Subscode
            // 
            this.Subscode.HeaderText = "Subscriber code";
            this.Subscode.Name = "Subscode";
            this.Subscode.ReadOnly = true;
            this.Subscode.Visible = false;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Visible = false;
            // 
            // delivercode
            // 
            this.delivercode.HeaderText = "Delivery Code";
            this.delivercode.Name = "delivercode";
            this.delivercode.ReadOnly = true;
            this.delivercode.Visible = false;
            // 
            // OrderDeliver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(866, 540);
            this.Controls.Add(this.OrderTable);
            this.Controls.Add(this.toolStrip1);
            this.Name = "OrderDeliver";
            this.Text = "OrderDeliver";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton SellBtn;
        private System.Windows.Forms.ToolStripButton DeliverBtn;
        private System.Windows.Forms.DataGridView OrderTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliverytime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subscode;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn delivercode;
    }
}