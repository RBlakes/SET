namespace SET
{
    /// <summary>
    /// This is for the general options of the game. It will allow each user to
    /// set whether or not they want to have game sounds and what key bind they want
    /// to submit a set. It also sets the event handlers for hovering over links.
    /// </summary>
    partial class GeneralOptions
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
            this.genOptionsLabel = new System.Windows.Forms.Label();
            this.muteCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.closeOptionsLabel = new System.Windows.Forms.Label();
            this.saveOptionsLabel = new System.Windows.Forms.Label();
            this.keyBindingLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // genOptionsLabel
            // 
            this.genOptionsLabel.AutoSize = true;
            this.genOptionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genOptionsLabel.ForeColor = System.Drawing.Color.White;
            this.genOptionsLabel.Location = new System.Drawing.Point(50, 23);
            this.genOptionsLabel.Name = "genOptionsLabel";
            this.genOptionsLabel.Size = new System.Drawing.Size(231, 53);
            this.genOptionsLabel.TabIndex = 0;
            this.genOptionsLabel.Text = "OPTIONS";
            // 
            // muteCheckBox
            // 
            this.muteCheckBox.AutoSize = true;
            this.muteCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muteCheckBox.ForeColor = System.Drawing.Color.White;
            this.muteCheckBox.Location = new System.Drawing.Point(116, 79);
            this.muteCheckBox.Name = "muteCheckBox";
            this.muteCheckBox.Size = new System.Drawing.Size(159, 30);
            this.muteCheckBox.TabIndex = 1;
            this.muteCheckBox.Text = "Mute Sounds";
            this.muteCheckBox.UseVisualStyleBackColor = true;
            this.muteCheckBox.MouseEnter += new System.EventHandler(this.MuteCheckBox_MouseEnter);
            this.muteCheckBox.MouseLeave += new System.EventHandler(this.MuteCheckBox_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(111, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "SET! Key Binding: ";
            // 
            // closeOptionsLabel
            // 
            this.closeOptionsLabel.AutoSize = true;
            this.closeOptionsLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeOptionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeOptionsLabel.ForeColor = System.Drawing.Color.White;
            this.closeOptionsLabel.Location = new System.Drawing.Point(335, 177);
            this.closeOptionsLabel.Name = "closeOptionsLabel";
            this.closeOptionsLabel.Size = new System.Drawing.Size(49, 20);
            this.closeOptionsLabel.TabIndex = 3;
            this.closeOptionsLabel.Text = "Close";
            this.closeOptionsLabel.Click += new System.EventHandler(this.CloseOptionsLabel_Click);
            this.closeOptionsLabel.MouseEnter += new System.EventHandler(this.CloseOptionsLabel_MouseEnter);
            this.closeOptionsLabel.MouseLeave += new System.EventHandler(this.CloseOptionsLabel_MouseLeave);
            // 
            // saveOptionsLabel
            // 
            this.saveOptionsLabel.AutoSize = true;
            this.saveOptionsLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveOptionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveOptionsLabel.ForeColor = System.Drawing.Color.White;
            this.saveOptionsLabel.Location = new System.Drawing.Point(407, 177);
            this.saveOptionsLabel.Name = "saveOptionsLabel";
            this.saveOptionsLabel.Size = new System.Drawing.Size(31, 20);
            this.saveOptionsLabel.TabIndex = 4;
            this.saveOptionsLabel.Text = "OK";
            this.saveOptionsLabel.Click += new System.EventHandler(this.SaveOptionsLabel_Click);
            this.saveOptionsLabel.MouseEnter += new System.EventHandler(this.SaveOptionsLabel_MouseEnter);
            this.saveOptionsLabel.MouseLeave += new System.EventHandler(this.SaveOptionsLabel_MouseLeave);
            // 
            // keyBindingLable
            // 
            this.keyBindingLable.AutoSize = true;
            this.keyBindingLable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.keyBindingLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyBindingLable.ForeColor = System.Drawing.Color.White;
            this.keyBindingLable.Location = new System.Drawing.Point(297, 119);
            this.keyBindingLable.Name = "keyBindingLable";
            this.keyBindingLable.Size = new System.Drawing.Size(74, 26);
            this.keyBindingLable.TabIndex = 5;
            this.keyBindingLable.Text = "Space";
            this.keyBindingLable.Click += new System.EventHandler(this.KeyBindingLable_Click);
            this.keyBindingLable.MouseEnter += new System.EventHandler(this.KeyBindingLable_MouseEnter);
            this.keyBindingLable.MouseLeave += new System.EventHandler(this.KeyBindingLable_MouseLeave);
            // 
            // GeneralOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(462, 214);
            this.Controls.Add(this.keyBindingLable);
            this.Controls.Add(this.saveOptionsLabel);
            this.Controls.Add(this.closeOptionsLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.muteCheckBox);
            this.Controls.Add(this.genOptionsLabel);
            this.Name = "GeneralOptions";
            this.Text = "GeneralOptions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label genOptionsLabel;
        private System.Windows.Forms.CheckBox muteCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label closeOptionsLabel;
        private System.Windows.Forms.Label saveOptionsLabel;
        private System.Windows.Forms.Label keyBindingLable;
    }
}