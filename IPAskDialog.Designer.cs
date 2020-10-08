namespace AmongUsP2P
{
    partial class IPAskDialog
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
            this.ipLabel = new System.Windows.Forms.Label();
            this.ipBox = new System.Windows.Forms.TextBox();
            this.joinButton = new System.Windows.Forms.Button();
            this.pleaseBringToFront = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Location = new System.Drawing.Point(12, 9);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(97, 13);
            this.ipLabel.TabIndex = 0;
            this.ipLabel.Text = "Enter the IP to join:";
            // 
            // ipBox
            // 
            this.ipBox.Location = new System.Drawing.Point(115, 6);
            this.ipBox.Name = "ipBox";
            this.ipBox.Size = new System.Drawing.Size(166, 20);
            this.ipBox.TabIndex = 1;
            // 
            // joinButton
            // 
            this.joinButton.Location = new System.Drawing.Point(287, 4);
            this.joinButton.Name = "joinButton";
            this.joinButton.Size = new System.Drawing.Size(75, 23);
            this.joinButton.TabIndex = 2;
            this.joinButton.Text = "Join";
            this.joinButton.UseVisualStyleBackColor = true;
            this.joinButton.Click += new System.EventHandler(this.joinButton_Click);
            // 
            // pleaseBringToFront
            // 
            this.pleaseBringToFront.Tick += new System.EventHandler(this.pleaseBringToFront_Tick);
            // 
            // IPAskDialog
            // 
            this.AcceptButton = this.joinButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 31);
            this.Controls.Add(this.joinButton);
            this.Controls.Add(this.ipBox);
            this.Controls.Add(this.ipLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IPAskDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Join via IP";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.IPAskDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.TextBox ipBox;
        private System.Windows.Forms.Button joinButton;
        private System.Windows.Forms.Timer pleaseBringToFront;
    }
}