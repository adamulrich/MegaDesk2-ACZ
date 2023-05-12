namespace MegaDesk
{
    partial class SearchQuotes
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
            this.cbo_MaterialType = new System.Windows.Forms.ComboBox();
            this.lbl_MaterialType = new System.Windows.Forms.Label();
            this.datagrid_quotes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_quotes)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_MaterialType
            // 
            this.cbo_MaterialType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_MaterialType.FormattingEnabled = true;
            this.cbo_MaterialType.Location = new System.Drawing.Point(188, 40);
            this.cbo_MaterialType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbo_MaterialType.Name = "cbo_MaterialType";
            this.cbo_MaterialType.Size = new System.Drawing.Size(180, 28);
            this.cbo_MaterialType.TabIndex = 0;
            this.cbo_MaterialType.SelectedIndexChanged += new System.EventHandler(this.cbo_MaterialType_SelectedIndexChanged);
            // 
            // lbl_MaterialType
            // 
            this.lbl_MaterialType.AutoSize = true;
            this.lbl_MaterialType.Location = new System.Drawing.Point(18, 45);
            this.lbl_MaterialType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MaterialType.Name = "lbl_MaterialType";
            this.lbl_MaterialType.Size = new System.Drawing.Size(103, 20);
            this.lbl_MaterialType.TabIndex = 2;
            this.lbl_MaterialType.Text = "Material Type";
            // 
            // datagrid_quotes
            // 
            this.datagrid_quotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_quotes.Location = new System.Drawing.Point(22, 95);
            this.datagrid_quotes.Name = "datagrid_quotes";
            this.datagrid_quotes.ReadOnly = true;
            this.datagrid_quotes.RowHeadersWidth = 62;
            this.datagrid_quotes.RowTemplate.Height = 28;
            this.datagrid_quotes.Size = new System.Drawing.Size(1203, 758);
            this.datagrid_quotes.TabIndex = 3;
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 923);
            this.Controls.Add(this.datagrid_quotes);
            this.Controls.Add(this.lbl_MaterialType);
            this.Controls.Add(this.cbo_MaterialType);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "SearchQuotes";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Search Quotes by Material Type";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchQuotes_FormClosing);
            this.Load += new System.EventHandler(this.SearchQuotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_quotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_MaterialType;
        private System.Windows.Forms.Label lbl_MaterialType;
        private System.Windows.Forms.DataGridView datagrid_quotes;
    }
}