namespace MegaDesk
{
    partial class AddQuote
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
            this.btn_mainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_mainMenu
            // 
            this.btn_mainMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_mainMenu.Image = global::MegaDesk.Properties.Resources.logout_FILL0_wght400_GRAD0_opsz48;
            this.btn_mainMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_mainMenu.Location = new System.Drawing.Point(450, 634);
            this.btn_mainMenu.Name = "btn_mainMenu";
            this.btn_mainMenu.Size = new System.Drawing.Size(121, 53);
            this.btn_mainMenu.TabIndex = 0;
            this.btn_mainMenu.Text = "Main Menu";
            this.btn_mainMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_mainMenu.UseVisualStyleBackColor = true;
            this.btn_mainMenu.Click += new System.EventHandler(this.btn_mainMenu_Click);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_mainMenu;
            this.ClientSize = new System.Drawing.Size(595, 699);
            this.Controls.Add(this.btn_mainMenu);
            this.Name = "AddQuote";
            this.Text = "DisplayQuote";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_mainMenu;
    }
}