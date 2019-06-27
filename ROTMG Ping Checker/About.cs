using System;
using System.Drawing;
using System.Windows.Forms;
using BunifuAnimatorNS;

namespace ROTMG_Ping_Checker
{
    public partial class About : UserControl
    {
        Image idea_on = Properties.Resources.UI_Icon_LightbulbOn_Dark;
        Image idea_off = Properties.Resources.UI_Icon_LightbulbOff_Dark;

        BunifuTransition transitionPbGlobe = new BunifuTransition();
        BunifuTransition transitionLDev = new BunifuTransition();

        bool ldevNameState = true;
        bool pbdevState = true;
        bool pbGlobeState = true;
        public About()
        {
            InitializeComponent();
            pbLama.Image = null;
            pbVersion.Parent = pbLama;
            lVersionText.Parent = pbLama;
            lversionNumber.Parent = pbLama;
            lversionNumber.Text = "1.0.4";
        }

        public void ToggleTimerIdea(bool state)
        {
            timerIdea.Enabled = state;
        }

        private void TimerIdea_Tick(object sender, EventArgs e)
        {
            if (pbIdeaIcon.Image == idea_on)
                pbIdeaIcon.Image = idea_off;
            else
                pbIdeaIcon.Image = idea_on;
        }

        private void PbGlobe_Click(object sender, EventArgs e)
        {
            transitionPbGlobe.HideSync(pbGlobe, false, Animation.Rotate);
            pbGlobeState = false;
            timerRestore.Start();
        }

        private void TimerRestore_Tick(object sender, EventArgs e)
        {
            timerRestore.Stop();
            if (!pbGlobeState)
                transitionPbGlobe.ShowSync(pbGlobe, false, Animation.Rotate);
            pbGlobeState = true;
            if (!ldevNameState)
                transitionLDev.ShowSync(lDevName, false, Animation.Particles);
            ldevNameState = true;
            if (!pbdevState)
                transitionLDev.ShowSync(pbDevIcon, false, Animation.Leaf);
            pbdevState = true;
        }

        private void LDevName_Click(object sender, EventArgs e)
        {
            transitionLDev.HideSync(lDevName, false, Animation.Particles);
            ldevNameState = false;
            timerRestore.Start();
        }

        private void PbDevIcon_Click(object sender, EventArgs e)
        {
            transitionLDev.HideSync(pbDevIcon, false, Animation.Leaf);
            pbdevState = false;
            timerRestore.Start();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            pbLama.Image = Properties.Resources.lamaWalk;
            timerLama.Start();
        }

        private void TimerLama_Tick(object sender, EventArgs e)
        {
            timerLama.Stop();
            pbLama.Image = null;
        }
    }
}
