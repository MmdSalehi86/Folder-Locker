namespace Folder.Lock
{
    partial class UnLockFolder
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
            this.button1 = new System.Windows.Forms.Button();
            this.tpassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.progLoad = new System.Windows.Forms.ProgressBar();
            this.errortimer = new System.Windows.Forms.Timer(this.components);
            this.Loadtimer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("IRNazanin", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(245, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 52);
            this.button1.TabIndex = 6;
            this.button1.Text = "ادامه";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tpassword
            // 
            this.tpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpassword.Location = new System.Drawing.Point(174, 118);
            this.tpassword.MaxLength = 10;
            this.tpassword.Name = "tpassword";
            this.tpassword.ReadOnly = true;
            this.tpassword.Size = new System.Drawing.Size(283, 28);
            this.tpassword.TabIndex = 5;
            this.tpassword.UseSystemPasswordChar = true;
            this.tpassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tpassword_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("IRNazanin", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 34);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(122, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "بررسی اطلاعات ...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic1
            // 
            this.pic1.Image = global::Folder.Lock.Properties.Resources.show;
            this.pic1.Location = new System.Drawing.Point(140, 118);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(30, 28);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic1.TabIndex = 7;
            this.pic1.TabStop = false;
            this.pic1.Click += new System.EventHandler(this.pic1_Click);
            // 
            // progLoad
            // 
            this.progLoad.Location = new System.Drawing.Point(77, 230);
            this.progLoad.MarqueeAnimationSpeed = 20;
            this.progLoad.Name = "progLoad";
            this.progLoad.Size = new System.Drawing.Size(453, 23);
            this.progLoad.TabIndex = 8;
            // 
            // errortimer
            // 
            this.errortimer.Interval = 2000;
            this.errortimer.Tick += new System.EventHandler(this.errortimer_Tick);
            // 
            // Loadtimer
            // 
            this.Loadtimer.Interval = 1000;
            this.Loadtimer.Tick += new System.EventHandler(this.Loadtimer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("IRNazanin", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(145, 20);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(312, 84);
            this.label2.TabIndex = 4;
            this.label2.Text = "رمز پوشه را وارد کنید\r\nفقط می توانید کاراکتر عددی وارد کنید.\r\nاگر پوشه بدون رمز ا" +
    "ست، باکس متن را خالی بگذارید";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // UnLockFolder
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 289);
            this.Controls.Add(this.progLoad);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tpassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UnLockFolder";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UnLockFolder";
            this.Load += new System.EventHandler(this.UnLockFolder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tpassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progLoad;
        private System.Windows.Forms.Timer errortimer;
        private System.Windows.Forms.Timer Loadtimer;
        private System.Windows.Forms.Label label2;
    }
}