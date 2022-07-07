namespace AmeKhanoom
{
    partial class Delivery
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TxtOrderNum = new System.Windows.Forms.TextBox();
            this.TxtOrderCode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.DeliverBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CloseBtn);
            this.groupBox1.Controls.Add(this.DeliverBtn);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.TxtOrderNum);
            this.groupBox1.Controls.Add(this.TxtOrderCode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 234);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Deliver";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(104, 141);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(221, 19);
            this.textBox2.TabIndex = 3;
            // 
            // TxtOrderNum
            // 
            this.TxtOrderNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtOrderNum.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOrderNum.Location = new System.Drawing.Point(104, 67);
            this.TxtOrderNum.Name = "TxtOrderNum";
            this.TxtOrderNum.Size = new System.Drawing.Size(221, 19);
            this.TxtOrderNum.TabIndex = 2;
            // 
            // TxtOrderCode
            // 
            this.TxtOrderCode.AutoSize = true;
            this.TxtOrderCode.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOrderCode.Location = new System.Drawing.Point(7, 105);
            this.TxtOrderCode.Name = "TxtOrderCode";
            this.TxtOrderCode.Size = new System.Drawing.Size(96, 18);
            this.TxtOrderCode.TabIndex = 1;
            this.TxtOrderCode.Text = "Order Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Number";
            // 
            // CloseBtn
            // 
            this.CloseBtn.Image = global::AmeKhanoom.Properties.Resources.cancel;
            this.CloseBtn.Location = new System.Drawing.Point(179, 187);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(40, 40);
            this.CloseBtn.TabIndex = 8;
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // DeliverBtn
            // 
            this.DeliverBtn.Image = global::AmeKhanoom.Properties.Resources.check1;
            this.DeliverBtn.Location = new System.Drawing.Point(133, 187);
            this.DeliverBtn.Name = "DeliverBtn";
            this.DeliverBtn.Size = new System.Drawing.Size(40, 40);
            this.DeliverBtn.TabIndex = 7;
            this.DeliverBtn.UseVisualStyleBackColor = true;
            this.DeliverBtn.Click += new System.EventHandler(this.DeliverBtn_Click);
            // 
            // Delivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(381, 259);
            this.Controls.Add(this.groupBox1);
            this.Name = "Delivery";
            this.Text = "Delivery";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button DeliverBtn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox TxtOrderNum;
        private System.Windows.Forms.Label TxtOrderCode;
        private System.Windows.Forms.Label label1;
    }
}