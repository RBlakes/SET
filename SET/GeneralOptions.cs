﻿namespace SET
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    /// <summary>
    /// This is for the general options of the game. It will allow each user to
    /// set whether or not they want to have game sounds and what key bind they want
    /// to submit a set. It also sets the event handlers for hovering over links.
    /// </summary>
    public partial class GeneralOptions : Form
    {
        
        public GeneralOptions(Players player1)
        {

            InitializeComponent();
            if(player1.Mute == true)
            {
                muteCheckBox.Checked = true;
            }
            else
            {
                muteCheckBox.Checked = false;
            }
            keyBindingLable.Text = player1.Keybinds["key"];
        }
        
        /// <summary>
        /// Close the option form without saving
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void CloseOptionsLabel_Click(object sender, EventArgs e)
        {
            // close options wihtout saving
            this.Close();
        }

        /// <summary>
        /// Close the option form and save changes
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void SaveOptionsLabel_Click(object sender, EventArgs e)
        {
            // want to do logic to update the settings but don't know how to access
            // the player1 object that we passed into this form.
            // save settings
            MessageBox.Show("Sorry, but we were unable to save your optoins at this time.");
            
            // close otions form
            this.Close();
        }

        /// <summary>
        /// Allow user to switch key bind to whatever key they want
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void KeyBindingLable_Click(object sender, EventArgs e)
        {
            // allow user to switch key bind to whatever key they press
            MessageBox.Show("This feature is not working at this time.");
        }

        /// <summary>
        /// change color of text back to white when mouse leaves
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void SaveOptionsLabel_MouseLeave(object sender, EventArgs e)
        {
            saveOptionsLabel.ForeColor = Color.White;
        }

        /// <summary>
        /// change text to light gray when over over link
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void SaveOptionsLabel_MouseEnter(object sender, EventArgs e)
        {
            saveOptionsLabel.ForeColor = Color.LightGray;
        }

        /// <summary>
        /// change text to light gray when over over link
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void CloseOptionsLabel_MouseEnter(object sender, EventArgs e)
        {
            closeOptionsLabel.ForeColor = Color.LightGray;
        }

        /// <summary>
        /// change color of text back to white when mouse leaves
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void CloseOptionsLabel_MouseLeave(object sender, EventArgs e)
        {
            closeOptionsLabel.ForeColor = Color.White;
        }

        /// <summary>
        /// change text to light gray when over over link
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void MuteCheckBox_MouseEnter(object sender, EventArgs e)
        {
            muteCheckBox.ForeColor = Color.LightGray;
        }

        /// <summary>
        /// change color of text back to white when mouse leaves
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void MuteCheckBox_MouseLeave(object sender, EventArgs e)
        {
            muteCheckBox.ForeColor = Color.White;
        }

        /// <summary>
        /// change text to light gray when over over link
        /// </summary>
       /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void KeyBindingLable_MouseEnter(object sender, EventArgs e)
        {
            keyBindingLable.ForeColor = Color.LightGray;
        }

        /// <summary>
        /// change color of text back to white when mouse leaves
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void KeyBindingLable_MouseLeave(object sender, EventArgs e)
        {
            keyBindingLable.ForeColor = Color.White;
        }

    }
}
