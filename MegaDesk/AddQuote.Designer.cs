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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQuote));
            this.lbl_CustomerName = new System.Windows.Forms.Label();
            this.text_CustomerName = new System.Windows.Forms.TextBox();
            this.lbl_Material = new System.Windows.Forms.Label();
            this.cbo_MaterialType = new System.Windows.Forms.ComboBox();
            this.lbl_DrawerCount = new System.Windows.Forms.Label();
            this.lbl_Width = new System.Windows.Forms.Label();
            this.lbl_Depth = new System.Windows.Forms.Label();
            this.lbl_DeliverySpeed = new System.Windows.Forms.Label();
            this.cbo_DeliverySpeed = new System.Windows.Forms.ComboBox();
            this.num_DrawerCount = new System.Windows.Forms.NumericUpDown();
            this.num_Width = new System.Windows.Forms.NumericUpDown();
            this.num_Depth = new System.Windows.Forms.NumericUpDown();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.btn_mainMenu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_DrawerCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Depth)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_CustomerName
            // 
            this.lbl_CustomerName.AutoSize = true;
            this.lbl_CustomerName.Location = new System.Drawing.Point(36, 48);
            this.lbl_CustomerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_CustomerName.Name = "lbl_CustomerName";
            this.lbl_CustomerName.Size = new System.Drawing.Size(124, 20);
            this.lbl_CustomerName.TabIndex = 1;
            this.lbl_CustomerName.Text = "Customer Name";
            // 
            // text_CustomerName
            // 
            this.text_CustomerName.Location = new System.Drawing.Point(195, 37);
            this.text_CustomerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_CustomerName.MaxLength = 50;
            this.text_CustomerName.Name = "text_CustomerName";
            this.text_CustomerName.Size = new System.Drawing.Size(230, 26);
            this.text_CustomerName.TabIndex = 1;
            this.text_CustomerName.WordWrap = false;
            this.text_CustomerName.Enter += new System.EventHandler(this.text_CustomerName_Enter);
            // 
            // lbl_Material
            // 
            this.lbl_Material.AutoSize = true;
            this.lbl_Material.Location = new System.Drawing.Point(36, 118);
            this.lbl_Material.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Material.Name = "lbl_Material";
            this.lbl_Material.Size = new System.Drawing.Size(65, 20);
            this.lbl_Material.TabIndex = 3;
            this.lbl_Material.Text = "Material";
            // 
            // cbo_MaterialType
            // 
            this.cbo_MaterialType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_MaterialType.FormattingEnabled = true;
            this.cbo_MaterialType.Location = new System.Drawing.Point(195, 106);
            this.cbo_MaterialType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbo_MaterialType.Name = "cbo_MaterialType";
            this.cbo_MaterialType.Size = new System.Drawing.Size(230, 28);
            this.cbo_MaterialType.TabIndex = 2;
            // 
            // lbl_DrawerCount
            // 
            this.lbl_DrawerCount.AutoSize = true;
            this.lbl_DrawerCount.Location = new System.Drawing.Point(36, 189);
            this.lbl_DrawerCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DrawerCount.Name = "lbl_DrawerCount";
            this.lbl_DrawerCount.Size = new System.Drawing.Size(107, 20);
            this.lbl_DrawerCount.TabIndex = 5;
            this.lbl_DrawerCount.Text = "Drawer Count";
            // 
            // lbl_Width
            // 
            this.lbl_Width.AutoSize = true;
            this.lbl_Width.Location = new System.Drawing.Point(36, 260);
            this.lbl_Width.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Width.Name = "lbl_Width";
            this.lbl_Width.Size = new System.Drawing.Size(50, 20);
            this.lbl_Width.TabIndex = 6;
            this.lbl_Width.Text = "Width";
            // 
            // lbl_Depth
            // 
            this.lbl_Depth.AutoSize = true;
            this.lbl_Depth.Location = new System.Drawing.Point(36, 331);
            this.lbl_Depth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Depth.Name = "lbl_Depth";
            this.lbl_Depth.Size = new System.Drawing.Size(53, 20);
            this.lbl_Depth.TabIndex = 7;
            this.lbl_Depth.Text = "Depth";
            // 
            // lbl_DeliverySpeed
            // 
            this.lbl_DeliverySpeed.AutoSize = true;
            this.lbl_DeliverySpeed.Location = new System.Drawing.Point(36, 402);
            this.lbl_DeliverySpeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DeliverySpeed.Name = "lbl_DeliverySpeed";
            this.lbl_DeliverySpeed.Size = new System.Drawing.Size(115, 20);
            this.lbl_DeliverySpeed.TabIndex = 8;
            this.lbl_DeliverySpeed.Text = "Delivery Speed";
            // 
            // cbo_DeliverySpeed
            // 
            this.cbo_DeliverySpeed.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_DeliverySpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_DeliverySpeed.FormattingEnabled = true;
            this.cbo_DeliverySpeed.Location = new System.Drawing.Point(195, 394);
            this.cbo_DeliverySpeed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbo_DeliverySpeed.Name = "cbo_DeliverySpeed";
            this.cbo_DeliverySpeed.Size = new System.Drawing.Size(230, 28);
            this.cbo_DeliverySpeed.TabIndex = 6;
            // 
            // num_DrawerCount
            // 
            this.num_DrawerCount.Location = new System.Drawing.Point(195, 177);
            this.num_DrawerCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.num_DrawerCount.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.num_DrawerCount.Name = "num_DrawerCount";
            this.num_DrawerCount.Size = new System.Drawing.Size(232, 26);
            this.num_DrawerCount.TabIndex = 3;
            this.num_DrawerCount.Enter += new System.EventHandler(this.num_DrawerCount_Enter);
            // 
            // num_Width
            // 
            this.num_Width.Location = new System.Drawing.Point(195, 249);
            this.num_Width.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.num_Width.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.num_Width.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.num_Width.Name = "num_Width";
            this.num_Width.Size = new System.Drawing.Size(232, 26);
            this.num_Width.TabIndex = 4;
            this.num_Width.Value = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.num_Width.Enter += new System.EventHandler(this.num_Width_Enter);
            // 
            // num_Depth
            // 
            this.num_Depth.Location = new System.Drawing.Point(195, 320);
            this.num_Depth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.num_Depth.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.num_Depth.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.num_Depth.Name = "num_Depth";
            this.num_Depth.Size = new System.Drawing.Size(232, 26);
            this.num_Depth.TabIndex = 5;
            this.num_Depth.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.num_Depth.Enter += new System.EventHandler(this.num_Depth_Enter);
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.Location = new System.Drawing.Point(171, 606);
            this.lbl_Price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(0, 37);
            this.lbl_Price.TabIndex = 9;
            // 
            // btn_mainMenu
            // 
            this.btn_mainMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_mainMenu.Image = global::MegaDesk.Properties.Resources.close_FILL0_wght400_GRAD0_opsz48;
            this.btn_mainMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_mainMenu.Location = new System.Drawing.Point(246, 489);
            this.btn_mainMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_mainMenu.Name = "btn_mainMenu";
            this.btn_mainMenu.Size = new System.Drawing.Size(182, 82);
            this.btn_mainMenu.TabIndex = 8;
            this.btn_mainMenu.Text = "Cancel";
            this.btn_mainMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_mainMenu.UseVisualStyleBackColor = true;
            this.btn_mainMenu.Click += new System.EventHandler(this.btn_mainMenu_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Image = global::MegaDesk.Properties.Resources.add_circle_FILL0_wght400_GRAD0_opsz48;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(40, 489);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 82);
            this.button1.TabIndex = 7;
            this.button1.Text = "Create Quote";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_mainMenu;
            this.ClientSize = new System.Drawing.Size(492, 697);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.num_Depth);
            this.Controls.Add(this.num_Width);
            this.Controls.Add(this.num_DrawerCount);
            this.Controls.Add(this.cbo_DeliverySpeed);
            this.Controls.Add(this.lbl_DeliverySpeed);
            this.Controls.Add(this.lbl_Depth);
            this.Controls.Add(this.lbl_Width);
            this.Controls.Add(this.lbl_DrawerCount);
            this.Controls.Add(this.cbo_MaterialType);
            this.Controls.Add(this.lbl_Material);
            this.Controls.Add(this.text_CustomerName);
            this.Controls.Add(this.lbl_CustomerName);
            this.Controls.Add(this.btn_mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(514, 753);
            this.MinimumSize = new System.Drawing.Size(514, 753);
            this.Name = "AddQuote";
            this.Text = "Add Quote";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddQuote_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.num_DrawerCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Depth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_mainMenu;
        private System.Windows.Forms.Label lbl_CustomerName;
        private System.Windows.Forms.TextBox text_CustomerName;
        private System.Windows.Forms.Label lbl_Material;
        private System.Windows.Forms.ComboBox cbo_MaterialType;
        private System.Windows.Forms.Label lbl_DrawerCount;
        private System.Windows.Forms.Label lbl_Width;
        private System.Windows.Forms.Label lbl_Depth;
        private System.Windows.Forms.Label lbl_DeliverySpeed;
        private System.Windows.Forms.ComboBox cbo_DeliverySpeed;
        private System.Windows.Forms.NumericUpDown num_DrawerCount;
        private System.Windows.Forms.NumericUpDown num_Width;
        private System.Windows.Forms.NumericUpDown num_Depth;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_Price;
    }
}