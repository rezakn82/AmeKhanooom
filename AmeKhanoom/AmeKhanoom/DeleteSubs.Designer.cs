namespace AmeKhanoom
{
    partial class DeleteSubs
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
            this.TxtSubcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.OKBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtSubcode
            // 
            this.TxtSubcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSubcode.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSubcode.Location = new System.Drawing.Point(94, 57);
            this.TxtSubcode.Name = "TxtSubcode";
            this.TxtSubcode.Size = new System.Drawing.Size(145, 19);
            this.TxtSubcode.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Subscription Code :";
            // 
            // CloseBtn
            // 
            this.CloseBtn.Image = global::AmeKhanoom.Properties.Resources.cancel;
            this.CloseBtn.Location = new System.Drawing.Point(130, 113);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(40, 40);
            this.CloseBtn.TabIndex = 10;
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // OKBtn
            // 
            this.OKBtn.Image = global::AmeKhanoom.Properties.Resources.check1;
            this.OKBtn.Location = new System.Drawing.Point(84, 113);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(40, 40);
            this.OKBtn.TabIndex = 9;
            this.OKBtn.UseVisualStyleBackColor = true;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // DeleteSubs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(251, 165);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.TxtSubcode);
            this.Controls.Add(this.label1);
            this.Name = "DeleteSubs";
            this.Text = "DeleteSubs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtSubcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button OKBtn;
    }
}