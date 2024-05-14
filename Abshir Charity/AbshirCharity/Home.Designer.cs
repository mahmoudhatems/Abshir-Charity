namespace AbshirCharity
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            panel1 = new Panel();
            monthly = new Button();
            cases = new Button();
            Donorsbutt = new Button();
            pictureBox1 = new PictureBox();
            Mainpanl = new Panel();
            Exitbutt = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 171, 156);
            panel1.Controls.Add(Exitbutt);
            panel1.Controls.Add(monthly);
            panel1.Controls.Add(cases);
            panel1.Controls.Add(Donorsbutt);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 709);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // monthly
            // 
            monthly.FlatAppearance.BorderSize = 3;
            monthly.FlatStyle = FlatStyle.Flat;
            monthly.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            monthly.ForeColor = Color.White;
            monthly.Location = new Point(32, 522);
            monthly.Name = "monthly";
            monthly.Size = new Size(236, 75);
            monthly.TabIndex = 1;
            monthly.Text = "Monthly ";
            monthly.UseVisualStyleBackColor = true;
            monthly.Click += monthly_Click;
            // 
            // cases
            // 
            cases.FlatAppearance.BorderSize = 3;
            cases.FlatStyle = FlatStyle.Flat;
            cases.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            cases.ForeColor = Color.White;
            cases.Location = new Point(32, 400);
            cases.Name = "cases";
            cases.Size = new Size(236, 72);
            cases.TabIndex = 1;
            cases.Text = "Cases";
            cases.UseVisualStyleBackColor = true;
            cases.Click += cases_Click;
            // 
            // Donorsbutt
            // 
            Donorsbutt.FlatAppearance.BorderSize = 3;
            Donorsbutt.FlatStyle = FlatStyle.Flat;
            Donorsbutt.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            Donorsbutt.ForeColor = Color.White;
            Donorsbutt.Location = new Point(32, 267);
            Donorsbutt.Name = "Donorsbutt";
            Donorsbutt.Size = new Size(236, 72);
            Donorsbutt.TabIndex = 1;
            Donorsbutt.Text = "Donors";
            Donorsbutt.UseVisualStyleBackColor = true;
            Donorsbutt.Click += Donorsbutt_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(50, 171, 156);
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(32, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(236, 200);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Mainpanl
            // 
            Mainpanl.BackColor = Color.Transparent;
            Mainpanl.BackgroundImageLayout = ImageLayout.None;
            Mainpanl.Dock = DockStyle.Fill;
            Mainpanl.Location = new Point(300, 0);
            Mainpanl.Name = "Mainpanl";
            Mainpanl.Size = new Size(771, 709);
            Mainpanl.TabIndex = 2;
            Mainpanl.Paint += Mainpanl_Paint;
            // 
            // Exitbutt
            // 
            Exitbutt.FlatStyle = FlatStyle.Flat;
            Exitbutt.ForeColor = Color.Maroon;
            Exitbutt.Location = new Point(12, 12);
            Exitbutt.Name = "Exitbutt";
            Exitbutt.Size = new Size(48, 40);
            Exitbutt.TabIndex = 0;
            Exitbutt.Text = "X";
            Exitbutt.UseVisualStyleBackColor = true;
            Exitbutt.Click += Exitbutt_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1071, 709);
            Controls.Add(Mainpanl);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            Text = "Home";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button monthly;
        private Button cases;
        private Button Donorsbutt;
        private Panel Mainpanl;
        private Button Exitbutt;
    }
}