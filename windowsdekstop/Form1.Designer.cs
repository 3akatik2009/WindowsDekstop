namespace windowsdekstop
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            button1 = new Button();
            loginForms = new TextBox();
            passwordForm = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            closebutton = new Button();
            label2 = new Label();
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
            panel1.Controls.Add(button1);
            panel1.Controls.Add(loginForms);
            panel1.Controls.Add(passwordForm);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(390, 463);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
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
            button1.Location = new Point(92, 342);
            button1.Name = "button1";
            button1.Size = new Size(192, 49);
            button1.TabIndex = 2;
            button1.Text = "Войти";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // loginForms
            // 
            loginForms.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginForms.Location = new Point(92, 147);
            loginForms.Multiline = true;
            loginForms.Name = "loginForms";
            loginForms.Size = new Size(229, 64);
            loginForms.TabIndex = 1;
            loginForms.TextChanged += loginForms_TextChanged;
            // 
            // passwordForm
            // 
            passwordForm.AutoCompleteMode = AutoCompleteMode.Suggest;
            passwordForm.Font = new Font("Segoe UI", 32.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passwordForm.Location = new Point(92, 230);
            passwordForm.Name = "passwordForm";
            passwordForm.Size = new Size(229, 65);
            passwordForm.TabIndex = 1;
            passwordForm.UseSystemPasswordChar = true;
            passwordForm.TextChanged += passwordForm_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 147);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 230);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(closebutton);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(390, 119);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
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
            closebutton.Location = new Point(368, 0);
            closebutton.Name = "closebutton";
            closebutton.RightToLeft = RightToLeft.Yes;
            closebutton.Size = new Size(22, 27);
            closebutton.TabIndex = 2;
            closebutton.Text = "X";
            closebutton.UseVisualStyleBackColor = false;
            closebutton.Click += closebutton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Tw Cen MT Condensed Extra Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(762, 0);
            label2.Name = "label2";
            label2.Size = new Size(38, 44);
            label2.TabIndex = 1;
            label2.Text = "X";
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Stencil", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(390, 70);
            label1.TabIndex = 0;
            label1.Text = "Авторизация";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 463);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private TextBox passwordForm;
        private TextBox loginForms;
        private PictureBox pictureBox2;
        private Button button1;
        private Button closebutton;
    }
}