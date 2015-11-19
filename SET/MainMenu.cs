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
    /// This form displays a menu where users
    /// can start a single player game, multi
    /// player game, change options, or exit
    /// the game.
    /// </summary>
    public partial class MainMenu : Form
    {
        /// <summary>
        /// Initializes a new instance of the MainMenu class.
        /// </summary>
        public MainMenu()
        {
            InitializeComponent();
        }

        private void optionsLabel_Click(object sender, EventArgs e)
        {
            // make GeneralOptions Form come to top.
            GeneralOptions options = new GeneralOptions();
            options.ShowDialog();
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            // exit from the mainMenu form
            this.Close();
        }

        private void multiPlayerLabel_Click(object sender, EventArgs e)
        {
            // hide main menu
            this.Hide();
            // make lobby finder form.
            LobbyFinder lobbyFinder = new LobbyFinder();
            lobbyFinder.ShowDialog();
            this.Show();
        }

        private void singlePlayerLabel_Click(object sender, EventArgs e)
        {
            // hide the main menu
            this.Hide();
            // send user to the lobby
            Lobby lobby = new Lobby();
            lobby.ShowDialog();
            this.Show();
        }
    }
}
