using BunifuAnimatorNS;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ROTMG_Ping_Checker
{
    public partial class MainForm : Form
    {
        Ping pingDash = null;
        About aboutDash = null;
        int currentDash = 0;
        public MainForm()
        {
            InitializeComponent();
            pingDash = new Ping();
            aboutDash = new About();
            BtnPing_Click(btnPing as object, null);
            
        }

        public void AddToMainPanel(Control toAdd)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(panelSideText);
            panelMain.Controls.Add(toAdd);
        }

        private void PbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PbClose_Click(object sender, EventArgs e)
        {            
            Environment.Exit(0);
        }

        private void pbMinimize_MouseEnter(object sender, EventArgs e)
        {
            pbMinimize.BackColor = Color.DarkGray;
        }

        private void pbMinimize_MouseLeave(object sender, EventArgs e)
        {
            pbMinimize.BackColor = panelTopLine.BackColor;
        }

        private void PbClose_MouseEnter(object sender, EventArgs e)
        {
            pbClose.BackColor = Color.IndianRed;
        }

        private void PbClose_MouseLeave(object sender, EventArgs e)
        {
            pbClose.BackColor = panelTopLine.BackColor;
        }               

        private void BtnPing_Click(object sender, EventArgs e)
        {
            ChangeColorClick(currentDash, 1);
            if (panelSideText.Visible)
            {
                TransitionThread(panelSideText, false);
                TransitionThread(panelSideTop, false);
                btnDescription.Image = Properties.Resources.UI_Icon_ToggleNext;
            }
            if (currentDash != 1)
            {
                AddToMainPanel(pingDash);
                aboutDash.ToggleTimerIdea(false);
                currentDash = 1;
            }
            
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            ChangeColorClick(currentDash, 2);
            if (panelSideText.Visible)
            {
                TransitionThread(panelSideText, false);
                TransitionThread(panelSideTop, false);
                btnDescription.Image = Properties.Resources.UI_Icon_ToggleNext;
            }
            if (currentDash != 2)
            {
                AddToMainPanel(aboutDash);
                aboutDash.ToggleTimerIdea(true);
                currentDash = 2;
            }            
        }

        private void BtnAbout_MouseEnter(object sender, EventArgs e)
        {
            btnAbout.BackColor = Color.FromArgb(56, 68, 80);
        }

        private void BtnAbout_MouseLeave(object sender, EventArgs e)
        {
            btnAbout.BackColor = Color.FromArgb(41, 53, 65);
        }
              

        private void PanelSideText_MouseEnter(object sender, EventArgs e)
        {
            panelSideText.Visible = true;
            panelSideTop.Visible = true;
        }

        private void PbDescription_Click(object sender, EventArgs e)
        {
            
            if (!panelSideText.Visible)
            {
                TransitionThread(panelSideText, true);
                TransitionThread(panelSideTop, true);                
                btnDescription.Image = Properties.Resources.UI_Icon_TogglePrevious;
            }
            else
            {
                TransitionThread(panelSideTop, false);
                TransitionThread(panelSideText, false);
                btnDescription.Image = Properties.Resources.UI_Icon_ToggleNext;
            }
        }

        private void TransitionThread(Panel panel, bool state)
        {
            BunifuTransition transition = new BunifuTransition();
            if (state)
                transition.Show(panel, false, Animation.HorizSlide);
            else
                transition.Hide(panel, false, Animation.HorizSlide);
        }

        private void PBButtons_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;


            if (!pb.Name.Substring(3, pb.Name.Length - 3).Equals(GetName(currentDash)))
            {
                Changecolor(pb.Name.Substring(3, pb.Name.Length - 3), Color.FromArgb(56, 68, 80));
            }
        }

        private void PBButtons_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;

            if (!pb.Name.Substring(3, pb.Name.Length - 3).Equals(GetName(currentDash)))
            {
                Changecolor(pb.Name.Substring(3, pb.Name.Length - 3), Color.FromArgb(73, 85, 100));
            }
        }

        private void PanelButtons_MouseEnter(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;

            if (!panel.Name.Substring(5, panel.Name.Length - 5).Equals(GetName(currentDash)))
            {
                Changecolor(panel.Name.Substring(5, panel.Name.Length - 5), Color.FromArgb(56, 68, 80));
            }
        }

        private void PanelButtons_MouseLeave(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;

            if (!panel.Name.Substring(5, panel.Name.Length - 5).Equals(GetName(currentDash)))
            {
                Changecolor(panel.Name.Substring(5, panel.Name.Length - 5), Color.FromArgb(73, 85, 100));
            }
        }

        private void LabelButtons_MouseEnter(object sender, EventArgs e)
        {
            Label label = sender as Label;

            if (!label.Name.Substring(1, label.Name.Length - 1).Equals(GetName(currentDash)))
            {
                Changecolor(label.Name.Substring(1, label.Name.Length - 1), Color.FromArgb(56, 68, 80));
            }
        }

        private void LabelButtons_MouseLeave(object sender, EventArgs e)
        {
            Label label = sender as Label;

            if (!label.Name.Substring(1, label.Name.Length - 1).Equals(GetName(currentDash)))
            {
                Changecolor(label.Name.Substring(1, label.Name.Length - 1), Color.FromArgb(73, 85, 100));
            }
        }

        private void Changecolor(string name, Color toSwitch)
        {
            switch (name)
            {
                case "Ping":
                    btnPing.BackColor = toSwitch;
                    panelPing.BackColor = toSwitch;
                    break;                
                case "About":
                    btnAbout.BackColor = toSwitch;
                    panelAbout.BackColor = toSwitch;
                    break;
                case "Description":
                    btnDescription.BackColor = toSwitch;
                    break;
                default:
                    break;
            }
        }

        private string GetName(int id)
        {
            switch (id)
            {                
                case 1:
                    return "Ping";
                case 2:
                    return "About";
                default:
                    return string.Empty;
            }
        }

        private void ChangeColorClick(int oldDash, int newDash)
        {
            string oldName = GetName(oldDash);
            string newName = GetName(newDash);

            Changecolor(oldName, Color.FromArgb(73, 85, 100));
            Changecolor(newName, Color.FromArgb(31, 43, 55));
        }
    }
}
