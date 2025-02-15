namespace windowsdekstop
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            panel1 = new Panel();
            Registerlabel3 = new Label();
            UserSurname = new TextBox();
            Login = new TextBox();
            button1 = new Button();
            buttonLogin = new Button();
            UserName = new TextBox();
            Password = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            closebutton = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Green;
            panel1.Controls.Add(Registerlabel3);
            panel1.Controls.Add(UserSurname);
            panel1.Controls.Add(Login);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(buttonLogin);
            panel1.Controls.Add(UserName);
            panel1.Controls.Add(Password);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(0, 94);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 356);
            panel1.TabIndex = 2;
            // 
            // Registerlabel3
            // 
            Registerlabel3.AutoSize = true;
            Registerlabel3.Font = new Font("Stencil", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Registerlabel3.ForeColor = SystemColors.ControlLightLight;
            Registerlabel3.Location = new Point(353, 297);
            Registerlabel3.Name = "Registerlabel3";
            Registerlabel3.Size = new Size(138, 18);
            Registerlabel3.TabIndex = 4;
            Registerlabel3.Text = "Уже есть аккаунт?";
            Registerlabel3.Click += Registerlabel3_Click_1;
            // 
            // UserSurname
            // 
            UserSurname.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            UserSurname.Location = new Point(546, 36);
            UserSurname.Multiline = true;
            UserSurname.Name = "UserSurname";
            UserSurname.Size = new Size(229, 64);
            UserSurname.TabIndex = 6;
            UserSurname.Enter += UserSurname_Enter;
            UserSurname.Leave += UserSurname_Leave;
            // 
            // Login
            // 
            Login.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Login.Location = new Point(92, 155);
            Login.Multiline = true;
            Login.Name = "Login";
            Login.Size = new Size(229, 64);
            Login.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Green;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(186, 245);
            button1.Name = "button1";
            button1.Size = new Size(456, 49);
            button1.TabIndex = 4;
            button1.Text = "Зарегистрироваться";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.Green;
            buttonLogin.Cursor = Cursors.Hand;
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonLogin.FlatAppearance.MouseDownBackColor = Color.Green;
            buttonLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonLogin.ForeColor = SystemColors.Control;
            buttonLogin.Location = new Point(92, 342);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(192, 49);
            buttonLogin.TabIndex = 2;
            buttonLogin.Text = "Войти";
            buttonLogin.UseVisualStyleBackColor = false;
            // 
            // UserName
            // 
            UserName.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            UserName.Location = new Point(92, 36);
            UserName.Multiline = true;
            UserName.Name = "UserName";
            UserName.Size = new Size(229, 64);
            UserName.TabIndex = 1;
            UserName.TextChanged += UserName_TextChanged;
            UserName.Enter += UserName_Enter;
            UserName.Leave += UserName_Leave;
            // 
            // Password
            // 
            Password.AutoCompleteMode = AutoCompleteMode.Suggest;
            Password.Font = new Font("Segoe UI", 32.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Password.Location = new Point(546, 154);
            Password.Name = "Password";
            Password.Size = new Size(229, 65);
            Password.TabIndex = 1;
            Password.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(22, 155);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(476, 155);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(closebutton);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 94);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            panel2.MouseDown += panel2_MouseDown;
            panel2.MouseMove += panel2_MouseMove;
            // 
            // closebutton
            // 
            closebutton.BackColor = Color.DarkRed;
            closebutton.BackgroundImageLayout = ImageLayout.Zoom;
            closebutton.Cursor = Cursors.Hand;
            closebutton.FlatAppearance.BorderColor = Color.White;
            closebutton.FlatAppearance.MouseDownBackColor = Color.Red;
            closebutton.FlatStyle = FlatStyle.Flat;
            closebutton.Font = new Font("Avignon Pro", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            closebutton.ForeColor = Color.White;
            closebutton.Location = new Point(778, 0);
            closebutton.Name = "closebutton";
            closebutton.RightToLeft = RightToLeft.Yes;
            closebutton.Size = new Size(22, 27);
            closebutton.TabIndex = 2;
            closebutton.Text = "X";
            closebutton.UseVisualStyleBackColor = false;
            closebutton.Click += closebutton_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Stencil", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 34);
            label1.Name = "label1";
            label1.Size = new Size(797, 60);
            label1.TabIndex = 0;
            label1.Text = "Регистрация";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            Text = "RegisterForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonLogin;
        private TextBox UserName;
        private TextBox Password;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button closebutton;
        private Label label1;
        private Button button1;
        private TextBox UserSurname;
        private TextBox Login;
        private Label Registerlabel3;
    }
}