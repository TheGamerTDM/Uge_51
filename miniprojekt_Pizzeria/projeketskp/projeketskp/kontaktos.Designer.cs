
namespace projeketskp
{
    partial class kontaktos
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
            this.lavselvButton = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.topheadder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lavselvButton
            // 
            this.lavselvButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lavselvButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.lavselvButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lavselvButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lavselvButton.ForeColor = System.Drawing.Color.Cyan;
            this.lavselvButton.Location = new System.Drawing.Point(136, 2);
            this.lavselvButton.Name = "lavselvButton";
            this.lavselvButton.Size = new System.Drawing.Size(85, 25);
            this.lavselvButton.TabIndex = 22;
            this.lavselvButton.Text = "Lave selv";
            this.lavselvButton.UseVisualStyleBackColor = false;
            this.lavselvButton.Click += new System.EventHandler(this.lavselvButton_Click);
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.menuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.ForeColor = System.Drawing.Color.Cyan;
            this.menuButton.Location = new System.Drawing.Point(81, 2);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(49, 25);
            this.menuButton.TabIndex = 20;
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
            this.topheadder.Location = new System.Drawing.Point(-6, -1);
            this.topheadder.Name = "topheadder";
            this.topheadder.Size = new System.Drawing.Size(756, 31);
            this.topheadder.TabIndex = 19;
            this.topheadder.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(69, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "Tlfnr: 42424278";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(16, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "Email: daxipizza@gmail.com";
            // 
            // kontaktos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(305, 199);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lavselvButton);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.topheadder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "kontaktos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kontaktos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lavselvButton;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Button topheadder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}