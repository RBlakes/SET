﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SET
{
    public partial class GeneralOptions : Form
    {
        public GeneralOptions()
        {
            InitializeComponent();
        }

        private void closeOptionsLabel_Click(object sender, EventArgs e)
        {
            // close options wihtout saving
            this.Close();
        }

        private void saveOptionsLabel_Click(object sender, EventArgs e)
        {
            // save settings
            MessageBox.Show("Your settings were saved!");
            // close otions form
            this.Close();
        }

        private void keyBindingLable_Click(object sender, EventArgs e)
        {
            // allow user to switch key bind to whatever key they press
            MessageBox.Show("Allow user to switch keybinds!");
        }


        private void saveOptionsLabel_MouseLeave(object sender, EventArgs e)
        {
            saveOptionsLabel.ForeColor = Color.White;
        }

        private void saveOptionsLabel_MouseEnter(object sender, EventArgs e)
        {
            saveOptionsLabel.ForeColor = Color.LightGray;
        }

        private void closeOptionsLabel_MouseEnter(object sender, EventArgs e)
        {
            closeOptionsLabel.ForeColor = Color.LightGray;
        }

        private void closeOptionsLabel_MouseLeave(object sender, EventArgs e)
        {
            closeOptionsLabel.ForeColor = Color.White;
        }

        private void muteCheckBox_MouseEnter(object sender, EventArgs e)
        {
            muteCheckBox.ForeColor = Color.LightGray;
        }

        private void muteCheckBox_MouseLeave(object sender, EventArgs e)
        {
            muteCheckBox.ForeColor = Color.White;
        }

        private void keyBindingLable_MouseEnter(object sender, EventArgs e)
        {
            keyBindingLable.ForeColor = Color.LightGray;
        }

        private void keyBindingLable_MouseLeave(object sender, EventArgs e)
        {
            keyBindingLable.ForeColor = Color.White;
        }
    }
}