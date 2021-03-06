﻿namespace boxOffice
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.repertoireButton = new System.Windows.Forms.Button();
            this.scheduleButton = new System.Windows.Forms.Button();
            this.theatresButton = new System.Windows.Forms.Button();
            this.ordersButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.theatreLogoPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.theatreLogoPB)).BeginInit();
            this.SuspendLayout();
            // 
            // repertoireButton
            // 
            this.repertoireButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(150)))));
            this.repertoireButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.repertoireButton.Location = new System.Drawing.Point(9, 190);
            this.repertoireButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.repertoireButton.Name = "repertoireButton";
            this.repertoireButton.Size = new System.Drawing.Size(370, 46);
            this.repertoireButton.TabIndex = 0;
            this.repertoireButton.Text = "Репертуар";
            this.repertoireButton.UseVisualStyleBackColor = false;
            this.repertoireButton.Click += new System.EventHandler(this.repertoireButton_Click);
            // 
            // scheduleButton
            // 
            this.scheduleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(150)))));
            this.scheduleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scheduleButton.Location = new System.Drawing.Point(9, 240);
            this.scheduleButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.scheduleButton.Name = "scheduleButton";
            this.scheduleButton.Size = new System.Drawing.Size(370, 46);
            this.scheduleButton.TabIndex = 1;
            this.scheduleButton.Text = "Расписание";
            this.scheduleButton.UseVisualStyleBackColor = false;
            this.scheduleButton.Click += new System.EventHandler(this.scheduleButton_Click);
            // 
            // theatresButton
            // 
            this.theatresButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(150)))));
            this.theatresButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.theatresButton.Location = new System.Drawing.Point(9, 291);
            this.theatresButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.theatresButton.Name = "theatresButton";
            this.theatresButton.Size = new System.Drawing.Size(370, 46);
            this.theatresButton.TabIndex = 2;
            this.theatresButton.Text = "Театры";
            this.theatresButton.UseVisualStyleBackColor = false;
            this.theatresButton.Click += new System.EventHandler(this.theatresButton_Click);
            // 
            // ordersButton
            // 
            this.ordersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(150)))));
            this.ordersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ordersButton.Location = new System.Drawing.Point(9, 341);
            this.ordersButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ordersButton.Name = "ordersButton";
            this.ordersButton.Size = new System.Drawing.Size(370, 46);
            this.ordersButton.TabIndex = 3;
            this.ordersButton.Text = "Заказы";
            this.ordersButton.UseVisualStyleBackColor = false;
            this.ordersButton.Click += new System.EventHandler(this.ordersButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(150)))));
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.Location = new System.Drawing.Point(9, 392);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(370, 46);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // theatreLogoPB
            // 
            this.theatreLogoPB.Location = new System.Drawing.Point(9, 10);
            this.theatreLogoPB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.theatreLogoPB.Name = "theatreLogoPB";
            this.theatreLogoPB.Size = new System.Drawing.Size(370, 162);
            this.theatreLogoPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.theatreLogoPB.TabIndex = 5;
            this.theatreLogoPB.TabStop = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(390, 448);
            this.Controls.Add(this.theatreLogoPB);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.ordersButton);
            this.Controls.Add(this.theatresButton);
            this.Controls.Add(this.scheduleButton);
            this.Controls.Add(this.repertoireButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "Театральная касса";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.theatreLogoPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button repertoireButton;
        private System.Windows.Forms.Button scheduleButton;
        private System.Windows.Forms.Button theatresButton;
        private System.Windows.Forms.Button ordersButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox theatreLogoPB;
    }
}