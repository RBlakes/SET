namespace SET
{
    /// <summary>
    /// This partial class holds all information
    /// relevant to creating the MainMenu form.
    /// </summary>
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.setLabel = new System.Windows.Forms.Label();
            this.singlePlayerLabel = new System.Windows.Forms.Label();
            this.multiPlayerLabel = new System.Windows.Forms.Label();
            this.optionsLabel = new System.Windows.Forms.Label();
            this.exitLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // setLabel
            // 
            this.setLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.setLabel.AutoSize = true;
            this.setLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 65F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setLabel.ForeColor = System.Drawing.Color.White;
            this.setLabel.Location = new System.Drawing.Point(227, 100);
            this.setLabel.Name = "setLabel";
            this.setLabel.Size = new System.Drawing.Size(211, 98);
            this.setLabel.TabIndex = 0;
            this.setLabel.Text = "SET";
            this.setLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // singlePlayerLabel
            // 
            this.singlePlayerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.singlePlayerLabel.AutoSize = true;
            this.singlePlayerLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.singlePlayerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singlePlayerLabel.ForeColor = System.Drawing.Color.White;
            this.singlePlayerLabel.Location = new System.Drawing.Point(237, 229);
            this.singlePlayerLabel.Name = "singlePlayerLabel";
            this.singlePlayerLabel.Size = new System.Drawing.Size(203, 37);
            this.singlePlayerLabel.TabIndex = 1;
            this.singlePlayerLabel.Text = "Single Player";
            this.singlePlayerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.singlePlayerLabel.Click += new System.EventHandler(this.SinglePlayerLabel_Click);
            this.singlePlayerLabel.MouseEnter += new System.EventHandler(this.SinglePlayerLabel_MouseEnter);
            this.singlePlayerLabel.MouseLeave += new System.EventHandler(this.SinglePlayerLabel_MouseLeave);
            // 
            // multiPlayerLabel
            // 
            this.multiPlayerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.multiPlayerLabel.AutoSize = true;
            this.multiPlayerLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.multiPlayerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiPlayerLabel.ForeColor = System.Drawing.Color.White;
            this.multiPlayerLabel.Location = new System.Drawing.Point(246, 281);
            this.multiPlayerLabel.Name = "multiPlayerLabel";
            this.multiPlayerLabel.Size = new System.Drawing.Size(182, 37);
            this.multiPlayerLabel.TabIndex = 2;
            this.multiPlayerLabel.Text = "Multi Player";
            this.multiPlayerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.multiPlayerLabel.Click += new System.EventHandler(this.MultiPlayerLabel_Click);
            this.multiPlayerLabel.MouseEnter += new System.EventHandler(this.MultiPlayerLabel_MouseEnter);
            this.multiPlayerLabel.MouseLeave += new System.EventHandler(this.MultiPlayerLabel_MouseLeave);
            // 
            // optionsLabel
            // 
            this.optionsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.optionsLabel.AutoSize = true;
            this.optionsLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.optionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsLabel.ForeColor = System.Drawing.Color.White;
            this.optionsLabel.Location = new System.Drawing.Point(281, 333);
            this.optionsLabel.Name = "optionsLabel";
            this.optionsLabel.Size = new System.Drawing.Size(97, 29);
            this.optionsLabel.TabIndex = 3;
            this.optionsLabel.Text = "Options";
            this.optionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.optionsLabel.Click += new System.EventHandler(this.OptionsLabel_Click);
            this.optionsLabel.MouseEnter += new System.EventHandler(this.OptionsLabel_MouseEnter);
            this.optionsLabel.MouseLeave += new System.EventHandler(this.OptionsLabel_MouseLeave);
            // 
            // exitLabel
            // 
            this.exitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exitLabel.AutoSize = true;
            this.exitLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.ForeColor = System.Drawing.Color.White;
            this.exitLabel.Location = new System.Drawing.Point(305, 378);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(52, 29);
            this.exitLabel.TabIndex = 4;
            this.exitLabel.Text = "Exit";
            this.exitLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.exitLabel.Click += new System.EventHandler(this.ExitLabel_Click);
            this.exitLabel.MouseEnter += new System.EventHandler(this.ExitLabel_MouseEnter);
            this.exitLabel.MouseLeave += new System.EventHandler(this.ExitLabel_MouseLeave);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(662, 532);
            this.Controls.Add(this.exitLabel);
            this.Controls.Add(this.optionsLabel);
            this.Controls.Add(this.multiPlayerLabel);
            this.Controls.Add(this.singlePlayerLabel);
            this.Controls.Add(this.setLabel);
            this.MaximumSize = new System.Drawing.Size(1444, 885);
            this.MinimumSize = new System.Drawing.Size(500, 299);
            this.Name = "MainMenu";
            this.Text = "SET";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label setLabel;
        private System.Windows.Forms.Label singlePlayerLabel;
        private System.Windows.Forms.Label multiPlayerLabel;
        private System.Windows.Forms.Label optionsLabel;
        private System.Windows.Forms.Label exitLabel;
    }
}