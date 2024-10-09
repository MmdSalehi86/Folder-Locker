namespace Folder.Lock
{
    partial class ListLockFolder
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
            this.components = new System.ComponentModel.Container();
            this.listFolder = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loading = new System.Windows.Forms.ProgressBar();
            this.tLoad = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // listFolder
            // 
            this.listFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.listFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listFolder.FormattingEnabled = true;
            this.listFolder.HorizontalScrollbar = true;
            this.listFolder.ItemHeight = 20;
            this.listFolder.Location = new System.Drawing.Point(36, 121);
            this.listFolder.Name = "listFolder";
            this.listFolder.Size = new System.Drawing.Size(525, 244);
            this.listFolder.TabIndex = 0;
            this.listFolder.DoubleClick += new System.EventHandler(this.listFolder_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("IRNazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 23);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(0, 31);
            this.label1.TabIndex = 5;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loading
            // 
            this.loading.Location = new System.Drawing.Point(36, 70);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(525, 23);
            this.loading.TabIndex = 6;
            // 
            // tLoad
            // 
            this.tLoad.Interval = 600;
            this.tLoad.Tick += new System.EventHandler(this.tLoad_Tick);
            // 
            // ListLockFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 403);
            this.Controls.Add(this.loading);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listFolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListLockFolder";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "List of locked folders";
            this.Load += new System.EventHandler(this.ListLockFolder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar loading;
        private System.Windows.Forms.Timer tLoad;
    }
}