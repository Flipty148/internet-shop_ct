namespace internet_shop_ct.internet_shop_ct.UI
{
    partial class ProductWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ProductName = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.CharacteristicsTab = new System.Windows.Forms.TabPage();
            this.CharacteristicsTable = new System.Windows.Forms.DataGridView();
            this.Characteristic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CharacteristicValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FeedbacksTab = new System.Windows.Forms.TabPage();
            this.FeedbackTable = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserRating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rating = new System.Windows.Forms.Label();
            this.Buy = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Tabs.SuspendLayout();
            this.CharacteristicsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CharacteristicsTable)).BeginInit();
            this.FeedbacksTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FeedbackTable)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductName
            // 
            this.ProductName.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.ProductName, 2);
            this.ProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductName.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProductName.Location = new System.Drawing.Point(3, 0);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(646, 51);
            this.ProductName.TabIndex = 0;
            this.ProductName.Text = "Название";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Price.Location = new System.Drawing.Point(3, 51);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(320, 51);
            this.Price.TabIndex = 1;
            this.Price.Text = "Цена";
            // 
            // Tabs
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.Tabs, 2);
            this.Tabs.Controls.Add(this.CharacteristicsTab);
            this.Tabs.Controls.Add(this.FeedbacksTab);
            this.Tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tabs.Location = new System.Drawing.Point(3, 105);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(646, 351);
            this.Tabs.TabIndex = 2;
            // 
            // CharacteristicsTab
            // 
            this.CharacteristicsTab.Controls.Add(this.CharacteristicsTable);
            this.CharacteristicsTab.Location = new System.Drawing.Point(4, 37);
            this.CharacteristicsTab.Name = "CharacteristicsTab";
            this.CharacteristicsTab.Padding = new System.Windows.Forms.Padding(3);
            this.CharacteristicsTab.Size = new System.Drawing.Size(638, 310);
            this.CharacteristicsTab.TabIndex = 0;
            this.CharacteristicsTab.Text = "Характеристики";
            this.CharacteristicsTab.UseVisualStyleBackColor = true;
            // 
            // CharacteristicsTable
            // 
            this.CharacteristicsTable.AllowUserToAddRows = false;
            this.CharacteristicsTable.AllowUserToDeleteRows = false;
            this.CharacteristicsTable.AllowUserToResizeColumns = false;
            this.CharacteristicsTable.AllowUserToResizeRows = false;
            this.CharacteristicsTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.CharacteristicsTable.BackgroundColor = System.Drawing.Color.White;
            this.CharacteristicsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CharacteristicsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Characteristic,
            this.Description,
            this.CharacteristicValue});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CharacteristicsTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.CharacteristicsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CharacteristicsTable.Location = new System.Drawing.Point(3, 3);
            this.CharacteristicsTable.MultiSelect = false;
            this.CharacteristicsTable.Name = "CharacteristicsTable";
            this.CharacteristicsTable.ReadOnly = true;
            this.CharacteristicsTable.RowHeadersVisible = false;
            this.CharacteristicsTable.RowHeadersWidth = 51;
            this.CharacteristicsTable.RowTemplate.Height = 29;
            this.CharacteristicsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CharacteristicsTable.Size = new System.Drawing.Size(632, 304);
            this.CharacteristicsTable.TabIndex = 0;
            // 
            // Characteristic
            // 
            this.Characteristic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Characteristic.DefaultCellStyle = dataGridViewCellStyle1;
            this.Characteristic.HeaderText = "Характеристика";
            this.Characteristic.MinimumWidth = 6;
            this.Characteristic.Name = "Characteristic";
            this.Characteristic.ReadOnly = true;
            this.Characteristic.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Description.DefaultCellStyle = dataGridViewCellStyle2;
            this.Description.HeaderText = "Описание";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // CharacteristicValue
            // 
            this.CharacteristicValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CharacteristicValue.HeaderText = "Значение";
            this.CharacteristicValue.MinimumWidth = 6;
            this.CharacteristicValue.Name = "CharacteristicValue";
            this.CharacteristicValue.ReadOnly = true;
            this.CharacteristicValue.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // FeedbacksTab
            // 
            this.FeedbacksTab.Controls.Add(this.FeedbackTable);
            this.FeedbacksTab.Location = new System.Drawing.Point(4, 29);
            this.FeedbacksTab.Name = "FeedbacksTab";
            this.FeedbacksTab.Padding = new System.Windows.Forms.Padding(3);
            this.FeedbacksTab.Size = new System.Drawing.Size(638, 318);
            this.FeedbacksTab.TabIndex = 1;
            this.FeedbacksTab.Text = "Отзывы";
            this.FeedbacksTab.UseVisualStyleBackColor = true;
            // 
            // FeedbackTable
            // 
            this.FeedbackTable.AllowUserToAddRows = false;
            this.FeedbackTable.AllowUserToDeleteRows = false;
            this.FeedbackTable.AllowUserToResizeColumns = false;
            this.FeedbackTable.AllowUserToResizeRows = false;
            this.FeedbackTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.FeedbackTable.BackgroundColor = System.Drawing.Color.White;
            this.FeedbackTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FeedbackTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.UserRating,
            this.Comment,
            this.Date});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FeedbackTable.DefaultCellStyle = dataGridViewCellStyle5;
            this.FeedbackTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FeedbackTable.Location = new System.Drawing.Point(3, 3);
            this.FeedbackTable.MultiSelect = false;
            this.FeedbackTable.Name = "FeedbackTable";
            this.FeedbackTable.ReadOnly = true;
            this.FeedbackTable.RowHeadersVisible = false;
            this.FeedbackTable.RowHeadersWidth = 51;
            this.FeedbackTable.RowTemplate.Height = 29;
            this.FeedbackTable.Size = new System.Drawing.Size(632, 312);
            this.FeedbackTable.TabIndex = 0;
            // 
            // UserName
            // 
            this.UserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserName.HeaderText = "Имя";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // UserRating
            // 
            this.UserRating.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserRating.HeaderText = "Оценка";
            this.UserRating.MinimumWidth = 6;
            this.UserRating.Name = "UserRating";
            this.UserRating.ReadOnly = true;
            this.UserRating.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Comment
            // 
            this.Comment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Comment.DefaultCellStyle = dataGridViewCellStyle4;
            this.Comment.HeaderText = "Комментарий";
            this.Comment.MinimumWidth = 6;
            this.Comment.Name = "Comment";
            this.Comment.ReadOnly = true;
            this.Comment.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date.HeaderText = "Дата";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Rating
            // 
            this.Rating.AutoSize = true;
            this.Rating.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rating.Location = new System.Drawing.Point(329, 51);
            this.Rating.Name = "Rating";
            this.Rating.Size = new System.Drawing.Size(320, 51);
            this.Rating.TabIndex = 3;
            this.Rating.Text = "5.0★";
            // 
            // Buy
            // 
            this.Buy.BackColor = System.Drawing.Color.LightGreen;
            this.tableLayoutPanel1.SetColumnSpan(this.Buy, 2);
            this.Buy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Buy.FlatAppearance.BorderSize = 0;
            this.Buy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.YellowGreen;
            this.Buy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Buy.Location = new System.Drawing.Point(3, 462);
            this.Buy.Name = "Buy";
            this.Buy.Size = new System.Drawing.Size(646, 45);
            this.Buy.TabIndex = 5;
            this.Buy.Text = "Добавить в корзину";
            this.Buy.UseVisualStyleBackColor = false;
            this.Buy.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Buy_MouseClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ProductName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Buy, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Price, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Tabs, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Rating, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(652, 510);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // ProductWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 510);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductWindow";
            this.Text = "Товар";
            this.Load += new System.EventHandler(this.ProductWindow_Load);
            this.Tabs.ResumeLayout(false);
            this.CharacteristicsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CharacteristicsTable)).EndInit();
            this.FeedbacksTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FeedbackTable)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label ProductName;
        private Label Price;
        private TabControl Tabs;
        private TabPage CharacteristicsTab;
        private TabPage FeedbacksTab;
        private Label Rating;
        private Button Buy;
        private DataGridView CharacteristicsTable;
        private DataGridView FeedbackTable;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn UserRating;
        private DataGridViewTextBoxColumn Comment;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Characteristic;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn CharacteristicValue;
    }
}