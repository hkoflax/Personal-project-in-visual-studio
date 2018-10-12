using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharma
{
    public partial class MainPage : Form
    {
        private LoginPage loginPage = null;
        public MainPage()
        {
            InitializeComponent();
        }
        public MainPage(Form aForm)
        {
            loginPage = aForm as LoginPage;
            InitializeComponent();
        }
        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            loginPage.Show();
        }
    }
}
