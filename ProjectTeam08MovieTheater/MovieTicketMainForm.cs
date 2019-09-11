using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTeam08MovieTheater.EF_Classes;
using System.Data.Entity;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Data.SqlClient;

namespace ProjectTeam08MovieTheater
{
    public partial class MovieTicketForm : Form
    {
        private MovieTicketEntities context;
        private double ticketPrice = 12.00;
        private double discount = 3.00;
        DataSet movieDS = new DataSet("MovieTicketDB");

        public MovieTicketForm()
        {
            InitializeComponent();

            context = new MovieTicketEntities();

            //initialize max length of age and ticketNum textbox
            //to prevent from invalid input
            textBoxAge.MaxLength = 3;
            textBoxTicketNum.MaxLength = 4;

            //add event handlers when initializing
            this.Load += MovieTicketForm_Load;
            buttonConfirm.Click += ButtonConfirm_Click;
            buttonClear.Click += ButtonClear_Click;
            buttonReport.Click += ButtonReport_Click;
            textBoxTicketNum.TextChanged += TextBoxTicketNum_TextChanged;
            textBoxAge.TextChanged += TextBoxAge_TextChanged;
            dataGridViewTime.SelectionChanged += DataGridViewTime_SelectionChanged;
        }

        private void DataGridViewTime_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                double ticketNum = double.Parse(textBoxTicketNum.Text);

                //when user select morning time apply discount
                if (dataGridViewTime.SelectedRows[0].Index == 0)
                    labelTotalPrice.Text = (ticketNum * (ticketPrice - discount)).ToString("C2");
                else
                    labelTotalPrice.Text = (ticketNum * ticketPrice).ToString("C2");
            }
            catch
            {//catch when the data cannot be converted into double
                return;
            }

        }

        private void TextBoxAge_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double age = double.Parse(textBoxAge.Text);
                labelAgeMessage.Visible = false;

                //age can't be more than 130 (oldest person alive is less than 130)
                if (age > 130) 
                    labelAgeMessage.Visible = true;
            }
            catch
            {//display the error message (Parsing error)
                labelAgeMessage.Visible = true;
            }

            //when age is empty, clear the error message display
            if (textBoxAge.Text == "")
                labelAgeMessage.Visible = false;
        }

        private void TextBoxTicketNum_TextChanged(object sender, EventArgs e)
        {
            //when the selected item is exist
            if (dataGridViewTime.SelectedRows.Count > 0)
            {
                try
                {
                    double ticketNum = double.Parse(textBoxTicketNum.Text.Trim());

                    //when the data is correctly parsed, disable error message
                    labelTicketMessage.Visible = false;

                    //apply discount for morning time
                    if (dataGridViewTime.SelectedRows[0].Index == 0)
                        labelTotalPrice.Text = (ticketNum * (ticketPrice - discount)).ToString("C2");
                    else
                        labelTotalPrice.Text = (ticketNum * ticketPrice).ToString("C2");
                }
                catch
                {//display the error message
                    labelTicketMessage.Visible = true;
                }

                //when the textbox is empty
                if (textBoxTicketNum.Text == "")
                {
                    //clear error message and total price
                    labelTicketMessage.Visible = false;
                    labelTotalPrice.Text = "";
                }
            }
            //when nothing is selected
            else
            {
                //disable text change
                textBoxTicketNum.TextChanged -= TextBoxTicketNum_TextChanged;

                //clear the ticketnum textbox
                textBoxTicketNum.Text = "";

                //add an event handler
                textBoxTicketNum.TextChanged += TextBoxTicketNum_TextChanged;

                //message box pop up
                MessageBox.Show("Please select Time first!");
                return;
            }
            
        }

        private void ButtonReport_Click(object sender, EventArgs e)
        {
            //open the password Form when user clicks Report Button
            PasswordForm password = new PasswordForm();

            var openForm = password.ShowDialog();
        }

        private void MovieTicketForm_Load(object sender, EventArgs e)
        {
            //Load the Movie and Time Entities
            context.Movie.Load();
            context.Time.Load();

            //reset identities
            context.Database.ExecuteSqlCommand($"DBCC CHECKIDENT('Movie', RESEED, 0)");
            context.Database.ExecuteSqlCommand($"DBCC CHECKIDENT('Time', RESEED, 0)");

            context.SaveChanges();

            //set the Movie DataGridView
            dataGridViewMovie.DataSource = context.Movie.Local.ToBindingList();
            dataGridViewMovie.ReadOnly = true;
            dataGridViewMovie.AllowUserToAddRows = false;
            dataGridViewMovie.Columns["MovieId"].Visible = false;
            dataGridViewMovie.Columns["AudiId"].Visible = false;
            dataGridViewMovie.Columns["Auditorium"].Visible = false;
            dataGridViewMovie.Columns["Order"].Visible = false;
            dataGridViewMovie.Columns["MovieGenre"].Visible = false;
            dataGridViewMovie.Columns["MovieAgeLimit"].Visible = false;
            dataGridViewMovie.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //set the Time DataGridView
            dataGridViewTime.DataSource = context.Time.Local.ToBindingList();
            dataGridViewTime.ReadOnly = true;
            dataGridViewTime.AllowUserToAddRows = false;
            dataGridViewTime.Columns["Order"].Visible = false;
            dataGridViewTime.Columns["TimeId"].Visible = false;
            dataGridViewTime.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public Boolean validateInput()
        {
            Boolean flag = false;

            try
            {
                //try to convert user input into double
                double age = double.Parse(textBoxAge.Text);
                double ticketNum = double.Parse(textBoxTicketNum.Text);

                //check for every textboxes and datagridviews
                if (textBoxFirstName.Text == "" || textBoxLastName.Text == ""
                    || textBoxAge.Text == "" || textBoxTicketNum.Text == ""
                    || dataGridViewMovie.SelectedRows.Count > 1 || dataGridViewMovie.SelectedRows.Count == 0
                    || dataGridViewTime.SelectedRows.Count > 1 || dataGridViewTime.SelectedRows.Count == 0)
                    return flag;
                //check if the selected movie rate is less than user's age
                else if (int.Parse(dataGridViewMovie.Rows[dataGridViewMovie.SelectedRows[0].Index].Cells[5].Value.ToString()) 
                        > int.Parse(textBoxAge.Text))
                {//if the age is less than rate, send a warning
                    MessageBox.Show("Age of customer is less than age limit! Parental Guidance needed.");
                    flag = true;
                }
                else
                    flag = true; //everything is valid! Convert flag true
            }
            catch
            {
                //to catch if the the typed value is not numeric value
                //if the value is string show the message Box 
                MessageBox.Show("Check for invalid input.");
            }

            //return flag either true=>valid input, false=>invalid input
            return flag;
        }

        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            //if the data entered is invalid
            if (!validateInput())
                return;
            //if the data is valid
            else
            {
                PaymentForm payment = new PaymentForm();

                //open the paymentForm
                if (payment.ShowDialog() == DialogResult.OK)
                {
                    //string movieTitle = dataGridViewMovie.Rows[dataGridViewMovie.SelectedRows[0].Index].Cells[2].Value.ToString();

                    //insert data into customer table
                    var customer = new Customer();

                    customer.CustFirstname = textBoxFirstName.Text;
                    customer.CustLastname = textBoxLastName.Text;
                    customer.CustAge = int.Parse(textBoxAge.Text);

                    context.Customer.Add(customer);
                    
                    //insert data into order table
                    var order = new Order();

                    double tprice = ticketPrice * int.Parse(textBoxTicketNum.Text);
                    if (dataGridViewTime.SelectedRows[0].Index == 0)
                        tprice = (ticketPrice - discount) * int.Parse(textBoxTicketNum.Text);

                    order.MovieId = dataGridViewMovie.SelectedRows[0].Index + 1;
                    order.TimeId = dataGridViewTime.SelectedRows[0].Index + 1;
                    order.CustId = customer.CustId;
                    order.OrderTicketNum = int.Parse(textBoxTicketNum.Text);
                    order.OrderAmount = tprice;

                    //save the changes
                    context.Order.Add(order);

                    context.SaveChanges();

                    //clear the textboxes, labels, datagridview when transaction is completed
                    clear();
                    
                    //create a connection to DB
                    String sConnection = context.Database.Connection.ConnectionString;
                    SqlConnection mySqlConnection = new SqlConnection(sConnection);
                    mySqlConnection.Open();
                    
                    //save the data into dataset from Order table
                    SqlDataAdapter mySqlDataAdapterOrder = new SqlDataAdapter("SELECT * from [dbo].[Order]", sConnection);
                    DataSet orderDS = new DataSet();
                    orderDS.DataSetName = "Order";
                    mySqlDataAdapterOrder.Fill(orderDS);

                    //save the data into dataset from Customer table
                    SqlDataAdapter mySqlDataAdapterCust = new SqlDataAdapter("SELECT * from [dbo].[Customer]", sConnection);
                    DataSet custDS = new DataSet();
                    custDS.DataSetName = "Customer";
                    mySqlDataAdapterCust.Fill(custDS);

                    // Write data to xml files
                    orderDS.WriteXml(fileName: Application.StartupPath + @"\\..\\..\\..\\report.xml");
                    custDS.WriteXml(fileName: Application.StartupPath + @"\\..\\..\\..\\cust.xml");
                    mySqlConnection.Close();
                }
                else
                {
                    //if user press cancel, display message box
                    MessageBox.Show("Transaction Canceled!");
                }
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {//clear the textboxes, labels, datagridview when the clear button is clicked
            clear();
        }

        public void clear()
        {
            //disable event handlers
            textBoxTicketNum.TextChanged -= TextBoxTicketNum_TextChanged;
            dataGridViewTime.SelectionChanged -= DataGridViewTime_SelectionChanged;

            //clear the datagridview, textbox, label
            dataGridViewMovie.ClearSelection();
            dataGridViewTime.ClearSelection();
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxAge.Text = "";
            textBoxTicketNum.Text = "";
            labelTotalPrice.Text = "";
            labelAgeMessage.Visible = false;
            labelTicketMessage.Visible = false;

            //add event handlers again
            dataGridViewTime.SelectionChanged += DataGridViewTime_SelectionChanged;
            textBoxTicketNum.TextChanged += TextBoxTicketNum_TextChanged;
        }
    }
}
