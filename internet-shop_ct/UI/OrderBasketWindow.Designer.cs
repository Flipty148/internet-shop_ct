namespace internet_shop_ct.UI
{
    partial class OrderBasketWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ProductsTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Minus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.Label();
            this.PickupPointLabel = new System.Windows.Forms.Label();
            this.PickUpPointBox = new System.Windows.Forms.ComboBox();
            this.PaymentMethodLabel = new System.Windows.Forms.Label();
            this.PaymentMethodBox = new System.Windows.Forms.ComboBox();
            this.OrderButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsTable)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductsTable
            // 
            this.ProductsTable.BackgroundColor = System.Drawing.Color.White;
            this.ProductsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Minus,
            this.Count,
            this.Plus,
            this.Delete});
            this.tableLayoutPanel1.SetColumnSpan(this.ProductsTable, 2);
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductsTable.DefaultCellStyle = dataGridViewCellStyle4;
            this.ProductsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductsTable.Location = new System.Drawing.Point(3, 3);
            this.ProductsTable.MultiSelect = false;
            this.ProductsTable.Name = "ProductsTable";
            this.ProductsTable.ReadOnly = true;
            this.ProductsTable.RowHeadersVisible = false;
            this.ProductsTable.RowHeadersWidth = 51;
            this.ProductsTable.RowTemplate.Height = 29;
            this.ProductsTable.Size = new System.Drawing.Size(646, 318);
            this.ProductsTable.TabIndex = 0;
            this.ProductsTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsTable_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Товар";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Minus
            // 
            this.Minus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle1.NullValue = "-";
            this.Minus.DefaultCellStyle = dataGridViewCellStyle1;
            this.Minus.FillWeight = 20F;
            this.Minus.HeaderText = "-";
            this.Minus.MinimumWidth = 6;
            this.Minus.Name = "Minus";
            this.Minus.ReadOnly = true;
            this.Minus.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Count
            // 
            this.Count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Count.FillWeight = 70F;
            this.Count.HeaderText = "Кол-во";
            this.Count.MinimumWidth = 6;
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            this.Count.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Plus
            // 
            this.Plus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle2.NullValue = "+";
            this.Plus.DefaultCellStyle = dataGridViewCellStyle2;
            this.Plus.FillWeight = 20F;
            this.Plus.HeaderText = "+";
            this.Plus.MinimumWidth = 6;
            this.Plus.Name = "Plus";
            this.Plus.ReadOnly = true;
            this.Plus.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.NullValue = "X";
            this.Delete.DefaultCellStyle = dataGridViewCellStyle3;
            this.Delete.FillWeight = 60F;
            this.Delete.HeaderText = "Удалить";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductName.HeaderText = "Товар";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ProductPrice
            // 
            this.ProductPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductPrice.HeaderText = "Цена";
            this.ProductPrice.MinimumWidth = 6;
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.ReadOnly = true;
            this.ProductPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TotalPrice
            // 
            this.TotalPrice.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.TotalPrice, 2);
            this.TotalPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TotalPrice.Location = new System.Drawing.Point(3, 324);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(646, 54);
            this.TotalPrice.TabIndex = 1;
            this.TotalPrice.Text = "Итого:";
            this.TotalPrice.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // PickupPointLabel
            // 
            this.PickupPointLabel.AutoSize = true;
            this.PickupPointLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PickupPointLabel.Location = new System.Drawing.Point(3, 378);
            this.PickupPointLabel.Name = "PickupPointLabel";
            this.PickupPointLabel.Size = new System.Drawing.Size(320, 54);
            this.PickupPointLabel.TabIndex = 2;
            this.PickupPointLabel.Text = "Пункт выдачи";
            this.PickupPointLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // PickUpPointBox
            // 
            this.PickUpPointBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PickUpPointBox.FormattingEnabled = true;
            this.PickUpPointBox.Location = new System.Drawing.Point(329, 401);
            this.PickUpPointBox.Name = "PickUpPointBox";
            this.PickUpPointBox.Size = new System.Drawing.Size(320, 36);
            this.PickUpPointBox.TabIndex = 3;
            // 
            // PaymentMethodLabel
            // 
            this.PaymentMethodLabel.AutoSize = true;
            this.PaymentMethodLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PaymentMethodLabel.Location = new System.Drawing.Point(3, 432);
            this.PaymentMethodLabel.Name = "PaymentMethodLabel";
            this.PaymentMethodLabel.Size = new System.Drawing.Size(320, 54);
            this.PaymentMethodLabel.TabIndex = 4;
            this.PaymentMethodLabel.Text = "Способ оплаты";
            this.PaymentMethodLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // PaymentMethodBox
            // 
            this.PaymentMethodBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PaymentMethodBox.FormattingEnabled = true;
            this.PaymentMethodBox.Location = new System.Drawing.Point(329, 447);
            this.PaymentMethodBox.Name = "PaymentMethodBox";
            this.PaymentMethodBox.Size = new System.Drawing.Size(320, 36);
            this.PaymentMethodBox.TabIndex = 5;
            // 
            // OrderButton
            // 
            this.OrderButton.BackColor = System.Drawing.Color.LawnGreen;
            this.tableLayoutPanel1.SetColumnSpan(this.OrderButton, 2);
            this.OrderButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderButton.FlatAppearance.BorderSize = 0;
            this.OrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderButton.Location = new System.Drawing.Point(3, 489);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Padding = new System.Windows.Forms.Padding(5);
            this.OrderButton.Size = new System.Drawing.Size(646, 49);
            this.OrderButton.TabIndex = 6;
            this.OrderButton.Text = "Оформить заказ";
            this.OrderButton.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ProductsTable, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.OrderButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.TotalPrice, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.PaymentMethodBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.PickupPointLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.PaymentMethodLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.PickUpPointBox, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(652, 541);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // OrderBasketWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 541);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrderBasketWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Корзина";
            ((System.ComponentModel.ISupportInitialize)(this.ProductsTable)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView ProductsTable;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn ProductPrice;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Minus;
        private DataGridViewTextBoxColumn Count;
        private DataGridViewTextBoxColumn Plus;
        private DataGridViewTextBoxColumn Delete;
        private Label TotalPrice;
        private Label PickupPointLabel;
        private ComboBox PickUpPointBox;
        private Label PaymentMethodLabel;
        private ComboBox PaymentMethodBox;
        private Button OrderButton;
        private TableLayoutPanel tableLayoutPanel1;
    }
}