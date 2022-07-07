namespace AmeKhanoom
{
    partial class Olderorder
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
            this.OrderTable = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliverytime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subscode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delivercode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoadBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OrderTable)).BeginInit();
            this.SuspendLayout();
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
            this.OrderTable.Location = new System.Drawing.Point(12, 12);
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
            // LoadBtn
            // 
            this.LoadBtn.Image = global::AmeKhanoom.Properties.Resources.folder_1_;
            this.LoadBtn.Location = new System.Drawing.Point(12, 490);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(40, 40);
            this.LoadBtn.TabIndex = 6;
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // Olderorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(866, 540);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.OrderTable);
            this.Name = "Olderorder";
            this.Text = "Olderorder";
            ((System.ComponentModel.ISupportInitialize)(this.OrderTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView OrderTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliverytime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subscode;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn delivercode;
        private System.Windows.Forms.Button LoadBtn;
    }
}