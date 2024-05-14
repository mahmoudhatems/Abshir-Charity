namespace AbshirCharity
{
    partial class Donors
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            deletebutt = new Button();
            updatebutt = new Button();
            savebutt = new Button();
            label2 = new Label();
            donorid = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            fullname = new TextBox();
            label3 = new Label();
            city = new TextBox();
            label4 = new Label();
            state = new TextBox();
            label5 = new Label();
            phone = new TextBox();
            label6 = new Label();
            country = new TextBox();
            label7 = new Label();
            service = new TextBox();
            label8 = new Label();
            comment = new TextBox();
            label9 = new Label();
            Designated = new TextBox();
            label10 = new Label();
            Dtype = new TextBox();
            label11 = new Label();
            label12 = new Label();
            Damount = new TextBox();
            label13 = new Label();
            email = new TextBox();
            label14 = new Label();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 490);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(719, 188);
            dataGridView1.TabIndex = 34;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // deletebutt
            // 
            deletebutt.BackColor = Color.Transparent;
            deletebutt.FlatStyle = FlatStyle.Flat;
            deletebutt.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            deletebutt.ForeColor = Color.Maroon;
            deletebutt.Location = new Point(593, 425);
            deletebutt.Name = "deletebutt";
            deletebutt.Size = new Size(134, 44);
            deletebutt.TabIndex = 33;
            deletebutt.Text = "Delete";
            deletebutt.UseVisualStyleBackColor = false;
            deletebutt.Click += deletebutt_Click;
            // 
            // updatebutt
            // 
            updatebutt.BackColor = Color.Transparent;
            updatebutt.FlatStyle = FlatStyle.Flat;
            updatebutt.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            updatebutt.ForeColor = Color.FromArgb(0, 0, 192);
            updatebutt.Location = new Point(355, 425);
            updatebutt.Name = "updatebutt";
            updatebutt.Size = new Size(134, 44);
            updatebutt.TabIndex = 32;
            updatebutt.Text = "Update";
            updatebutt.UseVisualStyleBackColor = false;
            updatebutt.Click += updatebutt_Click;
            // 
            // savebutt
            // 
            savebutt.BackColor = Color.Transparent;
            savebutt.FlatStyle = FlatStyle.Flat;
            savebutt.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            savebutt.ForeColor = Color.FromArgb(50, 171, 156);
            savebutt.Location = new Point(105, 425);
            savebutt.Name = "savebutt";
            savebutt.Size = new Size(134, 44);
            savebutt.TabIndex = 31;
            savebutt.Text = "Save";
            savebutt.UseVisualStyleBackColor = false;
            savebutt.Click += savebutt_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(323, 11);
            label2.Name = "label2";
            label2.Size = new Size(120, 40);
            label2.TabIndex = 1;
            label2.Text = "Donors";
            label2.Click += label2_Click;
            // 
            // donorid
            // 
            donorid.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            donorid.Location = new Point(105, 97);
            donorid.Name = "donorid";
            donorid.Size = new Size(211, 25);
            donorid.TabIndex = 20;
            donorid.TextChanged += donorid_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(23, 98);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 19;
            label1.Text = "Donors ID";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(771, 62);
            panel1.TabIndex = 18;
            // 
            // fullname
            // 
            fullname.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            fullname.Location = new Point(105, 143);
            fullname.Name = "fullname";
            fullname.Size = new Size(211, 25);
            fullname.TabIndex = 36;
            fullname.TextChanged += fullname_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(23, 144);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 35;
            label3.Text = "Full Name";
            // 
            // city
            // 
            city.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            city.Location = new Point(105, 186);
            city.Name = "city";
            city.Size = new Size(211, 25);
            city.TabIndex = 38;
            city.TextChanged += city_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(23, 187);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 37;
            label4.Text = "City";
            // 
            // state
            // 
            state.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            state.Location = new Point(105, 231);
            state.Name = "state";
            state.Size = new Size(211, 25);
            state.TabIndex = 40;
            state.TextChanged += contry_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(23, 232);
            label5.Name = "label5";
            label5.Size = new Size(43, 20);
            label5.TabIndex = 39;
            label5.Text = "State";
            // 
            // phone
            // 
            phone.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            phone.Location = new Point(105, 319);
            phone.Name = "phone";
            phone.Size = new Size(211, 25);
            phone.TabIndex = 44;
            phone.TextChanged += email_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(23, 320);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 43;
            label6.Text = "Phone";
            // 
            // country
            // 
            country.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            country.Location = new Point(105, 274);
            country.Name = "country";
            country.Size = new Size(211, 25);
            country.TabIndex = 42;
            country.TextChanged += phone_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(23, 275);
            label7.Name = "label7";
            label7.Size = new Size(60, 20);
            label7.TabIndex = 41;
            label7.Text = "Country";
            // 
            // service
            // 
            service.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            service.Location = new Point(516, 320);
            service.Name = "service";
            service.Size = new Size(211, 25);
            service.TabIndex = 56;
            service.TextChanged += service_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(369, 319);
            label8.Name = "label8";
            label8.Size = new Size(56, 20);
            label8.TabIndex = 55;
            label8.Text = "Service";
            // 
            // comment
            // 
            comment.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            comment.Location = new Point(516, 275);
            comment.Name = "comment";
            comment.Size = new Size(211, 25);
            comment.TabIndex = 54;
            comment.TextChanged += comment_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(369, 274);
            label9.Name = "label9";
            label9.Size = new Size(74, 20);
            label9.TabIndex = 53;
            label9.Text = "Comment";
            // 
            // Designated
            // 
            Designated.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            Designated.Location = new Point(516, 232);
            Designated.Name = "Designated";
            Designated.Size = new Size(211, 25);
            Designated.TabIndex = 52;
            Designated.TextChanged += Designated_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(369, 233);
            label10.Name = "label10";
            label10.Size = new Size(135, 20);
            label10.TabIndex = 51;
            label10.Text = "Designated Project";
            // 
            // Dtype
            // 
            Dtype.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            Dtype.Location = new Point(516, 187);
            Dtype.Name = "Dtype";
            Dtype.Size = new Size(211, 25);
            Dtype.TabIndex = 50;
            Dtype.TextChanged += Dtype_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(369, 191);
            label11.Name = "label11";
            label11.Size = new Size(107, 20);
            label11.TabIndex = 49;
            label11.Text = "Donation Type";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(369, 143);
            label12.Name = "label12";
            label12.Size = new Size(107, 20);
            label12.TabIndex = 47;
            label12.Text = "Donation Date";
            // 
            // Damount
            // 
            Damount.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            Damount.Location = new Point(516, 98);
            Damount.Name = "Damount";
            Damount.Size = new Size(211, 25);
            Damount.TabIndex = 46;
            Damount.TextChanged += Damount_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(369, 99);
            label13.Name = "label13";
            label13.Size = new Size(141, 20);
            label13.TabIndex = 45;
            label13.Text = "Donation Ammount";
            // 
            // email
            // 
            email.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            email.Location = new Point(105, 360);
            email.Name = "email";
            email.Size = new Size(211, 25);
            email.TabIndex = 58;
            email.TextChanged += textBox12_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(23, 361);
            label14.Name = "label14";
            label14.RightToLeft = RightToLeft.No;
            label14.Size = new Size(46, 20);
            label14.TabIndex = 57;
            label14.Text = "Email";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(516, 143);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(211, 27);
            dateTimePicker1.TabIndex = 59;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // Donors
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(dateTimePicker1);
            Controls.Add(email);
            Controls.Add(label14);
            Controls.Add(service);
            Controls.Add(label8);
            Controls.Add(comment);
            Controls.Add(label9);
            Controls.Add(Designated);
            Controls.Add(label10);
            Controls.Add(Dtype);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(Damount);
            Controls.Add(label13);
            Controls.Add(phone);
            Controls.Add(label6);
            Controls.Add(country);
            Controls.Add(label7);
            Controls.Add(state);
            Controls.Add(label5);
            Controls.Add(city);
            Controls.Add(label4);
            Controls.Add(fullname);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(deletebutt);
            Controls.Add(updatebutt);
            Controls.Add(savebutt);
            Controls.Add(donorid);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Donors";
            Size = new Size(771, 709);
            Load += Donors_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button deletebutt;
        private Button updatebutt;
        private Button savebutt;
        private Label label2;
        private TextBox donorid;
        private Label label1;
        private Panel panel1;
        private TextBox fullname;
        private Label label3;
        private TextBox city;
        private Label label4;
        private TextBox state;
        private Label label5;
        private TextBox phone;
        private Label label6;
        private TextBox country;
        private Label label7;
        private TextBox service;
        private Label label8;
        private TextBox comment;
        private Label label9;
        private TextBox Designated;
        private Label label10;
        private TextBox Dtype;
        private Label label11;
        private Label label12;
        private TextBox Damount;
        private Label label13;
        private TextBox email;
        private Label label14;
        private DateTimePicker dateTimePicker1;
    }
}
