﻿namespace MxBots
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.xC_fun1 = new MxBots.Panels_de_configuration.ClassesCustomSettings.XC_fun();
            this.xC_CommonBinds1 = new MxBots.Panels_de_configuration.XC_CommonBinds();
            this.xC_CustomConsole1 = new MxBots.Panels_de_configuration.XC_CustomConsole();
            this.xC_XbConfig1 = new MxBots.XC_XbConfig();
            this.xC_GlobalBotSettings1 = new MxBots.XC_GlobalBotSettings();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.combatSettings1 = new MxBots.CombatSettings();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.hotkeymanager1 = new MxBots.hotkeymanager();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(181, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(78, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(163, 732);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(487, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Go!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(110, 314);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(585, 348);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.RoyalBlue;
            this.tabPage1.BackgroundImage = global::MxBots.Properties.Resources.Sans_titre_24;
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.comboBox2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(577, 319);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bot Config";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(201, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Routine : None Selected";
            this.label6.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(331, 249);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Change";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(201, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "NEW FEATURES ARE COMMING SOON";
            this.label5.Visible = false;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Classic",
            "Semi-Automated",
            "MultiBot",
            "Battleground Farming",
            "//XPlayBack Mode",
            "//Instance Farming"});
            this.comboBox2.Location = new System.Drawing.Point(379, 22);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(131, 21);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(310, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "XBot Mode:";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.splitContainer1);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(577, 319);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "XBot Settings";
            this.tabPage5.UseVisualStyleBackColor = true;
            this.tabPage5.Click += new System.EventHandler(this.tabPage5_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel1.Controls.Add(this.listBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.xC_fun1);
            this.splitContainer1.Panel2.Controls.Add(this.xC_CommonBinds1);
            this.splitContainer1.Panel2.Controls.Add(this.xC_CustomConsole1);
            this.splitContainer1.Panel2.Controls.Add(this.xC_XbConfig1);
            this.splitContainer1.Panel2.Controls.Add(this.xC_GlobalBotSettings1);
            this.splitContainer1.Size = new System.Drawing.Size(571, 313);
            this.splitContainer1.SplitterDistance = 173;
            this.splitContainer1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Control;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.ForeColor = System.Drawing.Color.Black;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "XBot Application Settings",
            "Global Bots Settings",
            "Console Customisation",
            "Fun Stuff",
            "General Binds"});
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(173, 312);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // xC_fun1
            // 
            this.xC_fun1.Location = new System.Drawing.Point(4, 4);
            this.xC_fun1.Name = "xC_fun1";
            this.xC_fun1.Size = new System.Drawing.Size(398, 316);
            this.xC_fun1.TabIndex = 4;
            this.xC_fun1.Visible = false;
            // 
            // xC_CommonBinds1
            // 
            this.xC_CommonBinds1.BackColor = System.Drawing.SystemColors.Control;
            this.xC_CommonBinds1.Location = new System.Drawing.Point(3, 4);
            this.xC_CommonBinds1.Name = "xC_CommonBinds1";
            this.xC_CommonBinds1.Size = new System.Drawing.Size(398, 316);
            this.xC_CommonBinds1.TabIndex = 3;
            // 
            // xC_CustomConsole1
            // 
            this.xC_CustomConsole1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xC_CustomConsole1.Location = new System.Drawing.Point(0, 0);
            this.xC_CustomConsole1.Name = "xC_CustomConsole1";
            this.xC_CustomConsole1.Size = new System.Drawing.Size(394, 313);
            this.xC_CustomConsole1.TabIndex = 2;
            this.xC_CustomConsole1.Visible = false;
            // 
            // xC_XbConfig1
            // 
            this.xC_XbConfig1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xC_XbConfig1.Location = new System.Drawing.Point(0, 0);
            this.xC_XbConfig1.Name = "xC_XbConfig1";
            this.xC_XbConfig1.Size = new System.Drawing.Size(394, 313);
            this.xC_XbConfig1.TabIndex = 1;
            this.xC_XbConfig1.Visible = false;
            // 
            // xC_GlobalBotSettings1
            // 
            this.xC_GlobalBotSettings1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xC_GlobalBotSettings1.Location = new System.Drawing.Point(0, 0);
            this.xC_GlobalBotSettings1.Name = "xC_GlobalBotSettings1";
            this.xC_GlobalBotSettings1.Size = new System.Drawing.Size(394, 313);
            this.xC_GlobalBotSettings1.TabIndex = 0;
            this.xC_GlobalBotSettings1.Visible = false;
            this.xC_GlobalBotSettings1.Load += new System.EventHandler(this.xC_GlobalBotSettings1_Load);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.combatSettings1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(577, 319);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Combat Settings";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // combatSettings1
            // 
            this.combatSettings1.BackColor = System.Drawing.Color.Black;
            this.combatSettings1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.combatSettings1.Location = new System.Drawing.Point(3, 3);
            this.combatSettings1.Name = "combatSettings1";
            this.combatSettings1.Size = new System.Drawing.Size(571, 313);
            this.combatSettings1.TabIndex = 0;
            this.combatSettings1.Load += new System.EventHandler(this.combatSettings1_Load);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage2.Controls.Add(this.hotkeymanager1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(577, 319);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "HotKey Manager";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // hotkeymanager1
            // 
            this.hotkeymanager1.BackColor = System.Drawing.Color.SteelBlue;
            this.hotkeymanager1.Location = new System.Drawing.Point(45, 26);
            this.hotkeymanager1.Name = "hotkeymanager1";
            this.hotkeymanager1.Size = new System.Drawing.Size(398, 265);
            this.hotkeymanager1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.pictureBox4);
            this.tabPage4.Controls.Add(this.pictureBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(577, 319);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "About";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(434, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "youmew91@hotmail.com";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(571, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thanks to : mmowned board and drari secteur polo casablanca pour leur bon shit de" +
                " chez hmidito";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::MxBots.Properties.Resources.cred;
            this.pictureBox4.Location = new System.Drawing.Point(50, 18);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(487, 194);
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(577, 319);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(610, 668);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(82, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Save";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::MxBots.Properties.Resources.XBot1;
            this.pictureBox2.Location = new System.Drawing.Point(12, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(790, 245);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseUp);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::MxBots.Properties.Resources.olol;
            this.pictureBox3.Location = new System.Drawing.Point(518, 242);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(200, 54);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(110, 668);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImage = global::MxBots.Properties.Resources.Abstract_Wallpapers_00109;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(803, 849);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MxBots";
            this.TransparencyKey = System.Drawing.Color.Green;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private hotkeymanager hotkeymanager1;
        private System.Windows.Forms.TabPage tabPage3;
        private CombatSettings combatSettings1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button5;
        private XC_GlobalBotSettings xC_GlobalBotSettings1;
        private XC_XbConfig xC_XbConfig1;
        private MxBots.Panels_de_configuration.XC_CustomConsole xC_CustomConsole1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private MxBots.Panels_de_configuration.XC_CommonBinds xC_CommonBinds1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private MxBots.Panels_de_configuration.ClassesCustomSettings.XC_fun xC_fun1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
      
    }
}

