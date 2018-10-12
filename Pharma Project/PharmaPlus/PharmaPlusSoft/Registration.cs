using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PharmaPlusLibrary;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Net.Mail;

namespace PharmaPlusSoft
{
    public partial class Registration : Form
    {
        private Login loginPage = null;
        private View viewPage = null;
        SqlCommand cmd;
        SqlConnection con = new SqlConnection();
        public Registration()
        {
            InitializeComponent();
        }
        public Registration(Form aform)
        {
            loginPage = aform as Login;
            InitializeComponent();
        }
        public Registration(Form aform, string value)
        {
            if (value=="Modify")
            {
                viewPage = aform as View;
                InitializeComponent();
            }
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            cbUType.DataSource = Enum.GetNames(typeof(UserType));
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            #region create a User
            if (btnRegister.Text == "Register")
            {
                try
                {
                    CheckInputs("Create");
                    string a = txtFname.Text;
                    string b = txtLName.Text;
                    string c = txtEmail.Text;
                    long d = long.Parse(txtPNumber.Text);
                    int e1 = int.Parse(txtAge.Text);
                    string f = txtAdress.Text;
                    string g = txtPwd.Text;
                    /*already in the check inputs
                     * if (g != txtCPwd.Text)
                    {
                        throw new Exception("Password Does not Match");
                    }*/

                    User aUser = new User(a, b, d, e1, f, c, g);

                    aUser.UserId = ++Login.NumberOfUser;

                    con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =" +
                                            @"" + Login.DataProperty +
                                            ";Integrated Security=True;Connect Timeout=30;");
                    con.Open();
                    //string query="";
                    //cmd = new SqlCommand(query,con);
                    cmd = new SqlCommand("INSERT INTO Users(userId,userFName,userLName,userNumber" +
                                         ",userAdress,userStatus,userEmail,userPassword,userAge)" +
                                         "VALUES(@id,@a,@b,@d,@f,@status,@c,@g,@e1)", con);

                    cmd.Parameters.Add("@id", aUser.UserId);
                    cmd.Parameters.Add("@a", aUser.UserFName);
                    cmd.Parameters.Add("@b", aUser.UserLName);
                    cmd.Parameters.Add("@d", aUser.UserPhoneNumber);
                    cmd.Parameters.Add("@f", aUser.UserAdress);
                    cmd.Parameters.Add("@status", aUser.UserType.ToString());
                    cmd.Parameters.Add("@c", aUser.UserEmail);
                    cmd.Parameters.Add("@g", aUser.UserPassword);
                    cmd.Parameters.Add("@e1", aUser.UserAge);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    con.Dispose();
                    this.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                        con.Dispose();
                    }
                }
            }
            #endregion

            #region Modify User
            if (btnRegister.Text == "Update")
            {
                try
                {
                    CheckInputs("Update");
                    string a = txtFname.Text;
                    string b = txtLName.Text;
                    string c = txtEmail.Text;
                    long d = long.Parse(txtPNumber.Text);
                    int e1 = int.Parse(txtAge.Text);
                    string f = txtAdress.Text;
                    string g = txtPwd.Text;
                    string h = txtCPwd.Text;
                    string i = txtCNPwd.Text;
                    string myNewPWD;
                    if (h!="")
                    {
                        myNewPWD = h;
                    }
                    else
                    {
                        myNewPWD = g;
                    }
                    if (g != Login.myUser.UserPassword)
                    {
                        throw new Exception("Wrong curent Password");
                    }
                    else if (txtCPwd.Text != txtCNPwd.Text)
                    {
                        throw new Exception("New Password Does not Match");
                    }

                    con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =" +
                                            @"" + Login.DataProperty +
                                            ";Integrated Security=True;Connect Timeout=30;");
                    con.Open();
                    //string query="";
                    //cmd = new SqlCommand(query,con);
                    //"UPDATE Student(LastName, FirstName, Address, City) VALUES (@ln, @fn, @add, @cit) WHERE LastName='" + lastName + "' AND FirstName='" + firstName+"'";
                    var aUser = Login.myUser;
                    cmd = new SqlCommand("UPDATE Users SET userFName=@a,userLName=@b,userNumber=@d" +
                                         ",userAdress=@f,userEmail=@c,userPassword=@g,userAge=@e1 WHERE " +
                                         "userId='"+aUser.UserId+"'", con);
                    cmd.Parameters.Add("@a", a);
                    cmd.Parameters.Add("@b", b);
                    cmd.Parameters.Add("@d", d);
                    cmd.Parameters.Add("@f", f);
                    cmd.Parameters.Add("@c", c);
                    cmd.Parameters.Add("@g", myNewPWD);
                    cmd.Parameters.Add("@e1", e1);
                                               
                    cmd.ExecuteNonQuery();
                    Login.myUser.UserPassword = myNewPWD;
                    viewPage.lblLoginName.Text= "Welcome, "+a;
                    con.Close();
                    con.Dispose();
                    this.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                        con.Dispose();
                    }
                }
            }
            #endregion
        }
        public bool IsEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void CheckInputs(string value)
        {
            string a = txtFname.Text;
            string b = txtLName.Text;
            string c = txtEmail.Text;
            long d = 0;
            int e1 = 0;
            string f = txtAdress.Text;
            string g = txtPwd.Text;
            string h = txtCPwd.Text;
            string i = txtCNPwd.Text;
            if (a == "")
            {
                throw new Exception("first name field empty");
            }
            else if (b == "")
            {
                throw new Exception("Last name field empty");
            }
            else if (c == "" || IsEmail(c) == false)
            {
                throw new Exception("email field empty or email wrong format");
            }
            else if (long.TryParse(txtPNumber.Text, out d) == false)
            {
                throw new Exception("incorrect Phone number");
            }
            else if (int.TryParse(txtAge.Text, out e1) == false)
            {
                throw new Exception("incorrect Age number");
            }
            else if (f == "")
            {
                throw new Exception("Adress field is empty");
            }
            else if (g == "")
            {
                throw new Exception("Password field is empty");
            }
            else if(value=="Create")
            {
                if(g!=h)
                {
                    throw new Exception("Passwords do not match");
                }
            }
            else if(value=="Upadte")
            {
                if (h != i)
                {
                    throw new Exception("New Passwords do not match");
                }
            }

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
