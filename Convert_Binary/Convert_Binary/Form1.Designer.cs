using System.Windows.Forms;

namespace Convert_Binary
{
   partial class Form1 : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TBinary = new System.Windows.Forms.TextBox();
            this.Text0 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Error1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Mode = new System.Windows.Forms.ComboBox();
            this.Copy_t = new System.Windows.Forms.Button();
            this.Copy_b = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TimerLoad = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Error1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TBinary
            // 
            this.TBinary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBinary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBinary.Location = new System.Drawing.Point(625, 76);
            this.TBinary.Multiline = true;
            this.TBinary.Name = "TBinary";
            this.TBinary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TBinary.Size = new System.Drawing.Size(494, 463);
            this.TBinary.TabIndex = 1;
            this.TBinary.TextChanged += new System.EventHandler(this.TBinary_TextChanged);
            this.TBinary.Enter += new System.EventHandler(this.TBinary_Enter);
            this.TBinary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBinary_KeyPress);
            this.TBinary.Leave += new System.EventHandler(this.TBinary_Leave);
            // 
            // Text0
            // 
            this.Text0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text0.Location = new System.Drawing.Point(57, 76);
            this.Text0.Multiline = true;
            this.Text0.Name = "Text0";
            this.Text0.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Text0.Size = new System.Drawing.Size(494, 463);
            this.Text0.TabIndex = 0;
            this.Text0.TextChanged += new System.EventHandler(this.Text0_TextChanged);
            this.Text0.Enter += new System.EventHandler(this.Text0_Enter);
            this.Text0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text0_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Text";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(841, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Binary";
            // 
            // Error1
            // 
            this.Error1.ContainerControl = this;
            this.Error1.Icon = ((System.Drawing.Icon)(resources.GetObject("Error1.Icon")));
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Mode
            // 
            this.Mode.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Mode.DropDownHeight = 145;
            this.Mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Mode.DropDownWidth = 132;
            this.Mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mode.FormattingEnabled = true;
            this.Mode.IntegralHeight = false;
            this.Mode.Items.AddRange(new object[] {
            "String",
            "Int 8 bit",
            "Int 16 bit",
            "Int 32 bit",
            "Int 64 bit",
            "UInt 8 bit",
            "UInt 16 bit",
            "UInt 32 bit",
            "UInt 64 bit"});
            this.Mode.Location = new System.Drawing.Point(496, 570);
            this.Mode.Name = "Mode";
            this.Mode.Size = new System.Drawing.Size(172, 26);
            this.Mode.TabIndex = 2;
            this.Mode.SelectedIndexChanged += new System.EventHandler(this.Mode_SelectedIndexChanged);
            // 
            // Copy_t
            // 
            this.Copy_t.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Copy_t.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Copy_t.Location = new System.Drawing.Point(235, 555);
            this.Copy_t.Name = "Copy_t";
            this.Copy_t.Size = new System.Drawing.Size(134, 43);
            this.Copy_t.TabIndex = 3;
            this.Copy_t.Text = "Copy text";
            this.Copy_t.UseVisualStyleBackColor = true;
            this.Copy_t.Click += new System.EventHandler(this.Copy_t_Click);
            // 
            // Copy_b
            // 
            this.Copy_b.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Copy_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Copy_b.Location = new System.Drawing.Point(804, 553);
            this.Copy_b.Name = "Copy_b";
            this.Copy_b.Size = new System.Drawing.Size(134, 43);
            this.Copy_b.TabIndex = 3;
            this.Copy_b.Text = "Copy binary";
            this.Copy_b.UseVisualStyleBackColor = true;
            this.Copy_b.Click += new System.EventHandler(this.Copy_b_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1170, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.loadSettingToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.saveToolStripMenuItem.Text = "Save Setting";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadSettingToolStripMenuItem
            // 
            this.loadSettingToolStripMenuItem.Name = "loadSettingToolStripMenuItem";
            this.loadSettingToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.loadSettingToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.loadSettingToolStripMenuItem.Text = "Load Setting";
            this.loadSettingToolStripMenuItem.Click += new System.EventHandler(this.loadSettingToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(225, 26);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // TimerLoad
            // 
            this.TimerLoad.Interval = 1500;
            this.TimerLoad.Tick += new System.EventHandler(this.TimerLoad_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 661);
            this.Controls.Add(this.Copy_b);
            this.Controls.Add(this.Copy_t);
            this.Controls.Add(this.Mode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Text0);
            this.Controls.Add(this.TBinary);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convert_Binary";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Error1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.ErrorProvider Error1;
      private System.Windows.Forms.Timer timer1;
      private System.Windows.Forms.ComboBox Mode;
      public System.Windows.Forms.TextBox TBinary;
      public System.Windows.Forms.TextBox Text0;
      public System.Windows.Forms.Button Copy_b;
      private System.Windows.Forms.Button Copy_t;
      private System.Windows.Forms.MenuStrip menuStrip1;
      private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem loadSettingToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private Timer TimerLoad;
    }
}

