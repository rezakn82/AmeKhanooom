namespace AmeKhanoom
{
    partial class Addsub
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
            this.GB1 = new System.Windows.Forms.GroupBox();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.TxtFname = new System.Windows.Forms.TextBox();
            this.TxtLname = new System.Windows.Forms.TextBox();
            this.TxtPhone = new System.Windows.Forms.TextBox();
            this.TxtCCnumber = new System.Windows.Forms.TextBox();
            this.TxtSubcode = new System.Windows.Forms.TextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GB1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB1
            // 
            this.GB1.Controls.Add(this.CloseBtn);
            this.GB1.Controls.Add(this.TxtFname);
            this.GB1.Controls.Add(this.TxtLname);
            this.GB1.Controls.Add(this.TxtPhone);
            this.GB1.Controls.Add(this.TxtCCnumber);
            this.GB1.Controls.Add(this.TxtSubcode);
            this.GB1.Controls.Add(this.AddBtn);
            this.GB1.Controls.Add(this.label5);
            this.GB1.Controls.Add(this.label4);
            this.GB1.Controls.Add(this.label3);
            this.GB1.Controls.Add(this.label2);
            this.GB1.Controls.Add(this.label1);
            this.GB1.Location = new System.Drawing.Point(13, 13);
            this.GB1.Name = "GB1";
            this.GB1.Size = new System.Drawing.Size(563, 271);
            this.GB1.TabIndex = 0;
            this.GB1.TabStop = false;
            this.GB1.Text = "Add Subscriber";
            // 
            // CloseBtn
            // 
            this.CloseBtn.Image = global::AmeKhanoom.Properties.Resources.cancel;
            this.CloseBtn.Location = new System.Drawing.Point(284, 225);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(40, 40);
            this.CloseBtn.TabIndex = 6;
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // TxtFname
            // 
            this.TxtFname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtFname.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFname.Location = new System.Drawing.Point(238, 60);
            this.TxtFname.Name = "TxtFname";
            this.TxtFname.Size = new System.Drawing.Size(210, 19);
            this.TxtFname.TabIndex = 11;
            // 
            // TxtLname
            // 
            this.TxtLname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtLname.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLname.Location = new System.Drawing.Point(238, 90);
            this.TxtLname.Name = "TxtLname";
            this.TxtLname.Size = new System.Drawing.Size(210, 19);
            this.TxtLname.TabIndex = 10;
            // 
            // TxtPhone
            // 
            this.TxtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPhone.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPhone.Location = new System.Drawing.Point(238, 150);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(210, 19);
            this.TxtPhone.TabIndex = 9;
            this.TxtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPhone_KeyPress);
            // 
            // TxtCCnumber
            // 
            this.TxtCCnumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCCnumber.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCCnumber.Location = new System.Drawing.Point(238, 120);
            this.TxtCCnumber.Name = "TxtCCnumber";
            this.TxtCCnumber.Size = new System.Drawing.Size(210, 19);
            this.TxtCCnumber.TabIndex = 8;
            this.TxtCCnumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCCnumber_KeyPress);
            // 
            // TxtSubcode
            // 
            this.TxtSubcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSubcode.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSubcode.Location = new System.Drawing.Point(238, 30);
            this.TxtSubcode.Name = "TxtSubcode";
            this.TxtSubcode.ReadOnly = true;
            this.TxtSubcode.Size = new System.Drawing.Size(210, 19);
            this.TxtSubcode.TabIndex = 7;
            // 
            // AddBtn
            // 
            this.AddBtn.Image = global::AmeKhanoom.Properties.Resources.check1;
            this.AddBtn.Location = new System.Drawing.Point(238, 225);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(40, 40);
            this.AddBtn.TabIndex = 5;
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "First Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Last Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Credit Card Number :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phone Number :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subscription Code";
            // 
            // Addsub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(588, 296);
            this.Controls.Add(this.GB1);
            this.Name = "Addsub";
            this.Text = "Adddsub";
            this.GB1.ResumeLayout(false);
            this.GB1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GB1;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtFname;
        private System.Windows.Forms.TextBox TxtLname;
        private System.Windows.Forms.TextBox TxtPhone;
        private System.Windows.Forms.TextBox TxtCCnumber;
        private System.Windows.Forms.TextBox TxtSubcode;
        private System.Windows.Forms.Button CloseBtn;
    }
}