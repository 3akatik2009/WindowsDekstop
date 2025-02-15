namespace windowsdekstop
{
    partial class MainForm
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
            panel1 = new Panel();
            buttonLogin = new Button();
            panel2 = new Panel();
            closebutton3 = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Green;
            panel1.Controls.Add(buttonLogin);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(0, 94);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 356);
            panel1.TabIndex = 2;
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
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(closebutton3);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 94);
            panel2.TabIndex = 3;
            // 
            // closebutton3
            // 
            closebutton3.BackColor = Color.DarkRed;
            closebutton3.BackgroundImageLayout = ImageLayout.Zoom;
            closebutton3.Cursor = Cursors.Hand;
            closebutton3.FlatAppearance.BorderColor = Color.White;
            closebutton3.FlatAppearance.MouseDownBackColor = Color.Red;
            closebutton3.FlatStyle = FlatStyle.Popup;
            closebutton3.Font = new Font("Avignon Pro", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            closebutton3.ForeColor = Color.White;
            closebutton3.Location = new Point(778, 0);
            closebutton3.Name = "closebutton3";
            closebutton3.RightToLeft = RightToLeft.Yes;
            closebutton3.Size = new Size(22, 27);
            closebutton3.TabIndex = 2;
            closebutton3.Text = "X";
            closebutton3.UseVisualStyleBackColor = false;
            closebutton3.Click += closebutton3_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Stencil", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(-63, 34);
            label1.Name = "label1";
            label1.Size = new Size(990, 60);
            label1.TabIndex = 0;
            label1.Text = "Главный экран";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonLogin;
        private Panel panel2;
        private Button closebutton3;
        private Label label1;
    }
}