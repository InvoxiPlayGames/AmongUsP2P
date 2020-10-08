namespace AmongUsP2P
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            this.broadcastCheckBox = new System.Windows.Forms.CheckBox();
            this.askForIPBox = new System.Windows.Forms.CheckBox();
            this.ipLabel = new System.Windows.Forms.Label();
            this.ipTextbox = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.updateConnected = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // broadcastCheckBox
            // 
            this.broadcastCheckBox.AutoSize = true;
            this.broadcastCheckBox.Location = new System.Drawing.Point(12, 12);
            this.broadcastCheckBox.Name = "broadcastCheckBox";
            this.broadcastCheckBox.Size = new System.Drawing.Size(110, 17);
            this.broadcastCheckBox.TabIndex = 0;
            this.broadcastCheckBox.Text = "Broadcast to LAN";
            this.broadcastCheckBox.UseVisualStyleBackColor = true;
            // 
            // askForIPBox
            // 
            this.askForIPBox.AutoSize = true;
            this.askForIPBox.Location = new System.Drawing.Point(12, 35);
            this.askForIPBox.Name = "askForIPBox";
            this.askForIPBox.Size = new System.Drawing.Size(72, 17);
            this.askForIPBox.TabIndex = 1;
            this.askForIPBox.Text = "Ask for IP";
            this.askForIPBox.UseVisualStyleBackColor = true;
            this.askForIPBox.CheckedChanged += new System.EventHandler(this.askForIPBox_CheckedChanged);
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Location = new System.Drawing.Point(12, 60);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(61, 13);
            this.ipLabel.TabIndex = 2;
            this.ipLabel.Text = "IP Address:";
            // 
            // ipTextbox
            // 
            this.ipTextbox.Location = new System.Drawing.Point(74, 57);
            this.ipTextbox.Name = "ipTextbox";
            this.ipTextbox.Size = new System.Drawing.Size(100, 20);
            this.ipTextbox.TabIndex = 3;
            this.ipTextbox.TextChanged += new System.EventHandler(this.ipTextbox_TextChanged);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(12, 84);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(79, 13);
            this.statusLabel.TabIndex = 4;
            this.statusLabel.Text = "Not Connected";
            // 
            // updateConnected
            // 
            this.updateConnected.Enabled = true;
            this.updateConnected.Tick += new System.EventHandler(this.updateConnected_Tick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 107);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.ipTextbox);
            this.Controls.Add(this.ipLabel);
            this.Controls.Add(this.askForIPBox);
            this.Controls.Add(this.broadcastCheckBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Among Us P2P";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox broadcastCheckBox;
        private System.Windows.Forms.CheckBox askForIPBox;
        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.TextBox ipTextbox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Timer updateConnected;
    }
}

