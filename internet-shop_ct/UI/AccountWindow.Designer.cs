﻿namespace internet_shop_ct.UI
{
    partial class AccountWindow
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
            this.PersonalCabinetLabel = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.PersonalDataTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.RegisterDateLabel = new System.Windows.Forms.Label();
            this.RegisterDate = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.UserNameText = new System.Windows.Forms.TextBox();
            this.UserNameButton = new System.Windows.Forms.Button();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.PhoneNumberText = new System.Windows.Forms.TextBox();
            this.PhoneNumberButton = new System.Windows.Forms.Button();
            this.PasswordConfirmButton = new System.Windows.Forms.Button();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.PasswordConfirmLabel = new System.Windows.Forms.Label();
            this.PasswordConfirmText = new System.Windows.Forms.TextBox();
            this.SaveChangeButton = new System.Windows.Forms.Button();
            this.OrdersTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.OrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PickUpPoint = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PaymentMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Change = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SaveChangeOrder = new System.Windows.Forms.Button();
            this.FeedbacksTab = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.FeedbackDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountRegistratedDaysLabel = new System.Windows.Forms.Label();
            this.CountDays = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.MainPage = new System.Windows.Forms.LinkLabel();
            this.Tabs.SuspendLayout();
            this.PersonalDataTab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.OrdersTab.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.FeedbacksTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PersonalCabinetLabel
            // 
            this.PersonalCabinetLabel.AutoSize = true;
            this.PersonalCabinetLabel.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PersonalCabinetLabel.Location = new System.Drawing.Point(3, 0);
            this.PersonalCabinetLabel.Name = "PersonalCabinetLabel";
            this.PersonalCabinetLabel.Size = new System.Drawing.Size(219, 31);
            this.PersonalCabinetLabel.TabIndex = 0;
            this.PersonalCabinetLabel.Text = "Личный кабинет";
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Dock = System.Windows.Forms.DockStyle.Right;
            this.UserName.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserName.Location = new System.Drawing.Point(1019, 0);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(178, 31);
            this.UserName.TabIndex = 1;
            this.UserName.Text = "Пользователь";
            // 
            // Tabs
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.Tabs, 2);
            this.Tabs.Controls.Add(this.PersonalDataTab);
            this.Tabs.Controls.Add(this.OrdersTab);
            this.Tabs.Controls.Add(this.FeedbacksTab);
            this.Tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tabs.Location = new System.Drawing.Point(3, 34);
            this.Tabs.Name = "Tabs";
            this.tableLayoutPanel3.SetRowSpan(this.Tabs, 3);
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(954, 593);
            this.Tabs.TabIndex = 2;
            // 
            // PersonalDataTab
            // 
            this.PersonalDataTab.Controls.Add(this.tableLayoutPanel1);
            this.PersonalDataTab.Location = new System.Drawing.Point(4, 37);
            this.PersonalDataTab.Name = "PersonalDataTab";
            this.PersonalDataTab.Padding = new System.Windows.Forms.Padding(3);
            this.PersonalDataTab.Size = new System.Drawing.Size(946, 552);
            this.PersonalDataTab.TabIndex = 0;
            this.PersonalDataTab.Text = "Личные данные";
            this.PersonalDataTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.RegisterDateLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.RegisterDate, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.UserNameLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.UserNameText, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.UserNameButton, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.PhoneNumberLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.PhoneNumberText, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.PhoneNumberButton, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.PasswordConfirmButton, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.PasswordLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.PasswordText, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.PasswordConfirmLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.PasswordConfirmText, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.SaveChangeButton, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(940, 546);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // RegisterDateLabel
            // 
            this.RegisterDateLabel.AutoSize = true;
            this.RegisterDateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegisterDateLabel.Location = new System.Drawing.Point(3, 0);
            this.RegisterDateLabel.Name = "RegisterDateLabel";
            this.RegisterDateLabel.Size = new System.Drawing.Size(307, 54);
            this.RegisterDateLabel.TabIndex = 0;
            this.RegisterDateLabel.Text = "Дата регистрации:";
            // 
            // RegisterDate
            // 
            this.RegisterDate.AutoSize = true;
            this.RegisterDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegisterDate.Location = new System.Drawing.Point(316, 0);
            this.RegisterDate.Name = "RegisterDate";
            this.RegisterDate.Size = new System.Drawing.Size(307, 54);
            this.RegisterDate.TabIndex = 1;
            this.RegisterDate.Text = "00.00.00";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserNameLabel.Location = new System.Drawing.Point(3, 54);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(307, 54);
            this.UserNameLabel.TabIndex = 2;
            this.UserNameLabel.Text = "Имя:";
            // 
            // UserNameText
            // 
            this.UserNameText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserNameText.Location = new System.Drawing.Point(316, 57);
            this.UserNameText.Name = "UserNameText";
            this.UserNameText.ReadOnly = true;
            this.UserNameText.Size = new System.Drawing.Size(307, 36);
            this.UserNameText.TabIndex = 3;
            // 
            // UserNameButton
            // 
            this.UserNameButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserNameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserNameButton.Location = new System.Drawing.Point(629, 57);
            this.UserNameButton.Name = "UserNameButton";
            this.UserNameButton.Size = new System.Drawing.Size(308, 36);
            this.UserNameButton.TabIndex = 4;
            this.UserNameButton.Text = "Изменить ...";
            this.UserNameButton.UseVisualStyleBackColor = true;
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(3, 108);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(307, 54);
            this.PhoneNumberLabel.TabIndex = 5;
            this.PhoneNumberLabel.Text = "Номер телефона:";
            // 
            // PhoneNumberText
            // 
            this.PhoneNumberText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PhoneNumberText.Location = new System.Drawing.Point(316, 111);
            this.PhoneNumberText.Name = "PhoneNumberText";
            this.PhoneNumberText.ReadOnly = true;
            this.PhoneNumberText.Size = new System.Drawing.Size(307, 36);
            this.PhoneNumberText.TabIndex = 6;
            // 
            // PhoneNumberButton
            // 
            this.PhoneNumberButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.PhoneNumberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PhoneNumberButton.Location = new System.Drawing.Point(629, 111);
            this.PhoneNumberButton.Name = "PhoneNumberButton";
            this.PhoneNumberButton.Size = new System.Drawing.Size(308, 36);
            this.PhoneNumberButton.TabIndex = 7;
            this.PhoneNumberButton.Text = "Изменить ...";
            this.PhoneNumberButton.UseVisualStyleBackColor = true;
            // 
            // PasswordConfirmButton
            // 
            this.PasswordConfirmButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.PasswordConfirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasswordConfirmButton.Location = new System.Drawing.Point(629, 165);
            this.PasswordConfirmButton.Name = "PasswordConfirmButton";
            this.PasswordConfirmButton.Size = new System.Drawing.Size(308, 36);
            this.PasswordConfirmButton.TabIndex = 8;
            this.PasswordConfirmButton.Text = "Изменить ...";
            this.PasswordConfirmButton.UseVisualStyleBackColor = true;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PasswordLabel.Location = new System.Drawing.Point(3, 162);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(307, 54);
            this.PasswordLabel.TabIndex = 9;
            this.PasswordLabel.Text = "Пароль:";
            // 
            // PasswordText
            // 
            this.PasswordText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PasswordText.Location = new System.Drawing.Point(316, 165);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.ReadOnly = true;
            this.PasswordText.Size = new System.Drawing.Size(307, 36);
            this.PasswordText.TabIndex = 10;
            // 
            // PasswordConfirmLabel
            // 
            this.PasswordConfirmLabel.AutoSize = true;
            this.PasswordConfirmLabel.Location = new System.Drawing.Point(3, 216);
            this.PasswordConfirmLabel.Name = "PasswordConfirmLabel";
            this.PasswordConfirmLabel.Size = new System.Drawing.Size(249, 28);
            this.PasswordConfirmLabel.TabIndex = 11;
            this.PasswordConfirmLabel.Text = "Подтверждение пароля:";
            this.PasswordConfirmLabel.Visible = false;
            // 
            // PasswordConfirmText
            // 
            this.PasswordConfirmText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PasswordConfirmText.Location = new System.Drawing.Point(316, 219);
            this.PasswordConfirmText.Name = "PasswordConfirmText";
            this.PasswordConfirmText.Size = new System.Drawing.Size(307, 36);
            this.PasswordConfirmText.TabIndex = 12;
            this.PasswordConfirmText.Visible = false;
            // 
            // SaveChangeButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.SaveChangeButton, 3);
            this.SaveChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveChangeButton.Location = new System.Drawing.Point(3, 273);
            this.SaveChangeButton.Name = "SaveChangeButton";
            this.SaveChangeButton.Size = new System.Drawing.Size(934, 48);
            this.SaveChangeButton.TabIndex = 13;
            this.SaveChangeButton.Text = "Сохранить изменения";
            this.SaveChangeButton.UseVisualStyleBackColor = true;
            // 
            // OrdersTab
            // 
            this.OrdersTab.Controls.Add(this.tableLayoutPanel2);
            this.OrdersTab.Location = new System.Drawing.Point(4, 29);
            this.OrdersTab.Name = "OrdersTab";
            this.OrdersTab.Padding = new System.Windows.Forms.Padding(3);
            this.OrdersTab.Size = new System.Drawing.Size(946, 560);
            this.OrdersTab.TabIndex = 1;
            this.OrdersTab.Text = "Заказы";
            this.OrdersTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.SaveChangeOrder, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(940, 554);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderNumber,
            this.OrderDate,
            this.PickUpPoint,
            this.PaymentMethod,
            this.Sum,
            this.Change});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(934, 492);
            this.dataGridView1.TabIndex = 0;
            // 
            // OrderNumber
            // 
            this.OrderNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OrderNumber.HeaderText = "Номер";
            this.OrderNumber.MinimumWidth = 6;
            this.OrderNumber.Name = "OrderNumber";
            this.OrderNumber.ReadOnly = true;
            this.OrderNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // OrderDate
            // 
            this.OrderDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OrderDate.HeaderText = "Дата";
            this.OrderDate.MinimumWidth = 6;
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.ReadOnly = true;
            this.OrderDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // PickUpPoint
            // 
            this.PickUpPoint.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PickUpPoint.HeaderText = "Пункт выдачи";
            this.PickUpPoint.MinimumWidth = 6;
            this.PickUpPoint.Name = "PickUpPoint";
            this.PickUpPoint.ReadOnly = true;
            this.PickUpPoint.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PickUpPoint.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // PaymentMethod
            // 
            this.PaymentMethod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PaymentMethod.HeaderText = "Способ оплаты";
            this.PaymentMethod.MinimumWidth = 6;
            this.PaymentMethod.Name = "PaymentMethod";
            this.PaymentMethod.ReadOnly = true;
            this.PaymentMethod.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Sum
            // 
            this.Sum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sum.HeaderText = "Сумма";
            this.Sum.MinimumWidth = 6;
            this.Sum.Name = "Sum";
            this.Sum.ReadOnly = true;
            this.Sum.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Change
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "Изменить ...";
            this.Change.DefaultCellStyle = dataGridViewCellStyle1;
            this.Change.HeaderText = "Изменить пункт выдачи";
            this.Change.MinimumWidth = 6;
            this.Change.Name = "Change";
            this.Change.ReadOnly = true;
            this.Change.Width = 125;
            // 
            // SaveChangeOrder
            // 
            this.SaveChangeOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveChangeOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveChangeOrder.Location = new System.Drawing.Point(3, 501);
            this.SaveChangeOrder.Name = "SaveChangeOrder";
            this.SaveChangeOrder.Size = new System.Drawing.Size(934, 50);
            this.SaveChangeOrder.TabIndex = 1;
            this.SaveChangeOrder.Text = "Сохранить изменения";
            this.SaveChangeOrder.UseVisualStyleBackColor = true;
            // 
            // FeedbacksTab
            // 
            this.FeedbacksTab.Controls.Add(this.dataGridView2);
            this.FeedbacksTab.Location = new System.Drawing.Point(4, 29);
            this.FeedbacksTab.Name = "FeedbacksTab";
            this.FeedbacksTab.Padding = new System.Windows.Forms.Padding(3);
            this.FeedbacksTab.Size = new System.Drawing.Size(946, 560);
            this.FeedbacksTab.TabIndex = 2;
            this.FeedbacksTab.Text = "Отзывы";
            this.FeedbacksTab.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FeedbackDate,
            this.Product,
            this.Rating,
            this.Comment});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(940, 554);
            this.dataGridView2.TabIndex = 0;
            // 
            // FeedbackDate
            // 
            this.FeedbackDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FeedbackDate.HeaderText = "Дата";
            this.FeedbackDate.MinimumWidth = 6;
            this.FeedbackDate.Name = "FeedbackDate";
            this.FeedbackDate.ReadOnly = true;
            this.FeedbackDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Product
            // 
            this.Product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Product.HeaderText = "Товар";
            this.Product.MinimumWidth = 6;
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            this.Product.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Rating
            // 
            this.Rating.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Rating.HeaderText = "Оценка";
            this.Rating.MinimumWidth = 6;
            this.Rating.Name = "Rating";
            this.Rating.ReadOnly = true;
            this.Rating.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Comment
            // 
            this.Comment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Comment.HeaderText = "Комментарий";
            this.Comment.MinimumWidth = 6;
            this.Comment.Name = "Comment";
            this.Comment.ReadOnly = true;
            this.Comment.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CountRegistratedDaysLabel
            // 
            this.CountRegistratedDaysLabel.AutoSize = true;
            this.CountRegistratedDaysLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.CountRegistratedDaysLabel.Location = new System.Drawing.Point(1013, 31);
            this.CountRegistratedDaysLabel.Name = "CountRegistratedDaysLabel";
            this.CountRegistratedDaysLabel.Size = new System.Drawing.Size(184, 31);
            this.CountRegistratedDaysLabel.TabIndex = 3;
            this.CountRegistratedDaysLabel.Text = "Зарегистрирован:";
            // 
            // CountDays
            // 
            this.CountDays.AutoSize = true;
            this.CountDays.Dock = System.Windows.Forms.DockStyle.Right;
            this.CountDays.Location = new System.Drawing.Point(1120, 62);
            this.CountDays.Name = "CountDays";
            this.CountDays.Size = new System.Drawing.Size(77, 31);
            this.CountDays.TabIndex = 4;
            this.CountDays.Text = "0 дней";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.UserName, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.Tabs, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.CountDays, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.PersonalCabinetLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.CountRegistratedDaysLabel, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.MainPage, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1200, 630);
            this.tableLayoutPanel3.TabIndex = 5;
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // MainPage
            // 
            this.MainPage.AutoSize = true;
            this.MainPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPage.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MainPage.LinkColor = System.Drawing.Color.Black;
            this.MainPage.Location = new System.Drawing.Point(363, 0);
            this.MainPage.Name = "MainPage";
            this.MainPage.Size = new System.Drawing.Size(594, 31);
            this.MainPage.TabIndex = 5;
            this.MainPage.TabStop = true;
            this.MainPage.Text = "Главная";
            this.MainPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AccountWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 630);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AccountWindow";
            this.Text = "Интернет-магазин цифровой техники";
            this.Load += new System.EventHandler(this.AccountWindow_Load);
            this.Tabs.ResumeLayout(false);
            this.PersonalDataTab.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.OrdersTab.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.FeedbacksTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label PersonalCabinetLabel;
        private Label UserName;
        private TabControl Tabs;
        private TabPage PersonalDataTab;
        private TabPage OrdersTab;
        private Label CountRegistratedDaysLabel;
        private Label CountDays;
        private TabPage FeedbacksTab;
        private TableLayoutPanel tableLayoutPanel1;
        private Label RegisterDateLabel;
        private Label RegisterDate;
        private Label UserNameLabel;
        private TextBox UserNameText;
        private Button UserNameButton;
        private Label PhoneNumberLabel;
        private TextBox PhoneNumberText;
        private Button PhoneNumberButton;
        private Button PasswordConfirmButton;
        private Label PasswordLabel;
        private TextBox PasswordText;
        private Label PasswordConfirmLabel;
        private TextBox PasswordConfirmText;
        private Button SaveChangeButton;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn OrderNumber;
        private DataGridViewTextBoxColumn OrderDate;
        private DataGridViewComboBoxColumn PickUpPoint;
        private DataGridViewTextBoxColumn PaymentMethod;
        private DataGridViewTextBoxColumn Sum;
        private DataGridViewButtonColumn Change;
        private Button SaveChangeOrder;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn FeedbackDate;
        private DataGridViewTextBoxColumn Product;
        private DataGridViewTextBoxColumn Rating;
        private DataGridViewTextBoxColumn Comment;
        private TableLayoutPanel tableLayoutPanel3;
        private LinkLabel MainPage;
    }
}