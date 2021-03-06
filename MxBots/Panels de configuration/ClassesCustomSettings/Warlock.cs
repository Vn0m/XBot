﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MxBots.Panels_de_configuration.ClassesCustomSettings
{
    public partial class Warlock : UserControl
    {
        public Warlock()
        {
            InitializeComponent();
        }

        private void Warlock_Load(object sender, EventArgs e)
        {
            textBox1.Text = ClassSettings.Default.DistanceDuMain[(int)Classes.Démoniste].ToString();
            textBox2.Text = ClassSettings.Default.MinTargetDistance[(int)Classes.Démoniste].ToString();
            textBox3.Text = ClassSettings.Default.MaxTargetDistance[(int)Classes.Démoniste].ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ClassSettings.Default.DistanceDuMain[(int)Classes.Démoniste] = Int32.Parse(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ClassSettings.Default.MinTargetDistance[(int)Classes.Démoniste] = Int32.Parse(textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            ClassSettings.Default.MaxTargetDistance[(int)Classes.Démoniste] = Int32.Parse(textBox3.Text);
        }
    }
}
