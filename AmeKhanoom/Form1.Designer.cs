namespace AmeKhanoom
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.OrdersBtn = new System.Windows.Forms.ToolStripButton();
            this.DelorderBtn = new System.Windows.Forms.ToolStripButton();
            this.SubsBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.OlderOrderBtn = new System.Windows.Forms.ToolStripButton();
            this.SettingBtn = new System.Windows.Forms.ToolStripButton();
            this.ExitBtn = new System.Windows.Forms.ToolStripButton();
            this.DateLbl = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OrdersBtn,
            this.DelorderBtn,
            this.SubsBtn,
            this.toolStripButton3,
            this.OlderOrderBtn,
            this.SettingBtn,
            this.ExitBtn});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(866, 70);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // OrdersBtn
            // 
            this.OrdersBtn.AutoSize = false;
            this.OrdersBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OrdersBtn.Image = global::AmeKhanoom.Properties.Resources.file;
            this.OrdersBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.OrdersBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OrdersBtn.Name = "OrdersBtn";
            this.OrdersBtn.Size = new System.Drawing.Size(70, 70);
            this.OrdersBtn.Text = "Orders";
            this.OrdersBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.OrdersBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OrdersBtn.Click += new System.EventHandler(this.OrdersBtn_Click);
            // 
            // DelorderBtn
            // 
            this.DelorderBtn.AutoSize = false;
            this.DelorderBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DelorderBtn.Image = global::AmeKhanoom.Properties.Resources.file_1_;
            this.DelorderBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DelorderBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DelorderBtn.Name = "DelorderBtn";
            this.DelorderBtn.Size = new System.Drawing.Size(70, 70);
            this.DelorderBtn.Text = "Orders To Deliver";
            this.DelorderBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DelorderBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.DelorderBtn.Click += new System.EventHandler(this.DelorderBtn_Click);
            // 
            // SubsBtn
            // 
            this.SubsBtn.AutoSize = false;
            this.SubsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SubsBtn.Image = global::AmeKhanoom.Properties.Resources.user_1_;
            this.SubsBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SubsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SubsBtn.Name = "SubsBtn";
            this.SubsBtn.Size = new System.Drawing.Size(70, 70);
            this.SubsBtn.Text = "Subs";
            this.SubsBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SubsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SubsBtn.Click += new System.EventHandler(this.SubsBtn_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.AutoSize = false;
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::AmeKhanoom.Properties.Resources.diskette;
            this.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(70, 70);
            this.toolStripButton3.Text = "Report";
            this.toolStripButton3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // OlderOrderBtn
            // 
            this.OlderOrderBtn.AutoSize = false;
            this.OlderOrderBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OlderOrderBtn.Image = global::AmeKhanoom.Properties.Resources.monitor;
            this.OlderOrderBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.OlderOrderBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OlderOrderBtn.Name = "OlderOrderBtn";
            this.OlderOrderBtn.Size = new System.Drawing.Size(70, 70);
            this.OlderOrderBtn.Text = "Older Orders";
            this.OlderOrderBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.OlderOrderBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OlderOrderBtn.Click += new System.EventHandler(this.OlderOrderBtn_Click);
            // 
            // SettingBtn
            // 
            this.SettingBtn.AutoSize = false;
            this.SettingBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SettingBtn.Image = global::AmeKhanoom.Properties.Resources.settings_2_;
            this.SettingBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SettingBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SettingBtn.Name = "SettingBtn";
            this.SettingBtn.Size = new System.Drawing.Size(70, 70);
            this.SettingBtn.Text = "Setting";
            this.SettingBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SettingBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SettingBtn.Click += new System.EventHandler(this.SettingBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.AutoSize = false;
            this.ExitBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExitBtn.Image = global::AmeKhanoom.Properties.Resources.power_button;
            this.ExitBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ExitBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(70, 70);
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // DateLbl
            // 
            this.DateLbl.AutoSize = true;
            this.DateLbl.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLbl.Location = new System.Drawing.Point(12, 444);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(73, 24);
            this.DateLbl.TabIndex = 1;
            this.DateLbl.Text = "Date: ";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(866, 477);
            this.Controls.Add(this.DateLbl);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Ame Cookie";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton OrdersBtn;
        private System.Windows.Forms.ToolStripButton SubsBtn;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton SettingBtn;
        private System.Windows.Forms.ToolStripButton ExitBtn;
        private System.Windows.Forms.Label DateLbl;
        private System.Windows.Forms.ToolStripButton OlderOrderBtn;
        private System.Windows.Forms.ToolStripButton DelorderBtn;
    }
}

