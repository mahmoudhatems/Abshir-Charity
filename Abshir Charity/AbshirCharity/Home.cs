using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.SqlClient;



namespace AbshirCharity
{
    public partial class Home : Form
    {

        public Home()
        {




            InitializeComponent();

        }
        private void add_UControls(UserControl userControl)
        {

            userControl.Dock = DockStyle.Fill;
            Mainpanl.Controls.Clear();
            Mainpanl.Controls.Add(userControl);
            userControl.BringToFront();

        }
        private void Btn_click(object sender, EventArgs e)
        {
            foreach (var pnl in Mainpanl.Controls.OfType<Panel>())
            {
                pnl.BackColor = SystemColors.Window;
            }
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "DonorsButt":
                    add_UControls(new Donors());
                    break;
                case "CasesButt":
                    add_UControls(new Cases());
                    break;
                case "Monthlybutt":
                    add_UControls(new Monthly());
                    break;
                default: break;

            }
        }
        private void Donorsbutt_Click(object sender, EventArgs e)
        {
            add_UControls(new Donors());

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Mainpanl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Exitbutt_Click(object sender, EventArgs e)
        {
            DialogResult exityesno = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo);

            if (exityesno == DialogResult.Yes)
            {
                Application.Exit(); // Exit the application
            }
        }
        private void home_load(object sender, EventArgs e)
        {
            Donorsbutt.Click += Btn_click;
            cases.Click += Btn_click;
            monthly.Click += Btn_click;
        }

        private void cases_Click(object sender, EventArgs e)
        {
            add_UControls(new Cases());
        }

        private void monthly_Click(object sender, EventArgs e)
        {
            add_UControls(new Monthly());
        }
    }
}
