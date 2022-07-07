namespace AmeKhanoom
{
    partial class Backup
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
            this.SubRbtn = new System.Windows.Forms.RadioButton();
            this.OrderRbtn = new System.Windows.Forms.RadioButton();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SubRbtn
            // 
            this.SubRbtn.AutoSize = true;
            this.SubRbtn.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.SubRbtn.Location = new System.Drawing.Point(12, 23);
            this.SubRbtn.Name = "SubRbtn";
            this.SubRbtn.Size = new System.Drawing.Size(113, 22);
            this.SubRbtn.TabIndex = 3;
            this.SubRbtn.TabStop = true;
            this.SubRbtn.Text = "Subscribers";
            this.SubRbtn.UseVisualStyleBackColor = true;
            // 
            // OrderRbtn
            // 
            this.OrderRbtn.AutoSize = true;
            this.OrderRbtn.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.OrderRbtn.Location = new System.Drawing.Point(12, 54);
            this.OrderRbtn.Name = "OrderRbtn";
            this.OrderRbtn.Size = new System.Drawing.Size(76, 22);
            this.OrderRbtn.TabIndex = 4;
            this.OrderRbtn.TabStop = true;
            this.OrderRbtn.Text = "Orders";
            this.OrderRbtn.UseVisualStyleBackColor = true;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Image = global::AmeKhanoom.Properties.Resources.upload;
            this.SaveBtn.Location = new System.Drawing.Point(309, 36);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(40, 40);
            this.SaveBtn.TabIndex = 5;
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // LoadBtn
            // 
            this.LoadBtn.Image = global::AmeKhanoom.Properties.Resources.download;
            this.LoadBtn.Location = new System.Drawing.Point(355, 36);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(40, 40);
            this.LoadBtn.TabIndex = 2;
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(407, 115);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.OrderRbtn);
            this.Controls.Add(this.SubRbtn);
            this.Controls.Add(this.LoadBtn);
            this.Name = "Backup";
            this.Text = "Backup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.RadioButton SubRbtn;
        private System.Windows.Forms.RadioButton OrderRbtn;
        private System.Windows.Forms.Button SaveBtn;
    }
}