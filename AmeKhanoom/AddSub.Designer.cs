namespace AmeKhanoom
{
    partial class ManageSub
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
            this.SubsTable = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddSubBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.EditBtn = new System.Windows.Forms.ToolStripButton();
            this.AddCreditBtn = new System.Windows.Forms.ToolStripButton();
            this.subcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.SubsTable)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SubsTable
            // 
            this.SubsTable.AllowUserToAddRows = false;
            this.SubsTable.AllowUserToDeleteRows = false;
            this.SubsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SubsTable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.SubsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subcode,
            this.fname,
            this.lname,
            this.credit,
            this.ccnumber});
            this.SubsTable.Location = new System.Drawing.Point(13, 13);
            this.SubsTable.Name = "SubsTable";
            this.SubsTable.ReadOnly = true;
            this.SubsTable.Size = new System.Drawing.Size(841, 472);
            this.SubsTable.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddSubBtn,
            this.toolStripButton2,
            this.EditBtn,
            this.AddCreditBtn});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 501);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(866, 39);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AddSubBtn
            // 
            this.AddSubBtn.AutoSize = false;
            this.AddSubBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddSubBtn.Image = global::AmeKhanoom.Properties.Resources.add_user_2_;
            this.AddSubBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddSubBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddSubBtn.Name = "AddSubBtn";
            this.AddSubBtn.Size = new System.Drawing.Size(37, 37);
            this.AddSubBtn.Text = "Add";
            this.AddSubBtn.Click += new System.EventHandler(this.AddSubBtn_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.AutoSize = false;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::AmeKhanoom.Properties.Resources.remove_user_1_;
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(37, 37);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // EditBtn
            // 
            this.EditBtn.AutoSize = false;
            this.EditBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditBtn.Image = global::AmeKhanoom.Properties.Resources.edit;
            this.EditBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(37, 37);
            this.EditBtn.Text = "Edit";
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // AddCreditBtn
            // 
            this.AddCreditBtn.AutoSize = false;
            this.AddCreditBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddCreditBtn.Image = global::AmeKhanoom.Properties.Resources.credit_card;
            this.AddCreditBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddCreditBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddCreditBtn.Name = "AddCreditBtn";
            this.AddCreditBtn.Size = new System.Drawing.Size(37, 37);
            this.AddCreditBtn.Text = "Add Credit";
            this.AddCreditBtn.Click += new System.EventHandler(this.AddCreditBtn_Click);
            // 
            // subcode
            // 
            this.subcode.HeaderText = "Subs Code";
            this.subcode.Name = "subcode";
            this.subcode.ReadOnly = true;
            this.subcode.Visible = false;
            // 
            // fname
            // 
            this.fname.HeaderText = "First Name";
            this.fname.Name = "fname";
            this.fname.ReadOnly = true;
            this.fname.Visible = false;
            // 
            // lname
            // 
            this.lname.HeaderText = "Last Name";
            this.lname.Name = "lname";
            this.lname.ReadOnly = true;
            this.lname.Visible = false;
            // 
            // credit
            // 
            this.credit.HeaderText = "Credit";
            this.credit.Name = "credit";
            this.credit.ReadOnly = true;
            this.credit.Visible = false;
            // 
            // ccnumber
            // 
            this.ccnumber.HeaderText = "Credit Card Number";
            this.ccnumber.Name = "ccnumber";
            this.ccnumber.ReadOnly = true;
            this.ccnumber.Visible = false;
            // 
            // ManageSub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(866, 540);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.SubsTable);
            this.Name = "ManageSub";
            this.Text = "Subscribers";
            ((System.ComponentModel.ISupportInitialize)(this.SubsTable)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView SubsTable;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton AddSubBtn;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton EditBtn;
        private System.Windows.Forms.ToolStripButton AddCreditBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn lname;
        private System.Windows.Forms.DataGridViewTextBoxColumn credit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccnumber;
    }
}