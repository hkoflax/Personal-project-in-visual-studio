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
    public partial class Order : Form
    {
        private View viewPage = null;
        SqlCommand cmd;
        SqlConnection con = new SqlConnection();
        public Order()
        {
            InitializeComponent();
        }
        public Order(Form aform)
        {
            viewPage = aform as View;
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            cbDeliveryStatus.DataSource = Enum.GetNames(typeof(OrderStatus));
            DTPDeliveryDate.MinDate = DateTime.Now;
            DTPDeliveryDate.CustomFormat = "MM/dd/yyyy   HH:mm:ss tt";
        }

        private void btnPOrder_Click(object sender, EventArgs e)
        {
            #region Place an Order
            if (btnPOrder.Text == "Place Order")
            {
                try
                {
                    CheckInputs("Place Order");
                    string a = txtOrderDescription.Text;
                    string b = txtDeliveryAdress.Text;
                    DateTime c = DTPDeliveryDate.Value;

                    PharmaPlusLibrary.Order anOrder = new PharmaPlusLibrary.Order(a,b);

                    anOrder.OrderId = ++Login.NumberOfOrders;
                    anOrder.DeliveryDate = c;
                    anOrder.OrderUser = Login.myUser;

                    con = new System.Data.SqlClient.SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =" +
                                            @"" + Login.DataProperty +
                                            ";Integrated Security=True;Connect Timeout=30;");
                    con.Open();
                    //string query="";
                    //cmd = new SqlCommand(query,con);
                    cmd = new SqlCommand("INSERT INTO Orders(orderId,orderDescription,orderDeliveryAdress" +
                                         ",orderDeliveryDate,orderDate,orderStatus,orderUserId)" +
                                         "VALUES(@id,@a,@b,@c,@d,@status,@uId)", con);

                    cmd.Parameters.Add("@id", anOrder.OrderId);
                    cmd.Parameters.Add("@a", anOrder.OrderDescription);
                    cmd.Parameters.Add("@b", anOrder.OrderDeliveryAdress);
                    cmd.Parameters.Add("@c", anOrder.DeliveryDate);
                    cmd.Parameters.Add("@d", anOrder.OrderDate);
                    cmd.Parameters.Add("@status", anOrder.OrderStatus.ToString());
                    cmd.Parameters.Add("@uID", anOrder.OrderUser.UserId);

                    cmd.ExecuteNonQuery();

                    SqlDataAdapter myData = new SqlDataAdapter("Select orderId,orderDate,orderStatus, orderDescription" +
                                            ",orderdeliveryDate,orderDeliveryAdress from Orders where orderUserId="
                                            + Login.myUser.UserId + "", con);
                    DataTable myTable = new DataTable();
                    myData.Fill(myTable);
                    viewPage.dGVOrders.DataSource = myTable;
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
        public void CheckInputs(string value)
        {
            string a = txtOrderDescription.Text;
            string b = txtDeliveryAdress.Text;
            if (a == "")
            {
                throw new Exception("Order description field empty");
            }
            else if (b == "")
            {
                throw new Exception("Delivery Adress field empty");
            }
        }
    }
}
