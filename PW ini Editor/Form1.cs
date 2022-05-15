using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Salaros.Configuration;

namespace PW_ini_Editor
{

    public partial class Form1 : Form

    {

        private string appConfig = Application.StartupPath + @"\element\userdata\systemsettings.ini";

        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            var cfg = new ConfigParser(appConfig);

            // Window Mode
            if (this.checkBox3.Checked)
            {
                this.TopMost = true;
                this.checkBox3.Text = "Window Mode Enabled";
                this.checkBox3.Checked = true;
                cfg.SetValue("Video", "FullScreen", "0");
                cfg.Save();
            }
            else
            {
                this.TopMost = false;
                this.checkBox3.Text = "Window Mode Disabled";
                this.checkBox3.Checked = false;
                cfg.SetValue("Video", "FullScreen", "1");
                cfg.Save();
            }


        }

        void LoadSettings()
        {
            var cfg = new ConfigParser(appConfig);
            var fssetting = cfg.GetValue("Video", "FullScreen");
            var shadows = cfg.GetValue("Video", "Shadow");
            var vsync = cfg.GetValue("Video", "VerticalSync");
            var warp = cfg.GetValue("Video", "SpaceWarp");
            var sunmoon = cfg.GetValue("Video", "SunFlare");
            var widescreen = cfg.GetValue("Video", "WideScreen");

            if (shadows == "0")
            {
                this.TopMost = true;
                this.checkBox2.Text = "Shadows Enabled";
                this.checkBox2.Checked = true;
            }
            else
            {
                this.TopMost = false;
                this.checkBox2.Text = "Shadows Disabled";
                this.checkBox2.Checked = false;
                cfg.SetValue("Video", "Shadow", "1");
            }

            if (fssetting == "0")
            {
                this.TopMost = true;
                this.checkBox3.Text = "Window Mode Enabled";
                this.checkBox3.Checked = true;
            }
            else
            {
                this.TopMost = false;
                this.checkBox3.Text = "Window Mode Disabled";
                this.checkBox3.Checked = false;
                cfg.SetValue("Video", "FullScreen", "1");
            }

            if (vsync == "0")
            {
                this.TopMost = true;
                this.checkBox4.Text = "V-Sync Enabled";
                this.checkBox4.Checked = true;
            }
            else
            {
                this.TopMost = false;
                this.checkBox4.Text = "V-Sync Disabled";
                this.checkBox4.Checked = false;
                cfg.SetValue("Video", "FullScreen", "1");
            }

            if (widescreen == "0")
            {
                this.TopMost = true;
                this.checkBox7.Text = "16:9 Mode Enabled";
                this.checkBox7.Checked = true;
            }
            else
            {
                this.TopMost = false;
                this.checkBox7.Text = "16:9 Mode Disabled";
                this.checkBox7.Checked = false;
                cfg.SetValue("Video", "WideScreen", "1");
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            var cfg = new ConfigParser(appConfig);

            // Shadows
            if (this.checkBox2.Checked)
            {
                this.TopMost = true;
                this.checkBox2.Text = "Shadows Enabled";
                this.checkBox2.Checked = true;
                cfg.SetValue("Video", "Shadow", "0");
                cfg.Save();
            }
            else
            {
                this.TopMost = false;
                this.checkBox2.Text = "Shadows Disabled";
                this.checkBox2.Checked = false;
                cfg.SetValue("Video", "Shadow", "1");
                cfg.Save();
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            var cfg = new ConfigParser(appConfig);

            // Shadows
            if (this.checkBox4.Checked)
            {
                this.TopMost = true;
                this.checkBox4.Text = "V-sync Enabled";
                this.checkBox4.Checked = true;
                cfg.SetValue("Video", "VerticalSync", "0");
                cfg.Save();
            }
            else
            {
                this.TopMost = false;
                this.checkBox4.Text = "V-sync Disabled";
                this.checkBox4.Checked = false;
                cfg.SetValue("Video", "VerticalSync", "1");
                cfg.Save();
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            var cfg = new ConfigParser(appConfig);

            // Widescreen Mode
            if (this.checkBox7.Checked)
            {
                this.TopMost = true;
                this.checkBox7.Text = "16:9 Mode Enabled";
                this.checkBox7.Checked = true;
                cfg.SetValue("Video", "WideScreen", "0");
                cfg.Save();
            }
            else
            {
                this.TopMost = false;
                this.checkBox7.Text = "16:9 Mode Disabled";
                this.checkBox7.Checked = false;
                cfg.SetValue("Video", "WideScreen", "1");

            }
        }
    }

}
