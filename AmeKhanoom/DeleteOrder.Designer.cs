namespace AmeKhanoom
{
    partial class DeleteOrder
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
            this.TxtDelcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.OKBtn = new System.Windows.Forms.Button();
            this.Txtnum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtDelcode
            // 
            this.TxtDelcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDelcode.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDelcode.Location = new System.Drawing.Point(94, 50);
            this.TxtDelcode.Name = "TxtDelcode";
            this.TxtDelcode.Size = new System.Drawing.Size(145, 19);
            this.TxtDelcode.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Delivey Code :";
            // 
            // CloseBtn
            // 
            this.CloseBtn.Image = global::AmeKhanoom.Properties.Resources.cancel;
            this.CloseBtn.Location = new System.Drawing.Point(130, 146);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(40, 40);
            this.CloseBtn.TabIndex = 14;
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // OKBtn
            // 
            this.OKBtn.Image = global::AmeKhanoom.Properties.Resources.check1;
            this.OKBtn.Location = new System.Drawing.Point(84, 146);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(40, 40);
            this.OKBtn.TabIndex = 13;
            this.OKBtn.UseVisualStyleBackColor = true;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // Txtnum
            // 
            this.Txtnum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txtnum.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtnum.Location = new System.Drawing.Point(94, 109);
            this.Txtnum.Name = "Txtnum";
            this.Txtnum.Size = new System.Drawing.Size(145, 19);
            this.Txtnum.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "No. :";
            // 
            // DeleteOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(251, 199);
            this.Controls.Add(this.Txtnum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.TxtDelcode);
            this.Controls.Add(this.label1);
            this.Name = "DeleteOrder";
            this.Text = "DeleteOrder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.TextBox TxtDelcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txtnum;
        private System.Windows.Forms.Label label2;
    }
}