namespace Folder.Lock
{
    partial class LockFolder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LockFolder));
            this.label1 = new System.Windows.Forms.Label();
            this.tpassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.errortimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("IRNazanin", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 26);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(376, 84);
            this.label1.TabIndex = 0;
            this.label1.Text = "رمزی برای پوشه خود انتخاب کنید.\r\nفقط می توانید کاراکتر عددی وارد کنید.\r\nاگر می خو" +
    "اهید پوشه بدون رمز باشد جعبه متن را خالی بگذارید";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tpassword
            // 
            this.tpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpassword.Location = new System.Drawing.Point(157, 128);
            this.tpassword.MaxLength = 10;
            this.tpassword.Name = "tpassword";
            this.tpassword.Size = new System.Drawing.Size(283, 28);
            this.tpassword.TabIndex = 1;
            this.tpassword.UseSystemPasswordChar = true;
            this.tpassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tpassword_KeyPress);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("IRNazanin", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(224, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 52);
            this.button1.TabIndex = 2;
            this.button1.Text = "ادامه";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pic1
            // 
            this.pic1.Image = ((System.Drawing.Image)(resources.GetObject("pic1.Image")));
            this.pic1.Location = new System.Drawing.Point(122, 128);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(30, 28);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic1.TabIndex = 3;
            this.pic1.TabStop = false;
            this.pic1.Click += new System.EventHandler(this.pic1_Click);
            // 
            // errortimer
            // 
            this.errortimer.Interval = 2000;
            this.errortimer.Tick += new System.EventHandler(this.errortimer_Tick);
            // 
            // LockFolder
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 265);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tpassword);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LockFolder";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LockFolder";
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tpassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.Timer errortimer;
    }
}