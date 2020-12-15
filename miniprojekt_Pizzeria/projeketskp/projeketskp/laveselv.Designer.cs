
namespace projeketskp
{
    partial class laveselv
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
            this.kontakosButton = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.topheadder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kontakosButton
            // 
            this.kontakosButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.kontakosButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.kontakosButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kontakosButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kontakosButton.ForeColor = System.Drawing.Color.Cyan;
            this.kontakosButton.Location = new System.Drawing.Point(61, 1);
            this.kontakosButton.Name = "kontakosButton";
            this.kontakosButton.Size = new System.Drawing.Size(85, 25);
            this.kontakosButton.TabIndex = 7;
            this.kontakosButton.Text = "Kontakt OS";
            this.kontakosButton.UseVisualStyleBackColor = false;
            this.kontakosButton.Click += new System.EventHandler(this.kontakosButton_Click);
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.menuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.ForeColor = System.Drawing.Color.Cyan;
            this.menuButton.Location = new System.Drawing.Point(6, 1);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(49, 25);
            this.menuButton.TabIndex = 6;
            this.menuButton.Text = "Menu";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // topheadder
            // 
            this.topheadder.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.topheadder.Enabled = false;
            this.topheadder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.topheadder.ForeColor = System.Drawing.Color.DimGray;
            this.topheadder.Location = new System.Drawing.Point(-6, -2);
            this.topheadder.Name = "topheadder";
            this.topheadder.Size = new System.Drawing.Size(813, 31);
            this.topheadder.TabIndex = 5;
            this.topheadder.UseVisualStyleBackColor = false;
            // 
            // laveselv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kontakosButton);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.topheadder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "laveselv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "laveselv";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button kontakosButton;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Button topheadder;
    }
}