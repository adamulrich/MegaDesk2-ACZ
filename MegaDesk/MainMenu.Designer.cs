﻿namespace MegaDesk
{
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
            this.btn_searchQuotes = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_viewQuote = new System.Windows.Forms.Button();
            this.btn_addQuote = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_searchQuotes
            // 
            this.btn_searchQuotes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_searchQuotes.Image = global::MegaDesk.Properties.Resources.search_FILL0_wght400_GRAD0_opsz48;
            this.btn_searchQuotes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_searchQuotes.Location = new System.Drawing.Point(28, 156);
            this.btn_searchQuotes.Name = "btn_searchQuotes";
            this.btn_searchQuotes.Size = new System.Drawing.Size(247, 76);
            this.btn_searchQuotes.TabIndex = 2;
            this.btn_searchQuotes.Text = "Search Quotes";
            this.btn_searchQuotes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_searchQuotes.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_exit.Image = global::MegaDesk.Properties.Resources.logout_FILL0_wght400_GRAD0_opsz48;
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.Location = new System.Drawing.Point(28, 389);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(247, 83);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "Exit";
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // btn_viewQuote
            // 
            this.btn_viewQuote.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_viewQuote.Image = global::MegaDesk.Properties.Resources.receipt_long_FILL0_wght400_GRAD0_opsz48;
            this.btn_viewQuote.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_viewQuote.Location = new System.Drawing.Point(28, 272);
            this.btn_viewQuote.Name = "btn_viewQuote";
            this.btn_viewQuote.Size = new System.Drawing.Size(247, 76);
            this.btn_viewQuote.TabIndex = 4;
            this.btn_viewQuote.Text = "View Quotes";
            this.btn_viewQuote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_viewQuote.UseVisualStyleBackColor = true;
            // 
            // btn_addQuote
            // 
            this.btn_addQuote.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_addQuote.Image = global::MegaDesk.Properties.Resources.add_circle_FILL0_wght400_GRAD0_opsz48;
            this.btn_addQuote.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addQuote.Location = new System.Drawing.Point(28, 40);
            this.btn_addQuote.Name = "btn_addQuote";
            this.btn_addQuote.Size = new System.Drawing.Size(247, 76);
            this.btn_addQuote.TabIndex = 5;
            this.btn_addQuote.Text = "Add Quote";
            this.btn_addQuote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_addQuote.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MegaDesk.Properties.Resources.desk_icon;
            this.pictureBox1.Location = new System.Drawing.Point(322, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 268);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 584);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_addQuote);
            this.Controls.Add(this.btn_viewQuote);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_searchQuotes);
            this.Name = "MainMenu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_searchQuotes;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_viewQuote;
        private System.Windows.Forms.Button btn_addQuote;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}