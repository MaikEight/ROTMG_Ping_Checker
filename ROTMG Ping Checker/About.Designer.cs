namespace ROTMG_Ping_Checker
{
    partial class About
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lDev = new System.Windows.Forms.Label();
            this.lDevName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timerIdea = new System.Windows.Forms.Timer(this.components);
            this.timerRestore = new System.Windows.Forms.Timer(this.components);
            this.timerLama = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.lversionNumber = new System.Windows.Forms.Label();
            this.lVersionText = new System.Windows.Forms.Label();
            this.pbLama = new System.Windows.Forms.PictureBox();
            this.pbGlobe = new System.Windows.Forms.PictureBox();
            this.pbDevIcon = new System.Windows.Forms.PictureBox();
            this.pbIdeaIcon = new System.Windows.Forms.PictureBox();
            this.pbVersion = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGlobe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDevIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIdeaIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVersion)).BeginInit();
            this.SuspendLayout();
            // 
            // lDev
            // 
            this.lDev.AutoSize = true;
            this.lDev.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDev.Location = new System.Drawing.Point(160, 198);
            this.lDev.Name = "lDev";
            this.lDev.Size = new System.Drawing.Size(111, 25);
            this.lDev.TabIndex = 0;
            this.lDev.Text = "Developer";
            // 
            // lDevName
            // 
            this.lDevName.AutoSize = true;
            this.lDevName.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDevName.Location = new System.Drawing.Point(296, 198);
            this.lDevName.Name = "lDevName";
            this.lDevName.Size = new System.Drawing.Size(220, 25);
            this.lDevName.TabIndex = 2;
            this.lDevName.Text = "Maik \"Maik8\" Kühne";
            this.lDevName.Click += new System.EventHandler(this.LDevName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "ROTMG Ping Checker";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(214, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 5;
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(296, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "ruusey";
            this.label3.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(160, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Idea from";
            // 
            // timerIdea
            // 
            this.timerIdea.Interval = 1000;
            this.timerIdea.Tick += new System.EventHandler(this.TimerIdea_Tick);
            // 
            // timerRestore
            // 
            this.timerRestore.Interval = 1000;
            this.timerRestore.Tick += new System.EventHandler(this.TimerRestore_Tick);
            // 
            // timerLama
            // 
            this.timerLama.Interval = 8000;
            this.timerLama.Tick += new System.EventHandler(this.TimerLama_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(369, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "- Thanks for the idea";
            // 
            // lversionNumber
            // 
            this.lversionNumber.AutoSize = true;
            this.lversionNumber.BackColor = System.Drawing.Color.Transparent;
            this.lversionNumber.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lversionNumber.Location = new System.Drawing.Point(296, 34);
            this.lversionNumber.Name = "lversionNumber";
            this.lversionNumber.Size = new System.Drawing.Size(60, 25);
            this.lversionNumber.TabIndex = 13;
            this.lversionNumber.Text = "1.0.4";
            // 
            // lVersionText
            // 
            this.lVersionText.AutoSize = true;
            this.lVersionText.BackColor = System.Drawing.Color.Transparent;
            this.lVersionText.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lVersionText.Location = new System.Drawing.Point(160, 34);
            this.lVersionText.Name = "lVersionText";
            this.lVersionText.Size = new System.Drawing.Size(88, 25);
            this.lVersionText.TabIndex = 11;
            this.lVersionText.Text = "Version";
            // 
            // pbLama
            // 
            this.pbLama.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbLama.Image = global::ROTMG_Ping_Checker.Properties.Resources.lamaWalk;
            this.pbLama.Location = new System.Drawing.Point(0, 356);
            this.pbLama.Name = "pbLama";
            this.pbLama.Size = new System.Drawing.Size(630, 104);
            this.pbLama.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLama.TabIndex = 9;
            this.pbLama.TabStop = false;
            // 
            // pbGlobe
            // 
            this.pbGlobe.Image = global::ROTMG_Ping_Checker.Properties.Resources.UI_Icon_Globe_dark;
            this.pbGlobe.Location = new System.Drawing.Point(20, 20);
            this.pbGlobe.Name = "pbGlobe";
            this.pbGlobe.Size = new System.Drawing.Size(128, 128);
            this.pbGlobe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGlobe.TabIndex = 3;
            this.pbGlobe.TabStop = false;
            this.pbGlobe.Click += new System.EventHandler(this.PbGlobe_Click);
            // 
            // pbDevIcon
            // 
            this.pbDevIcon.Image = global::ROTMG_Ping_Checker.Properties.Resources.UI_Icon_Code_Dark;
            this.pbDevIcon.Location = new System.Drawing.Point(84, 178);
            this.pbDevIcon.Name = "pbDevIcon";
            this.pbDevIcon.Size = new System.Drawing.Size(64, 64);
            this.pbDevIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDevIcon.TabIndex = 1;
            this.pbDevIcon.TabStop = false;
            this.pbDevIcon.Click += new System.EventHandler(this.PbDevIcon_Click);
            // 
            // pbIdeaIcon
            // 
            this.pbIdeaIcon.Image = global::ROTMG_Ping_Checker.Properties.Resources.UI_Icon_LightbulbOn_Dark;
            this.pbIdeaIcon.Location = new System.Drawing.Point(84, 272);
            this.pbIdeaIcon.Name = "pbIdeaIcon";
            this.pbIdeaIcon.Size = new System.Drawing.Size(64, 64);
            this.pbIdeaIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIdeaIcon.TabIndex = 6;
            this.pbIdeaIcon.TabStop = false;
            // 
            // pbVersion
            // 
            this.pbVersion.BackColor = System.Drawing.Color.Transparent;
            this.pbVersion.Image = global::ROTMG_Ping_Checker.Properties.Resources.UI_Icon_Hashtag_Dark;
            this.pbVersion.Location = new System.Drawing.Point(84, 14);
            this.pbVersion.Name = "pbVersion";
            this.pbVersion.Size = new System.Drawing.Size(64, 64);
            this.pbVersion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVersion.TabIndex = 12;
            this.pbVersion.TabStop = false;
            // 
            // About
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbGlobe);
            this.Controls.Add(this.lDevName);
            this.Controls.Add(this.pbDevIcon);
            this.Controls.Add(this.lDev);
            this.Controls.Add(this.pbIdeaIcon);
            this.Controls.Add(this.lversionNumber);
            this.Controls.Add(this.pbVersion);
            this.Controls.Add(this.lVersionText);
            this.Controls.Add(this.pbLama);
            this.Font = new System.Drawing.Font("Century", 9.75F);
            this.Name = "About";
            this.Size = new System.Drawing.Size(630, 460);
            ((System.ComponentModel.ISupportInitialize)(this.pbLama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGlobe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDevIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIdeaIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVersion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lDev;
        private System.Windows.Forms.PictureBox pbDevIcon;
        private System.Windows.Forms.Label lDevName;
        private System.Windows.Forms.PictureBox pbGlobe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbIdeaIcon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timerIdea;
        private System.Windows.Forms.PictureBox pbLama;
        private System.Windows.Forms.Timer timerRestore;
        private System.Windows.Forms.Timer timerLama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lversionNumber;
        private System.Windows.Forms.Label lVersionText;
        private System.Windows.Forms.PictureBox pbVersion;
    }
}
