namespace internet_shop_ct.UI
{
    partial class LoginWindow
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
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.PhoneNumberText = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.Register = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(3, 49);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(311, 49);
            this.PhoneNumberLabel.TabIndex = 0;
            this.PhoneNumberLabel.Text = "Номер телефона";
            this.PhoneNumberLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // PhoneNumberText
            // 
            this.PhoneNumberText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PhoneNumberText.Location = new System.Drawing.Point(3, 101);
            this.PhoneNumberText.Name = "PhoneNumberText";
            this.PhoneNumberText.Size = new System.Drawing.Size(311, 36);
            this.PhoneNumberText.TabIndex = 1;
            this.PhoneNumberText.Text = "+7";
            this.PhoneNumberText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PhoneNumberText_KeyDown);
            this.PhoneNumberText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneNumberText_KeyPress);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PasswordLabel.Location = new System.Drawing.Point(3, 147);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(311, 49);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Пароль";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // PasswordText
            // 
            this.PasswordText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PasswordText.Location = new System.Drawing.Point(3, 199);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.PasswordChar = '•';
            this.PasswordText.Size = new System.Drawing.Size(311, 36);
            this.PasswordText.TabIndex = 3;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginLabel.Location = new System.Drawing.Point(3, 0);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(311, 49);
            this.LoginLabel.TabIndex = 4;
            this.LoginLabel.Text = "Вход";
            this.LoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.LoginButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Location = new System.Drawing.Point(3, 297);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(311, 43);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "Войти";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LoginButton_MouseClick);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ErrorLabel.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ErrorLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.ErrorLabel.Location = new System.Drawing.Point(3, 245);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(311, 49);
            this.ErrorLabel.TabIndex = 6;
            this.ErrorLabel.Text = "Ошибка";
            this.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ErrorLabel.Visible = false;
            // 
            // Register
            // 
            this.Register.AutoSize = true;
            this.Register.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Register.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Register.LinkColor = System.Drawing.Color.Gray;
            this.Register.Location = new System.Drawing.Point(3, 343);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(311, 52);
            this.Register.TabIndex = 7;
            this.Register.TabStop = true;
            this.Register.Text = "Зарегистрироваться?";
            this.Register.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Register_LinkClicked);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.LoginLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Register, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.PhoneNumberLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LoginButton, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.ErrorLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.PhoneNumberText, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.PasswordLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.PasswordText, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(317, 395);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // LoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 395);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label PhoneNumberLabel;
        private TextBox PhoneNumberText;
        private Label PasswordLabel;
        private TextBox PasswordText;
        private Label LoginLabel;
        private Button LoginButton;
        private Label ErrorLabel;
        private LinkLabel Register;
        private TableLayoutPanel tableLayoutPanel1;
    }
}