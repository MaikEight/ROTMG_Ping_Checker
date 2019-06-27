namespace ROTMG_Ping_Checker
{
    partial class MainForm
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelSide = new System.Windows.Forms.Panel();
            this.btnDescription = new System.Windows.Forms.PictureBox();
            this.btnAbout = new System.Windows.Forms.PictureBox();
            this.btnPing = new System.Windows.Forms.PictureBox();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panelTopLine = new System.Windows.Forms.Panel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.panelSideTop = new System.Windows.Forms.Panel();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.ltopTextSmall = new System.Windows.Forms.Label();
            this.lTopText = new System.Windows.Forms.Label();
            this.lHeader = new System.Windows.Forms.Label();
            this.pbMinimize = new System.Windows.Forms.PictureBox();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.bunifuDragControlTopLine = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControlLogo = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelSideText = new System.Windows.Forms.Panel();
            this.panelAbout = new System.Windows.Forms.Panel();
            this.lAbout = new System.Windows.Forms.Label();
            this.panelPing = new System.Windows.Forms.Panel();
            this.lPing = new System.Windows.Forms.Label();
            this.bunifuElipseMainform = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControlPbLogo = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControllHeader = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControlPanelTop = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControlPanelToptext = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControlTopTextSmall = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAbout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPing)).BeginInit();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panelTopLine.SuspendLayout();
            this.panelSideTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.panelMain.SuspendLayout();
            this.panelSideText.SuspendLayout();
            this.panelAbout.SuspendLayout();
            this.panelPing.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(85)))), ((int)(((byte)(100)))));
            this.panelSide.Controls.Add(this.btnDescription);
            this.panelSide.Controls.Add(this.btnAbout);
            this.panelSide.Controls.Add(this.btnPing);
            this.panelSide.Controls.Add(this.panelLogo);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 0);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(64, 525);
            this.panelSide.TabIndex = 0;
            // 
            // btnDescription
            // 
            this.btnDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDescription.Image = global::ROTMG_Ping_Checker.Properties.Resources.UI_Icon_ToggleNext;
            this.btnDescription.Location = new System.Drawing.Point(0, 193);
            this.btnDescription.Name = "btnDescription";
            this.btnDescription.Size = new System.Drawing.Size(64, 64);
            this.btnDescription.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDescription.TabIndex = 9;
            this.btnDescription.TabStop = false;
            this.btnDescription.Click += new System.EventHandler(this.PbDescription_Click);
            this.btnDescription.MouseEnter += new System.EventHandler(this.PBButtons_MouseEnter);
            this.btnDescription.MouseLeave += new System.EventHandler(this.PBButtons_MouseLeave);
            // 
            // btnAbout
            // 
            this.btnAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbout.Image = global::ROTMG_Ping_Checker.Properties.Resources.UI_Icon_Info;
            this.btnAbout.Location = new System.Drawing.Point(0, 129);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(64, 64);
            this.btnAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAbout.TabIndex = 8;
            this.btnAbout.TabStop = false;
            this.btnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            this.btnAbout.MouseEnter += new System.EventHandler(this.PBButtons_MouseEnter);
            this.btnAbout.MouseLeave += new System.EventHandler(this.PBButtons_MouseLeave);
            // 
            // btnPing
            // 
            this.btnPing.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPing.Image = global::ROTMG_Ping_Checker.Properties.Resources.UI_Icon_Hierarchy;
            this.btnPing.Location = new System.Drawing.Point(0, 65);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(64, 64);
            this.btnPing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPing.TabIndex = 7;
            this.btnPing.TabStop = false;
            this.btnPing.Click += new System.EventHandler(this.BtnPing_Click);
            this.btnPing.MouseEnter += new System.EventHandler(this.PBButtons_MouseEnter);
            this.btnPing.MouseLeave += new System.EventHandler(this.PBButtons_MouseLeave);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.panelLogo.Controls.Add(this.bunifuSeparator3);
            this.panelLogo.Controls.Add(this.pbLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(64, 65);
            this.panelLogo.TabIndex = 0;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(0, 64);
            this.bunifuSeparator3.Margin = new System.Windows.Forms.Padding(6540, 891, 6540, 891);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(64, 1);
            this.bunifuSeparator3.TabIndex = 14;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = false;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::ROTMG_Ping_Checker.Properties.Resources.UI_Icon_Globe;
            this.pbLogo.Location = new System.Drawing.Point(0, 1);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(64, 64);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // panelTopLine
            // 
            this.panelTopLine.Controls.Add(this.bunifuSeparator1);
            this.panelTopLine.Controls.Add(this.panelSideTop);
            this.panelTopLine.Controls.Add(this.lHeader);
            this.panelTopLine.Controls.Add(this.pbMinimize);
            this.panelTopLine.Controls.Add(this.pbClose);
            this.panelTopLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopLine.Location = new System.Drawing.Point(64, 0);
            this.panelTopLine.Name = "panelTopLine";
            this.panelTopLine.Size = new System.Drawing.Size(630, 65);
            this.panelTopLine.TabIndex = 1;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(111, 64);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(3679, 588, 3679, 588);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(519, 1);
            this.bunifuSeparator1.TabIndex = 9;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // panelSideTop
            // 
            this.panelSideTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.panelSideTop.Controls.Add(this.bunifuSeparator2);
            this.panelSideTop.Controls.Add(this.ltopTextSmall);
            this.panelSideTop.Controls.Add(this.lTopText);
            this.panelSideTop.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideTop.Location = new System.Drawing.Point(0, 0);
            this.panelSideTop.Name = "panelSideTop";
            this.panelSideTop.Size = new System.Drawing.Size(111, 65);
            this.panelSideTop.TabIndex = 12;
            this.panelSideTop.Visible = false;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(0, 64);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(4905, 724, 4905, 724);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(111, 1);
            this.bunifuSeparator2.TabIndex = 13;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // ltopTextSmall
            // 
            this.ltopTextSmall.AutoSize = true;
            this.ltopTextSmall.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltopTextSmall.ForeColor = System.Drawing.Color.White;
            this.ltopTextSmall.Location = new System.Drawing.Point(9, 10);
            this.ltopTextSmall.Name = "ltopTextSmall";
            this.ltopTextSmall.Size = new System.Drawing.Size(21, 16);
            this.ltopTextSmall.TabIndex = 10;
            this.ltopTextSmall.Text = "by";
            // 
            // lTopText
            // 
            this.lTopText.AutoSize = true;
            this.lTopText.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTopText.ForeColor = System.Drawing.Color.White;
            this.lTopText.Location = new System.Drawing.Point(27, 26);
            this.lTopText.Name = "lTopText";
            this.lTopText.Size = new System.Drawing.Size(75, 25);
            this.lTopText.TabIndex = 9;
            this.lTopText.Text = "Maik8";
            // 
            // lHeader
            // 
            this.lHeader.AutoSize = true;
            this.lHeader.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHeader.Location = new System.Drawing.Point(22, 26);
            this.lHeader.Name = "lHeader";
            this.lHeader.Size = new System.Drawing.Size(230, 25);
            this.lHeader.TabIndex = 8;
            this.lHeader.Text = "ROTMG Ping Checker";
            // 
            // pbMinimize
            // 
            this.pbMinimize.BackColor = System.Drawing.Color.Transparent;
            this.pbMinimize.Image = global::ROTMG_Ping_Checker.Properties.Resources.iconMinimize;
            this.pbMinimize.Location = new System.Drawing.Point(570, 0);
            this.pbMinimize.Name = "pbMinimize";
            this.pbMinimize.Size = new System.Drawing.Size(30, 30);
            this.pbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMinimize.TabIndex = 7;
            this.pbMinimize.TabStop = false;
            this.pbMinimize.Click += new System.EventHandler(this.PbMinimize_Click);
            this.pbMinimize.MouseEnter += new System.EventHandler(this.pbMinimize_MouseEnter);
            this.pbMinimize.MouseLeave += new System.EventHandler(this.pbMinimize_MouseLeave);
            // 
            // pbClose
            // 
            this.pbClose.BackColor = System.Drawing.Color.Transparent;
            this.pbClose.Image = global::ROTMG_Ping_Checker.Properties.Resources.iconClose;
            this.pbClose.Location = new System.Drawing.Point(600, 0);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(30, 30);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 6;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.PbClose_Click);
            this.pbClose.MouseEnter += new System.EventHandler(this.PbClose_MouseEnter);
            this.pbClose.MouseLeave += new System.EventHandler(this.PbClose_MouseLeave);
            // 
            // bunifuDragControlTopLine
            // 
            this.bunifuDragControlTopLine.Fixed = true;
            this.bunifuDragControlTopLine.Horizontal = true;
            this.bunifuDragControlTopLine.TargetControl = this.panelTopLine;
            this.bunifuDragControlTopLine.Vertical = true;
            // 
            // bunifuDragControlLogo
            // 
            this.bunifuDragControlLogo.Fixed = true;
            this.bunifuDragControlLogo.Horizontal = true;
            this.bunifuDragControlLogo.TargetControl = this.panelLogo;
            this.bunifuDragControlLogo.Vertical = true;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelSideText);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(64, 65);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(630, 460);
            this.panelMain.TabIndex = 2;
            // 
            // panelSideText
            // 
            this.panelSideText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(85)))), ((int)(((byte)(100)))));
            this.panelSideText.Controls.Add(this.panelAbout);
            this.panelSideText.Controls.Add(this.panelPing);
            this.panelSideText.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideText.Location = new System.Drawing.Point(0, 0);
            this.panelSideText.Name = "panelSideText";
            this.panelSideText.Size = new System.Drawing.Size(111, 460);
            this.panelSideText.TabIndex = 6;
            this.panelSideText.Visible = false;
            // 
            // panelAbout
            // 
            this.panelAbout.Controls.Add(this.lAbout);
            this.panelAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAbout.Location = new System.Drawing.Point(0, 64);
            this.panelAbout.Name = "panelAbout";
            this.panelAbout.Size = new System.Drawing.Size(111, 64);
            this.panelAbout.TabIndex = 14;
            this.panelAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            this.panelAbout.MouseEnter += new System.EventHandler(this.PanelButtons_MouseEnter);
            this.panelAbout.MouseLeave += new System.EventHandler(this.PanelButtons_MouseLeave);
            // 
            // lAbout
            // 
            this.lAbout.AutoSize = true;
            this.lAbout.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAbout.ForeColor = System.Drawing.Color.White;
            this.lAbout.Location = new System.Drawing.Point(10, 23);
            this.lAbout.Name = "lAbout";
            this.lAbout.Size = new System.Drawing.Size(76, 25);
            this.lAbout.TabIndex = 12;
            this.lAbout.Text = "About";
            this.lAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            this.lAbout.MouseEnter += new System.EventHandler(this.LabelButtons_MouseEnter);
            this.lAbout.MouseLeave += new System.EventHandler(this.LabelButtons_MouseLeave);
            // 
            // panelPing
            // 
            this.panelPing.Controls.Add(this.lPing);
            this.panelPing.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPing.Location = new System.Drawing.Point(0, 0);
            this.panelPing.Name = "panelPing";
            this.panelPing.Size = new System.Drawing.Size(111, 64);
            this.panelPing.TabIndex = 13;
            this.panelPing.Click += new System.EventHandler(this.BtnPing_Click);
            this.panelPing.MouseEnter += new System.EventHandler(this.PanelButtons_MouseEnter);
            this.panelPing.MouseLeave += new System.EventHandler(this.PanelButtons_MouseLeave);
            // 
            // lPing
            // 
            this.lPing.AutoSize = true;
            this.lPing.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPing.ForeColor = System.Drawing.Color.White;
            this.lPing.Location = new System.Drawing.Point(7, 22);
            this.lPing.Name = "lPing";
            this.lPing.Size = new System.Drawing.Size(61, 25);
            this.lPing.TabIndex = 13;
            this.lPing.Text = "Ping";
            this.lPing.Click += new System.EventHandler(this.BtnPing_Click);
            this.lPing.MouseEnter += new System.EventHandler(this.LabelButtons_MouseEnter);
            this.lPing.MouseLeave += new System.EventHandler(this.LabelButtons_MouseLeave);
            // 
            // bunifuElipseMainform
            // 
            this.bunifuElipseMainform.ElipseRadius = 11;
            this.bunifuElipseMainform.TargetControl = this;
            // 
            // bunifuDragControlPbLogo
            // 
            this.bunifuDragControlPbLogo.Fixed = true;
            this.bunifuDragControlPbLogo.Horizontal = true;
            this.bunifuDragControlPbLogo.TargetControl = this.pbLogo;
            this.bunifuDragControlPbLogo.Vertical = true;
            // 
            // bunifuDragControllHeader
            // 
            this.bunifuDragControllHeader.Fixed = true;
            this.bunifuDragControllHeader.Horizontal = true;
            this.bunifuDragControllHeader.TargetControl = this.lHeader;
            this.bunifuDragControllHeader.Vertical = true;
            // 
            // bunifuDragControlPanelTop
            // 
            this.bunifuDragControlPanelTop.Fixed = true;
            this.bunifuDragControlPanelTop.Horizontal = true;
            this.bunifuDragControlPanelTop.TargetControl = this.panelSideTop;
            this.bunifuDragControlPanelTop.Vertical = true;
            // 
            // bunifuDragControlPanelToptext
            // 
            this.bunifuDragControlPanelToptext.Fixed = true;
            this.bunifuDragControlPanelToptext.Horizontal = true;
            this.bunifuDragControlPanelToptext.TargetControl = this.lTopText;
            this.bunifuDragControlPanelToptext.Vertical = true;
            // 
            // bunifuDragControlTopTextSmall
            // 
            this.bunifuDragControlTopTextSmall.Fixed = true;
            this.bunifuDragControlTopTextSmall.Horizontal = true;
            this.bunifuDragControlTopTextSmall.TargetControl = this.ltopTextSmall;
            this.bunifuDragControlTopTextSmall.Vertical = true;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(694, 525);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTopLine);
            this.Controls.Add(this.panelSide);
            this.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Form1";
            this.panelSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAbout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPing)).EndInit();
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panelTopLine.ResumeLayout(false);
            this.panelTopLine.PerformLayout();
            this.panelSideTop.ResumeLayout(false);
            this.panelSideTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelSideText.ResumeLayout(false);
            this.panelAbout.ResumeLayout(false);
            this.panelAbout.PerformLayout();
            this.panelPing.ResumeLayout(false);
            this.panelPing.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Panel panelTopLine;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pbMinimize;
        private System.Windows.Forms.PictureBox pbClose;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControlTopLine;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControlLogo;
        private System.Windows.Forms.Label lHeader;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel panelMain;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipseMainform;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.PictureBox btnAbout;
        private System.Windows.Forms.PictureBox btnPing;
        private System.Windows.Forms.Panel panelSideTop;
        private System.Windows.Forms.Label ltopTextSmall;
        private System.Windows.Forms.Label lTopText;
        private System.Windows.Forms.Panel panelSideText;
        private System.Windows.Forms.Panel panelAbout;
        private System.Windows.Forms.Label lAbout;
        private System.Windows.Forms.Panel panelPing;
        private System.Windows.Forms.Label lPing;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.PictureBox btnDescription;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControlPbLogo;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControllHeader;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControlPanelTop;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControlPanelToptext;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControlTopTextSmall;
    }
}

