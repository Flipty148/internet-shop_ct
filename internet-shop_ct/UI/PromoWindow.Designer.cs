namespace internet_shop_ct.UI
{
    partial class PromoWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PromoName = new System.Windows.Forms.Label();
            this.Percent = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.ConditionsTab = new System.Windows.Forms.TabPage();
            this.ConditionsText = new System.Windows.Forms.TextBox();
            this.DescriptionTab = new System.Windows.Forms.TabPage();
            this.DescriptionText = new System.Windows.Forms.TextBox();
            this.ProductsTab = new System.Windows.Forms.TabPage();
            this.ProductsTable = new System.Windows.Forms.DataGridView();
            this.ProductNameCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPriceCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Tabs.SuspendLayout();
            this.ConditionsTab.SuspendLayout();
            this.DescriptionTab.SuspendLayout();
            this.ProductsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsTable)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PromoName
            // 
            this.PromoName.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.PromoName, 2);
            this.PromoName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PromoName.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PromoName.Location = new System.Drawing.Point(3, 0);
            this.PromoName.Name = "PromoName";
            this.PromoName.Size = new System.Drawing.Size(646, 51);
            this.PromoName.TabIndex = 0;
            this.PromoName.Text = "Название";
            // 
            // Percent
            // 
            this.Percent.AutoSize = true;
            this.Percent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Percent.Location = new System.Drawing.Point(329, 51);
            this.Percent.Name = "Percent";
            this.Percent.Size = new System.Drawing.Size(320, 51);
            this.Percent.TabIndex = 1;
            this.Percent.Text = "5 %";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Date.Location = new System.Drawing.Point(3, 51);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(320, 51);
            this.Date.TabIndex = 2;
            this.Date.Text = "00.00.00 - 00.00.00";
            // 
            // Tabs
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.Tabs, 2);
            this.Tabs.Controls.Add(this.ConditionsTab);
            this.Tabs.Controls.Add(this.DescriptionTab);
            this.Tabs.Controls.Add(this.ProductsTab);
            this.Tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tabs.Location = new System.Drawing.Point(3, 105);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(646, 402);
            this.Tabs.TabIndex = 3;
            // 
            // ConditionsTab
            // 
            this.ConditionsTab.Controls.Add(this.ConditionsText);
            this.ConditionsTab.Location = new System.Drawing.Point(4, 37);
            this.ConditionsTab.Name = "ConditionsTab";
            this.ConditionsTab.Padding = new System.Windows.Forms.Padding(3);
            this.ConditionsTab.Size = new System.Drawing.Size(638, 361);
            this.ConditionsTab.TabIndex = 0;
            this.ConditionsTab.Text = "Условия";
            this.ConditionsTab.UseVisualStyleBackColor = true;
            // 
            // ConditionsText
            // 
            this.ConditionsText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConditionsText.Location = new System.Drawing.Point(3, 3);
            this.ConditionsText.Multiline = true;
            this.ConditionsText.Name = "ConditionsText";
            this.ConditionsText.ReadOnly = true;
            this.ConditionsText.Size = new System.Drawing.Size(632, 355);
            this.ConditionsText.TabIndex = 0;
            this.ConditionsText.Text = "1)\r\n2)\r\n3)";
            // 
            // DescriptionTab
            // 
            this.DescriptionTab.Controls.Add(this.DescriptionText);
            this.DescriptionTab.Location = new System.Drawing.Point(4, 29);
            this.DescriptionTab.Name = "DescriptionTab";
            this.DescriptionTab.Padding = new System.Windows.Forms.Padding(3);
            this.DescriptionTab.Size = new System.Drawing.Size(638, 369);
            this.DescriptionTab.TabIndex = 1;
            this.DescriptionTab.Text = "Описание";
            this.DescriptionTab.UseVisualStyleBackColor = true;
            // 
            // DescriptionText
            // 
            this.DescriptionText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DescriptionText.Location = new System.Drawing.Point(3, 3);
            this.DescriptionText.Multiline = true;
            this.DescriptionText.Name = "DescriptionText";
            this.DescriptionText.ReadOnly = true;
            this.DescriptionText.Size = new System.Drawing.Size(632, 363);
            this.DescriptionText.TabIndex = 0;
            this.DescriptionText.Text = "Описание";
            // 
            // ProductsTab
            // 
            this.ProductsTab.Controls.Add(this.ProductsTable);
            this.ProductsTab.Location = new System.Drawing.Point(4, 37);
            this.ProductsTab.Name = "ProductsTab";
            this.ProductsTab.Padding = new System.Windows.Forms.Padding(3);
            this.ProductsTab.Size = new System.Drawing.Size(638, 361);
            this.ProductsTab.TabIndex = 2;
            this.ProductsTab.Text = "Участвующие товары";
            this.ProductsTab.UseVisualStyleBackColor = true;
            // 
            // ProductsTable
            // 
            this.ProductsTable.AllowUserToAddRows = false;
            this.ProductsTable.AllowUserToDeleteRows = false;
            this.ProductsTable.AllowUserToResizeColumns = false;
            this.ProductsTable.AllowUserToResizeRows = false;
            this.ProductsTable.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ProductsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductNameCategory,
            this.ProductPriceCategory});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductsTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.ProductsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductsTable.Location = new System.Drawing.Point(3, 3);
            this.ProductsTable.MultiSelect = false;
            this.ProductsTable.Name = "ProductsTable";
            this.ProductsTable.ReadOnly = true;
            this.ProductsTable.RowHeadersVisible = false;
            this.ProductsTable.RowHeadersWidth = 51;
            this.ProductsTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ProductsTable.RowTemplate.Height = 29;
            this.ProductsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductsTable.Size = new System.Drawing.Size(632, 355);
            this.ProductsTable.TabIndex = 2;
            // 
            // ProductNameCategory
            // 
            this.ProductNameCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductNameCategory.HeaderText = "Товар";
            this.ProductNameCategory.MinimumWidth = 6;
            this.ProductNameCategory.Name = "ProductNameCategory";
            this.ProductNameCategory.ReadOnly = true;
            this.ProductNameCategory.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ProductPriceCategory
            // 
            this.ProductPriceCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductPriceCategory.HeaderText = "Цена";
            this.ProductPriceCategory.MinimumWidth = 6;
            this.ProductPriceCategory.Name = "ProductPriceCategory";
            this.ProductPriceCategory.ReadOnly = true;
            this.ProductPriceCategory.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.PromoName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Tabs, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Date, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Percent, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(652, 510);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // PromoWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 510);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PromoWindow";
            this.Text = "Акция";
            this.Load += new System.EventHandler(this.PromoWindow_Load);
            this.Tabs.ResumeLayout(false);
            this.ConditionsTab.ResumeLayout(false);
            this.ConditionsTab.PerformLayout();
            this.DescriptionTab.ResumeLayout(false);
            this.DescriptionTab.PerformLayout();
            this.ProductsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsTable)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label PromoName;
        private Label Percent;
        private Label Date;
        private TabControl Tabs;
        private TabPage ConditionsTab;
        private TabPage DescriptionTab;
        private TabPage ProductsTab;
        private TextBox ConditionsText;
        private DataGridView ProductsTable;
        private DataGridViewTextBoxColumn ProductNameCategory;
        private DataGridViewTextBoxColumn ProductPriceCategory;
        private TextBox DescriptionText;
        private TableLayoutPanel tableLayoutPanel1;
    }
}