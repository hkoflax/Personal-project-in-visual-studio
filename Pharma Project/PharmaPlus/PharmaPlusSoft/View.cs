using PharmaPlusLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmaPlusSoft
{
    public partial class View : Form
    {
        private Login loginPage = null;
        public SqlConnection myConnection=new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename="
                                   + @"" + Login.DataProperty +
                                   ";Integrated Security=True;Connect Timeout=30;");
        SqlCommand cmd;
        public View()
        {
            InitializeComponent();
        }
        public View(Form aform)
        {
            loginPage = aform as Login;
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            this.loginPage.txtPassword.Text = "";
            this.loginPage.txtUsername.Text = "";
            this.loginPage.cbShowPwd.Checked = false;
            this.loginPage.Show();
        }

        private void btnUpdateUserInfo_Click(object sender, EventArgs e)
        {
            Registration myPage = new Registration(this,"Modify");
            myPage.btnRegister.Text = "Update";

            var user = Login.myUser;
            try
            {
                /*myConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename="
                                   + @"" + Login.DataProperty +
                                   ";Integrated Security=True;Connect Timeout=30;");*/
                SqlDataAdapter myData = new SqlDataAdapter("Select * from Users where userId='" + user.UserId + "'", myConnection);
                DataTable myTable = new DataTable();
                myData.Fill(myTable);

                myPage.txtFname.Text = myTable.Rows[0][1].ToString();
                myPage.txtLName.Text = myTable.Rows[0][2].ToString();
                myPage.txtEmail.Text = myTable.Rows[0][6].ToString();
                myPage.txtPNumber.Text = myTable.Rows[0][3].ToString();
                myPage.txtAge.Text = myTable.Rows[0][8].ToString();
                myPage.txtAdress.Text = myTable.Rows[0][4].ToString();
                //Do not display password Value
                //myPage.txtPwd.Text = myTable.Rows[0][7].ToString();
                myPage.txtPwd.Text = "";
                myPage.txtCPwd.Text = "";
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            myPage.txtCNPwd.Visible = true;
            myPage.lblOldPwd.Visible = true;
            myPage.lblNewPwd.Visible = true;
            myPage.lblConfirmNew.Visible = true;

            myPage.cbUType.Visible = false;
            myPage.lblPassword.Visible = false;
            myPage.lblCPassword.Visible = false;
            myPage.lblType.Visible = false;
            myPage.ShowDialog();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            Order myOrderPage = new Order(this);
            myOrderPage.ShowDialog();
        }

        private void View_Load(object sender, EventArgs e)
        {
            lblLoginName.Text = "Welcome, " + Login.myUser.UserFName;

            if (Login.myUser.UserType==UserType.Client)
            {
                SqlDataAdapter myData = new SqlDataAdapter("Select orderId,orderDate,orderStatus,orderDescription" +
                                        ",orderdeliveryDate,orderDeliveryAdress from Orders where orderUserId="
                                        + Login.myUser.UserId + "", myConnection);
                DataTable myTable = new DataTable();
                myData.Fill(myTable);
                dGVOrders.DataSource = myTable; 
            }else
            {
                SqlDataAdapter myData = new SqlDataAdapter("Select orderId,orderDate,orderStatus,orderDescription" +
                        ",orderdeliveryDate,orderDeliveryAdress from Orders", myConnection);
                DataTable myTable = new DataTable();
                myData.Fill(myTable);
                dGVOrders.DataSource = myTable;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SqlDataAdapter myData = new SqlDataAdapter("Select orderId,orderDate,orderStatus,orderDescription" +
                                            ",orderdeliveryDate,orderDeliveryAdress from Orders where orderUserId="
                                                        + Login.myUser.UserId + "", myConnection);
            DataTable myTable = new DataTable();
            myData.Fill(myTable);
            dGVOrders.DataSource = myTable;
        }

        private void clientMenu_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
