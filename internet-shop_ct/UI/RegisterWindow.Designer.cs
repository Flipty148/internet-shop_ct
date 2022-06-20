namespace internet_shop_ct.UI
{
    partial class RegisterWindow
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
            this.RegisterLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.UserNameText = new System.Windows.Forms.TextBox();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.PhoneNumberText = new System.Windows.Forms.TextBox();
            this.PasswordFirstLabel = new System.Windows.Forms.Label();
            this.PasswordFirstText = new System.Windows.Forms.TextBox();
            this.PasswordSecond = new System.Windows.Forms.TextBox();
            this.PasswordSecondLabel = new System.Windows.Forms.Label();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegisterLabel
            // 
            this.RegisterLabel.AutoSize = true;
            this.RegisterLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegisterLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegisterLabel.Location = new System.Drawing.Point(3, 0);
            this.RegisterLabel.Name = "RegisterLabel";
            this.RegisterLabel.Size = new System.Drawing.Size(311, 47);
            this.RegisterLabel.TabIndex = 0;
            this.RegisterLabel.Text = "Регистрация";
            this.RegisterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserNameLabel.Location = new System.Drawing.Point(3, 47);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(311, 47);
            this.UserNameLabel.TabIndex = 1;
            this.UserNameLabel.Text = "Имя";
            this.UserNameLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // UserNameText
            // 
            this.UserNameText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserNameText.Location = new System.Drawing.Point(3, 97);
            this.UserNameText.Name = "UserNameText";
            this.UserNameText.Size = new System.Drawing.Size(311, 36);
            this.UserNameText.TabIndex = 2;
            this.UserNameText.TextChanged += new System.EventHandler(this.UserNameText_TextChanged);
            this.UserNameText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserNameText_KeyDown);
            this.UserNameText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserNameText_KeyPress);
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(3, 141);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(311, 47);
            this.PhoneNumberLabel.TabIndex = 3;
            this.PhoneNumberLabel.Text = "Номер телефона";
            this.PhoneNumberLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // PhoneNumberText
            // 
            this.PhoneNumberText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PhoneNumberText.Location = new System.Drawing.Point(3, 191);
            this.PhoneNumberText.Name = "PhoneNumberText";
            this.PhoneNumberText.Size = new System.Drawing.Size(311, 36);
            this.PhoneNumberText.TabIndex = 4;
            this.PhoneNumberText.Text = "+7";
            this.PhoneNumberText.Enter += new System.EventHandler(this.PhoneNumberText_Enter);
            this.PhoneNumberText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PhoneNumberText_KeyDown);
            this.PhoneNumberText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneNumberText_KeyPress);
            // 
            // PasswordFirstLabel
            // 
            this.PasswordFirstLabel.AutoSize = true;
            this.PasswordFirstLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PasswordFirstLabel.Location = new System.Drawing.Point(3, 235);
            this.PasswordFirstLabel.Name = "PasswordFirstLabel";
            this.PasswordFirstLabel.Size = new System.Drawing.Size(311, 47);
            this.PasswordFirstLabel.TabIndex = 5;
            this.PasswordFirstLabel.Text = "Пароль";
            this.PasswordFirstLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // PasswordFirstText
            // 
            this.PasswordFirstText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PasswordFirstText.Location = new System.Drawing.Point(3, 285);
            this.PasswordFirstText.MaxLength = 50;
            this.PasswordFirstText.Name = "PasswordFirstText";
            this.PasswordFirstText.PasswordChar = '•';
            this.PasswordFirstText.Size = new System.Drawing.Size(311, 36);
            this.PasswordFirstText.TabIndex = 6;
            this.PasswordFirstText.TextChanged += new System.EventHandler(this.PasswordFirstText_TextChanged);
            // 
            // PasswordSecond
            // 
            this.PasswordSecond.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PasswordSecond.Location = new System.Drawing.Point(3, 379);
            this.PasswordSecond.MaxLength = 45;
            this.PasswordSecond.Name = "PasswordSecond";
            this.PasswordSecond.PasswordChar = '•';
            this.PasswordSecond.Size = new System.Drawing.Size(311, 36);
            this.PasswordSecond.TabIndex = 8;
            // 
            // PasswordSecondLabel
            // 
            this.PasswordSecondLabel.AutoSize = true;
            this.PasswordSecondLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PasswordSecondLabel.Location = new System.Drawing.Point(3, 329);
            this.PasswordSecondLabel.Name = "PasswordSecondLabel";
            this.PasswordSecondLabel.Size = new System.Drawing.Size(311, 47);
            this.PasswordSecondLabel.TabIndex = 7;
            this.PasswordSecondLabel.Text = "Подтверждение пароля";
            this.PasswordSecondLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // RegisterButton
            // 
            this.RegisterButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.RegisterButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegisterButton.FlatAppearance.BorderSize = 0;
            this.RegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterButton.Location = new System.Drawing.Point(3, 426);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(311, 41);
            this.RegisterButton.TabIndex = 9;
            this.RegisterButton.Text = "Зарегистрироваться";
            this.RegisterButton.UseVisualStyleBackColor = false;
            this.RegisterButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RegisterButton_MouseClick);
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Login.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Login.LinkColor = System.Drawing.Color.Gray;
            this.Login.Location = new System.Drawing.Point(3, 470);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(311, 53);
            this.Login.TabIndex = 10;
            this.Login.TabStop = true;
            this.Login.Text = "Войти?";
            this.Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Login_LinkClicked);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.RegisterLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Login, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.UserNameLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.RegisterButton, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.UserNameText, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.PasswordSecond, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.PhoneNumberLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.PasswordSecondLabel, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.PhoneNumberText, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.PasswordFirstText, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.PasswordFirstLabel, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(317, 523);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // RegisterWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 523);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegisterWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label RegisterLabel;
        private Label UserNameLabel;
        private TextBox UserNameText;
        private Label PhoneNumberLabel;
        private TextBox PhoneNumberText;
        private Label PasswordFirstLabel;
        private TextBox PasswordFirstText;
        private TextBox PasswordSecond;
        private Label PasswordSecondLabel;
        private Button RegisterButton;
        private LinkLabel Login;
        private TableLayoutPanel tableLayoutPanel1;
    }
}