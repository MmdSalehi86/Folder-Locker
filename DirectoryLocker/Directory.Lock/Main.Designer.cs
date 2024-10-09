namespace Folder.Lock
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnlock = new System.Windows.Forms.Button();
            this.btnunlock = new System.Windows.Forms.Button();
            this.Folder = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.بیشترToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.خروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnListFolder = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnlock
            // 
            this.btnlock.Font = new System.Drawing.Font("IRMehr", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlock.Location = new System.Drawing.Point(107, 81);
            this.btnlock.Name = "btnlock";
            this.btnlock.Size = new System.Drawing.Size(165, 44);
            this.btnlock.TabIndex = 0;
            this.btnlock.Text = "قفل کردن پوشه";
            this.btnlock.UseVisualStyleBackColor = true;
            this.btnlock.Click += new System.EventHandler(this.btnlock_Click);
            // 
            // btnunlock
            // 
            this.btnunlock.Font = new System.Drawing.Font("IRMehr", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnunlock.Location = new System.Drawing.Point(107, 146);
            this.btnunlock.Name = "btnunlock";
            this.btnunlock.Size = new System.Drawing.Size(165, 44);
            this.btnunlock.TabIndex = 1;
            this.btnunlock.Text = "باز کردن پوشه";
            this.btnunlock.UseVisualStyleBackColor = true;
            this.btnunlock.Click += new System.EventHandler(this.btnunlock_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.بیشترToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(380, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // بیشترToolStripMenuItem
            // 
            this.بیشترToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem1,
            this.خروجToolStripMenuItem});
            this.بیشترToolStripMenuItem.Name = "بیشترToolStripMenuItem";
            this.بیشترToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.بیشترToolStripMenuItem.Text = "بیشتر";
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(241, 26);
            this.ToolStripMenuItem1.Text = "شرایط و ضوابط";
            this.ToolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem1_Click);
            // 
            // خروجToolStripMenuItem
            // 
            this.خروجToolStripMenuItem.Name = "خروجToolStripMenuItem";
            this.خروجToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.خروجToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.خروجToolStripMenuItem.Text = "خروج";
            this.خروجToolStripMenuItem.Click += new System.EventHandler(this.خروجToolStripMenuItem_Click);
            // 
            // btnListFolder
            // 
            this.btnListFolder.Font = new System.Drawing.Font("IRMehr", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListFolder.Location = new System.Drawing.Point(107, 211);
            this.btnListFolder.Name = "btnListFolder";
            this.btnListFolder.Size = new System.Drawing.Size(165, 44);
            this.btnListFolder.TabIndex = 2;
            this.btnListFolder.Text = "پوشه های قفل شده";
            this.btnListFolder.UseVisualStyleBackColor = true;
            this.btnListFolder.Click += new System.EventHandler(this.btnListFolder_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 327);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnlock);
            this.Controls.Add(this.btnListFolder);
            this.Controls.Add(this.btnunlock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lock ";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlock;
        private System.Windows.Forms.Button btnunlock;
        private System.Windows.Forms.FolderBrowserDialog Folder;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem بیشترToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem خروجToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem1;
        private System.Windows.Forms.Button btnListFolder;
    }
}

