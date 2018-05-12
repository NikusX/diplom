namespace boxOffice
{
    partial class buyerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(buyerForm));
            this.exitButton = new System.Windows.Forms.Button();
            this.userProfileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitButton.BackgroundImage")));
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitButton.Location = new System.Drawing.Point(12, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(42, 57);
            this.exitButton.TabIndex = 0;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // userProfileButton
            // 
            this.userProfileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userProfileButton.Location = new System.Drawing.Point(60, 12);
            this.userProfileButton.Name = "userProfileButton";
            this.userProfileButton.Size = new System.Drawing.Size(149, 57);
            this.userProfileButton.TabIndex = 1;
            this.userProfileButton.Text = "Мой профиль";
            this.userProfileButton.UseVisualStyleBackColor = true;
            this.userProfileButton.Click += new System.EventHandler(this.userProfileButton_Click);
            // 
            // buyerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 388);
            this.Controls.Add(this.userProfileButton);
            this.Controls.Add(this.exitButton);
            this.Name = "buyerForm";
            this.Text = "Заказчик";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.buyerForm_FormClosed);
            this.Load += new System.EventHandler(this.buyerForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button userProfileButton;
    }
}