namespace AbshirCharity
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            button1 = new Button();
            txtusername = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(465, 716);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(192, 67);
            button1.TabIndex = 0;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtusername
            // 
            txtusername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtusername.Location = new Point(299, 566);
            txtusername.Margin = new Padding(4);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(548, 34);
            txtusername.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(299, 647);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.Size = new Size(548, 34);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(174, 650);
            label1.Name = "label1";
            label1.Size = new Size(101, 28);
            label1.TabIndex = 2;
            label1.Text = "Password";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(299, 569);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(548, 34);
            textBox2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(174, 572);
            label2.Name = "label2";
            label2.Size = new Size(106, 28);
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // Login_Form
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1149, 823);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(txtusername);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Login_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtusername;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
    }
}