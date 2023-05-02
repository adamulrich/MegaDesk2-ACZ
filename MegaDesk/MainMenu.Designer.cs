namespace MegaDesk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_addQuote = new System.Windows.Forms.Button();
            this.btn_viewQuote = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_searchQuotes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MegaDesk.Properties.Resources.desk_icon;
            this.pictureBox1.Location = new System.Drawing.Point(342, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(444, 257);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btn_addQuote
            // 
            this.btn_addQuote.Image = global::MegaDesk.Properties.Resources.add_circle_FILL0_wght400_GRAD0_opsz48;
            this.btn_addQuote.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addQuote.Location = new System.Drawing.Point(28, 40);
            this.btn_addQuote.Name = "btn_addQuote";
            this.btn_addQuote.Size = new System.Drawing.Size(248, 75);
            this.btn_addQuote.TabIndex = 1;
            this.btn_addQuote.Text = "&Add Quote";
            this.btn_addQuote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_addQuote.UseVisualStyleBackColor = true;
            this.btn_addQuote.Click += new System.EventHandler(this.btn_addQuote_Click);
            // 
            // btn_viewQuote
            // 
            this.btn_viewQuote.Image = global::MegaDesk.Properties.Resources.receipt_long_FILL0_wght400_GRAD0_opsz48;
            this.btn_viewQuote.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_viewQuote.Location = new System.Drawing.Point(28, 258);
            this.btn_viewQuote.Name = "btn_viewQuote";
            this.btn_viewQuote.Size = new System.Drawing.Size(248, 75);
            this.btn_viewQuote.TabIndex = 3;
            this.btn_viewQuote.Text = "&View Quotes";
            this.btn_viewQuote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_viewQuote.UseVisualStyleBackColor = true;
            this.btn_viewQuote.Click += new System.EventHandler(this.btn_viewQuote_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_exit.Image = global::MegaDesk.Properties.Resources.logout_FILL0_wght400_GRAD0_opsz48;
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.Location = new System.Drawing.Point(28, 368);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(248, 83);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "E&xit";
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_searchQuotes
            // 
            this.btn_searchQuotes.Image = global::MegaDesk.Properties.Resources.search_FILL0_wght400_GRAD0_opsz48;
            this.btn_searchQuotes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_searchQuotes.Location = new System.Drawing.Point(28, 149);
            this.btn_searchQuotes.Name = "btn_searchQuotes";
            this.btn_searchQuotes.Size = new System.Drawing.Size(248, 75);
            this.btn_searchQuotes.TabIndex = 2;
            this.btn_searchQuotes.Text = "&Search Quotes";
            this.btn_searchQuotes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_searchQuotes.UseVisualStyleBackColor = true;
            this.btn_searchQuotes.Click += new System.EventHandler(this.btn_searchQuotes_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_exit;
            this.ClientSize = new System.Drawing.Size(849, 492);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_addQuote);
            this.Controls.Add(this.btn_viewQuote);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_searchQuotes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(871, 548);
            this.MinimumSize = new System.Drawing.Size(871, 548);
            this.Name = "MainMenu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_searchQuotes;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_viewQuote;
        private System.Windows.Forms.Button btn_addQuote;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}