using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;
using PharmaPlusLibrary;

namespace PharmaPlusSoft
{
    public partial class Login : Form
    {
        public static String DataProperty;
        public static long NumberOfUser;
        public static long NumberOfOrders;
        public static bool IsDataSet;
        public SqlConnection myConnection;
        public static User myUser = new User();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (IsDataSet == true)
            {
                if (txtPassword.Text != "" || txtUsername.Text != "")
                {
                    try
                    {
                        myConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename="
                                           + @"" + DataProperty +
                                           ";Integrated Security=True;Connect Timeout=30;");
                        SqlDataAdapter myData = new SqlDataAdapter("Select * from Users where userEmail='"
                                                                    + txtUsername.Text + "'and userPassword='" + txtPassword.Text + "'",
                                                                    myConnection);
                        DataTable myTable = new DataTable();
                        myData.Fill(myTable);
                        if (myTable.Rows.Count > 0)
                        {
                            if (myTable.Rows[0][6].ToString().ToUpper() == txtUsername.Text.ToUpper() && myTable.Rows[0][7].ToString() == txtPassword.Text)
                            {
                                myUser.UserId = int.Parse(myTable.Rows[0][0].ToString());
                                myUser.UserFName = myTable.Rows[0][1].ToString();
                                myUser.UserLName = myTable.Rows[0][2].ToString();
                                myUser.UserPhoneNumber = long.Parse(myTable.Rows[0][3].ToString());
                                myUser.UserAdress = myTable.Rows[0][4].ToString();
                                myUser.UserType = (UserType)Enum.Parse(typeof(UserType),(myTable.Rows[0][5].ToString()));
                                myUser.UserEmail = myTable.Rows[0][6].ToString();
                                myUser.UserPassword = myTable.Rows[0][7].ToString();
                                myUser.UserAge = int.Parse(myTable.Rows[0][8].ToString());
                                View myView = new View(this);
                                this.Hide();
                                myView.Show();
                                //myView.lblLoginName.Text = "Welcome, " + myTable.Rows[0][1].ToString();
                                myView.Text = myTable.Rows[0][5].ToString() + " View";
                                if (myView.Text.Contains("Admin"))
                                {
                                    myView.btnAdminControls.Enabled = true;
                                }
                                else
                                {
                                    myView.btnAdminControls.Enabled = false;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Login Or Password, please try again or Register Now");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Login Or Password, please try again or Register Now");
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error in database Selected");
                    }
                    finally
                    {
                        myConnection.Close();
                        myConnection.Dispose();
                    }
                }
                else
                {
                    MessageBox.Show("You have not put any login Information");
                }
            }
            else
            {
                MessageBox.Show("No Database Currently Set, Please Setup Database to continue");
            }
        }

        private void btnDataSetup_Click(object sender, EventArgs e)
        {
            openFileData.Title = "Select DataBase Repository";
            openFileData.Filter = "Data file| *.mdf";
            DialogResult result = openFileData.ShowDialog();
            if (result == DialogResult.OK)
            {
                DataProperty = openFileData.FileName;
                Save("DataSet");
                MessageBox.Show("Database Set to : \n" + DataProperty);
                IsDataSet = true;
            }
        }
        public void Save(string fileName)
        {
            FileStream clubOutFile = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            StreamWriter clubWriter = new StreamWriter(clubOutFile);
            clubWriter.WriteLine(DataProperty);
            clubWriter.Close();
            clubOutFile.Close();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            LoadData();
            LastUserId();
            LastOrderId();
        }
        public void LoadData()
        {
            FileStream dataFile = null;
            StreamReader dataReader = null;
            try
            {
                dataFile = new FileStream("DataSet", FileMode.Open, FileAccess.Read);
                dataReader = new StreamReader(dataFile);
                string recordInFile;
                recordInFile = dataReader.ReadLine();
                while (recordInFile != null)
                {
                    DataProperty = recordInFile;
                    recordInFile = dataReader.ReadLine();
                }
                IsDataSet = true;
            }
            catch (Exception)
            {

                //MessageBox.Show(error.Message);
                MessageBox.Show("No Database Currently Set, Please Setup Database");
                IsDataSet = false;
            }
            finally
            {
                if (dataReader != null) dataReader.Close();
                if (dataFile != null) dataFile.Close();
            }

        }
        private void cbShowPwd_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPwd.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (IsDataSet == true)
            {
                Registration myRegPage = new Registration(this);
                myRegPage.ShowDialog();
            }
            else
            {
                MessageBox.Show("No Database Currently Set, Please Setup Database to continue");
            }
        }
        private void LastUserId()
        {
            try
            {
                myConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename="
                       + @"" + DataProperty +
                       ";Integrated Security=True;Connect Timeout=30;");
                string script = "Select MAX(userId) from Users";
                SqlDataAdapter myData = new SqlDataAdapter(script, myConnection);
                DataTable myTable = new DataTable();
                myData.Fill(myTable);
                NumberOfUser = long.Parse(myTable.Rows[0][0].ToString());
                //MessageBox.Show(myTable.Rows[0][0].ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Error in database Selected");
            }
            finally
            {
                myConnection.Close();
                myConnection.Dispose();
            }
        }
        private void LastOrderId()
        {
            try
            {
                myConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename="
                       + @"" + DataProperty +
                       ";Integrated Security=True;Connect Timeout=30;");
                string script = "Select MAX(orderId) from Orders";
                SqlDataAdapter myData = new SqlDataAdapter(script, myConnection);
                DataTable myTable = new DataTable();
                myData.Fill(myTable);
                NumberOfOrders = long.Parse(myTable.Rows[0][0].ToString());
                //MessageBox.Show(myTable.Rows[0][0].ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Error in database Selected");
            }
            finally
            {
                myConnection.Close();
                myConnection.Dispose();
            }
        }
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnLogin_Click(sender,e);
            }
        }
    }
}
