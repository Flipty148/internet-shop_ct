namespace internet_shop_ct
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Login = new System.Windows.Forms.Button();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.ProductsTab = new System.Windows.Forms.TabPage();
            this.ProductsTable = new System.Windows.Forms.DataGridView();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductBuy = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CategoriesTab = new System.Windows.Forms.TabPage();
            this.CategoriesLayout = new System.Windows.Forms.TableLayoutPanel();
            this.CategoriesTable = new System.Windows.Forms.DataGridView();
            this.CategoriesName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoriesProducts = new System.Windows.Forms.DataGridView();
            this.ProductCodeCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductNameCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPriceCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PromosTab = new System.Windows.Forms.TabPage();
            this.PromoTable = new System.Windows.Forms.DataGridView();
            this.IdPromo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PromoName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PromoStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PromoEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PromoPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Basket = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Tabs.SuspendLayout();
            this.ProductsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsTable)).BeginInit();
            this.CategoriesTab.SuspendLayout();
            this.CategoriesLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesProducts)).BeginInit();
            this.PromosTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PromoTable)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Login.FlatAppearance.BorderSize = 0;
            this.Login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Login.Location = new System.Drawing.Point(1063, 3);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(182, 27);
            this.Login.TabIndex = 1;
            this.Login.Text = "Войти";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            // 
            // Tabs
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.Tabs, 3);
            this.Tabs.Controls.Add(this.ProductsTab);
            this.Tabs.Controls.Add(this.CategoriesTab);
            this.Tabs.Controls.Add(this.PromosTab);
            this.Tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tabs.Location = new System.Drawing.Point(3, 36);
            this.Tabs.Name = "Tabs";
            this.tableLayoutPanel1.SetRowSpan(this.Tabs, 2);
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(1242, 657);
            this.Tabs.TabIndex = 0;
            // 
            // ProductsTab
            // 
            this.ProductsTab.Controls.Add(this.ProductsTable);
            this.ProductsTab.Location = new System.Drawing.Point(4, 29);
            this.ProductsTab.Name = "ProductsTab";
            this.ProductsTab.Padding = new System.Windows.Forms.Padding(3);
            this.ProductsTab.Size = new System.Drawing.Size(1234, 624);
            this.ProductsTab.TabIndex = 0;
            this.ProductsTab.Text = "Товары";
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ProductsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductCode,
            this.ProductName,
            this.ProductPrice,
            this.ProductBuy});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductsTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.ProductsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductsTable.GridColor = System.Drawing.Color.Gray;
            this.ProductsTable.Location = new System.Drawing.Point(3, 3);
            this.ProductsTable.MultiSelect = false;
            this.ProductsTable.Name = "ProductsTable";
            this.ProductsTable.ReadOnly = true;
            this.ProductsTable.RowHeadersVisible = false;
            this.ProductsTable.RowHeadersWidth = 51;
            this.ProductsTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ProductsTable.RowTemplate.Height = 50;
            this.ProductsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.ProductsTable.Size = new System.Drawing.Size(1228, 618);
            this.ProductsTable.TabIndex = 0;
            this.ProductsTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsTable_CellContentClick);
            this.ProductsTable.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ProductsTable_CellMouseDoubleClick);
            // 
            // ProductCode
            // 
            this.ProductCode.Frozen = true;
            this.ProductCode.HeaderText = "Код товара";
            this.ProductCode.MinimumWidth = 6;
            this.ProductCode.Name = "ProductCode";
            this.ProductCode.ReadOnly = true;
            this.ProductCode.Visible = false;
            this.ProductCode.Width = 125;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductName.FillWeight = 500F;
            this.ProductName.HeaderText = "Наименование";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ProductPrice
            // 
            this.ProductPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductPrice.FillWeight = 500F;
            this.ProductPrice.HeaderText = "Цена";
            this.ProductPrice.MinimumWidth = 6;
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.ReadOnly = true;
            this.ProductPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ProductBuy
            // 
            this.ProductBuy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.NullValue = "Купить";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.GreenYellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.ProductBuy.DefaultCellStyle = dataGridViewCellStyle2;
            this.ProductBuy.FillWeight = 300F;
            this.ProductBuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ProductBuy.HeaderText = "Добавить в корзину";
            this.ProductBuy.MinimumWidth = 6;
            this.ProductBuy.Name = "ProductBuy";
            this.ProductBuy.ReadOnly = true;
            this.ProductBuy.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductBuy.Text = "Купить";
            this.ProductBuy.UseColumnTextForButtonValue = true;
            // 
            // CategoriesTab
            // 
            this.CategoriesTab.Controls.Add(this.CategoriesLayout);
            this.CategoriesTab.Location = new System.Drawing.Point(4, 29);
            this.CategoriesTab.Name = "CategoriesTab";
            this.CategoriesTab.Padding = new System.Windows.Forms.Padding(3);
            this.CategoriesTab.Size = new System.Drawing.Size(1234, 624);
            this.CategoriesTab.TabIndex = 1;
            this.CategoriesTab.Text = "Категории";
            this.CategoriesTab.UseVisualStyleBackColor = true;
            // 
            // CategoriesLayout
            // 
            this.CategoriesLayout.ColumnCount = 2;
            this.CategoriesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CategoriesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CategoriesLayout.Controls.Add(this.CategoriesTable, 0, 0);
            this.CategoriesLayout.Controls.Add(this.CategoriesProducts, 1, 0);
            this.CategoriesLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CategoriesLayout.Location = new System.Drawing.Point(3, 3);
            this.CategoriesLayout.Name = "CategoriesLayout";
            this.CategoriesLayout.RowCount = 1;
            this.CategoriesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CategoriesLayout.Size = new System.Drawing.Size(1228, 618);
            this.CategoriesLayout.TabIndex = 0;
            // 
            // CategoriesTable
            // 
            this.CategoriesTable.AllowUserToAddRows = false;
            this.CategoriesTable.AllowUserToDeleteRows = false;
            this.CategoriesTable.AllowUserToResizeColumns = false;
            this.CategoriesTable.AllowUserToResizeRows = false;
            this.CategoriesTable.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CategoriesTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.CategoriesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoriesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CategoriesName});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CategoriesTable.DefaultCellStyle = dataGridViewCellStyle5;
            this.CategoriesTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CategoriesTable.Location = new System.Drawing.Point(3, 3);
            this.CategoriesTable.MultiSelect = false;
            this.CategoriesTable.Name = "CategoriesTable";
            this.CategoriesTable.ReadOnly = true;
            this.CategoriesTable.RowHeadersVisible = false;
            this.CategoriesTable.RowHeadersWidth = 51;
            this.CategoriesTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.CategoriesTable.RowTemplate.Height = 29;
            this.CategoriesTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CategoriesTable.Size = new System.Drawing.Size(608, 612);
            this.CategoriesTable.TabIndex = 0;
            this.CategoriesTable.CurrentCellChanged += new System.EventHandler(this.CategoriesTable_CurrentCellChanged);
            // 
            // CategoriesName
            // 
            this.CategoriesName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CategoriesName.HeaderText = "Название";
            this.CategoriesName.MinimumWidth = 6;
            this.CategoriesName.Name = "CategoriesName";
            this.CategoriesName.ReadOnly = true;
            // 
            // CategoriesProducts
            // 
            this.CategoriesProducts.AllowUserToAddRows = false;
            this.CategoriesProducts.AllowUserToDeleteRows = false;
            this.CategoriesProducts.AllowUserToResizeColumns = false;
            this.CategoriesProducts.AllowUserToResizeRows = false;
            this.CategoriesProducts.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CategoriesProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.CategoriesProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoriesProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductCodeCategory,
            this.ProductNameCategory,
            this.ProductPriceCategory});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CategoriesProducts.DefaultCellStyle = dataGridViewCellStyle7;
            this.CategoriesProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CategoriesProducts.Location = new System.Drawing.Point(617, 3);
            this.CategoriesProducts.MultiSelect = false;
            this.CategoriesProducts.Name = "CategoriesProducts";
            this.CategoriesProducts.ReadOnly = true;
            this.CategoriesProducts.RowHeadersVisible = false;
            this.CategoriesProducts.RowHeadersWidth = 51;
            this.CategoriesProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.CategoriesProducts.RowTemplate.Height = 29;
            this.CategoriesProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CategoriesProducts.Size = new System.Drawing.Size(608, 612);
            this.CategoriesProducts.TabIndex = 1;
            this.CategoriesProducts.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CategoriesProducts_CellMouseDoubleClick);
            // 
            // ProductCodeCategory
            // 
            this.ProductCodeCategory.HeaderText = "Код товара";
            this.ProductCodeCategory.MinimumWidth = 6;
            this.ProductCodeCategory.Name = "ProductCodeCategory";
            this.ProductCodeCategory.ReadOnly = true;
            this.ProductCodeCategory.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductCodeCategory.Visible = false;
            this.ProductCodeCategory.Width = 125;
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
            // PromosTab
            // 
            this.PromosTab.Controls.Add(this.PromoTable);
            this.PromosTab.Location = new System.Drawing.Point(4, 29);
            this.PromosTab.Name = "PromosTab";
            this.PromosTab.Padding = new System.Windows.Forms.Padding(3);
            this.PromosTab.Size = new System.Drawing.Size(1234, 624);
            this.PromosTab.TabIndex = 2;
            this.PromosTab.Text = "Акции";
            this.PromosTab.UseVisualStyleBackColor = true;
            // 
            // PromoTable
            // 
            this.PromoTable.AllowUserToAddRows = false;
            this.PromoTable.AllowUserToDeleteRows = false;
            this.PromoTable.AllowUserToResizeColumns = false;
            this.PromoTable.AllowUserToResizeRows = false;
            this.PromoTable.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PromoTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.PromoTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PromoTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPromo,
            this.PromoName,
            this.PromoStartDate,
            this.PromoEndDate,
            this.PromoPercent});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PromoTable.DefaultCellStyle = dataGridViewCellStyle9;
            this.PromoTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PromoTable.Location = new System.Drawing.Point(3, 3);
            this.PromoTable.MultiSelect = false;
            this.PromoTable.Name = "PromoTable";
            this.PromoTable.ReadOnly = true;
            this.PromoTable.RowHeadersVisible = false;
            this.PromoTable.RowHeadersWidth = 51;
            this.PromoTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.PromoTable.RowTemplate.Height = 29;
            this.PromoTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PromoTable.Size = new System.Drawing.Size(1228, 618);
            this.PromoTable.TabIndex = 0;
            this.PromoTable.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.PromoTable_CellMouseDoubleClick);
            // 
            // IdPromo
            // 
            this.IdPromo.HeaderText = "ID акции";
            this.IdPromo.MinimumWidth = 6;
            this.IdPromo.Name = "IdPromo";
            this.IdPromo.ReadOnly = true;
            this.IdPromo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IdPromo.Visible = false;
            this.IdPromo.Width = 125;
            // 
            // PromoName
            // 
            this.PromoName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PromoName.HeaderText = "Название";
            this.PromoName.MinimumWidth = 6;
            this.PromoName.Name = "PromoName";
            this.PromoName.ReadOnly = true;
            this.PromoName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // PromoStartDate
            // 
            this.PromoStartDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PromoStartDate.HeaderText = "Дата начала";
            this.PromoStartDate.MinimumWidth = 6;
            this.PromoStartDate.Name = "PromoStartDate";
            this.PromoStartDate.ReadOnly = true;
            this.PromoStartDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // PromoEndDate
            // 
            this.PromoEndDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PromoEndDate.HeaderText = "Дата окончания";
            this.PromoEndDate.MinimumWidth = 6;
            this.PromoEndDate.Name = "PromoEndDate";
            this.PromoEndDate.ReadOnly = true;
            this.PromoEndDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // PromoPercent
            // 
            this.PromoPercent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PromoPercent.HeaderText = "Размер";
            this.PromoPercent.MinimumWidth = 6;
            this.PromoPercent.Name = "PromoPercent";
            this.PromoPercent.ReadOnly = true;
            this.PromoPercent.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Basket
            // 
            this.Basket.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Basket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Basket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Basket.FlatAppearance.BorderSize = 0;
            this.Basket.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.Basket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Basket.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Basket.Location = new System.Drawing.Point(876, 3);
            this.Basket.Name = "Basket";
            this.Basket.Size = new System.Drawing.Size(181, 27);
            this.Basket.TabIndex = 2;
            this.Basket.Text = "Корзина";
            this.Basket.UseVisualStyleBackColor = false;
            this.Basket.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Basket_MouseClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.Tabs, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Basket, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Login, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1248, 696);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1248, 696);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainWindow";
            this.Text = "Интернет-магазин цифровой техники";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Tabs.ResumeLayout(false);
            this.ProductsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsTable)).EndInit();
            this.CategoriesTab.ResumeLayout(false);
            this.CategoriesLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesProducts)).EndInit();
            this.PromosTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PromoTable)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button Login;
        private TabControl Tabs;
        private TableLayoutPanel tableLayoutPanel1;
        private Button Basket;
        private TabPage ProductsTab;
        private DataGridView ProductsTable;
        private TabPage CategoriesTab;
        private TableLayoutPanel CategoriesLayout;
        private DataGridView CategoriesTable;
        private DataGridViewTextBoxColumn CategoriesName;
        private DataGridView CategoriesProducts;
        private TabPage PromosTab;
        private DataGridView PromoTable;
        private DataGridViewTextBoxColumn ProductCode;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn ProductPrice;
        private DataGridViewButtonColumn ProductBuy;
        private DataGridViewTextBoxColumn ProductCodeCategory;
        private DataGridViewTextBoxColumn ProductNameCategory;
        private DataGridViewTextBoxColumn ProductPriceCategory;
        private DataGridViewTextBoxColumn IdPromo;
        private DataGridViewTextBoxColumn PromoName;
        private DataGridViewTextBoxColumn PromoStartDate;
        private DataGridViewTextBoxColumn PromoEndDate;
        private DataGridViewTextBoxColumn PromoPercent;
    }
}