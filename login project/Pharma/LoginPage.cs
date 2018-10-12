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

namespace Pharma
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename="
                                                           + @"C:\Users\koflax\Desktop\School\home Project\databases\logindata.mdf" +
                                                           ";Integrated Security=True;Connect Timeout=30;");
            SqlDataAdapter myData = new SqlDataAdapter("Select * from loginData where UPPER(Username)='"
                                                        +usernameTxt.Text+"'and password='"+passwordTxt.Text+"'",
                                                        myConnection);
            DataTable myTable = new DataTable();
            myData.Fill(myTable);
            if(myTable.Rows.Count>0)
            {
                if (myTable.Rows[0][0].ToString() == usernameTxt.Text && myTable.Rows[0][1].ToString() == passwordTxt.Text)
                {
                    string result = myTable.Rows[0][0].ToString();
                    MessageBox.Show(result);
                    //MainPage myMainPage = new MainPage(this);
                    //myConnection.Close();
                    //this.Hide();
                    //myMainPage.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Login Or Password, please try again");
                }
            }
            else
            {
                MessageBox.Show("Incorrect Login Or Password, please try again");
            }
        }
    }
}
