using System;
using System.Drawing;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Globalization;
using System.Windows.Forms;
using Shop_Management_System_Project.Information_Classes;

namespace Shop_Management_System_Project.Panel_Forms
{
    public partial class FormSellProducts : Form
    {
        private int _amountHaveToPay;
        private const string Connectionstring = @"Data Source=(localdb)\v11.0;Initial Catalog=SuperShopDatabase;Integrated Security=True";
        private SqlConnection _conn;
        private readonly SqlConnection _con = new SqlConnection(Connectionstring);
        private readonly string _userNameAdmin;
        private double _totalAmount;
        private int _cellCount = -1;
        private CustomerInfo _customerInfo = new CustomerInfo(0, "Test", "Test", "Test");
        private readonly CompanyInfo _companyInfo = new CompanyInfo("Test", "Test");
        private int _invoiceNumberCount;
        private int _invoiceLow;
        private int _invoiceHigh;
        public FormSellProducts(string usernameAdmin)
        {
            _userNameAdmin = usernameAdmin;
            FormBorderStyle = FormBorderStyle.None;
            TopLevel = false;
            AutoScroll = true;

            using (SqlConnection conn = new SqlConnection(Connectionstring))
            {
                string query = "SELECT * FROM [User] where username = '" + _userNameAdmin + "'";


                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            _userNameAdmin = reader["name"].ToString();
                        }
                    }
                }
            }

            InitializeComponent();
            comboBoxCustomerList.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProductName.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProductName.DropDownHeight = comboBoxProductName.ItemHeight * 10;
            comboBoxCustomerList.DropDownHeight = comboBoxCustomerList.ItemHeight * 5;
        }

        public sealed override bool AutoScroll
        {
            get { return base.AutoScroll; }
            set { base.AutoScroll = value; }
        }

        private void FormSellProducts_Load(object sender, EventArgs e)
        {
            productsTableAdapter.Fill(superShopDatabaseDataSetProductName.Products);
            customerTableAdapter.Fill(superShopDatabaseDataSetCustomerList.Customer);

            foreach (DataGridViewColumn dc in dataGridViewRecipt.Columns)
            {
                dc.ReadOnly = !dc.Index.Equals(1);
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char) Keys.Back))
            {
                e.Handled = true;  
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (_invoiceNumberCount >= 25)
                {
                    MessageBox.Show(@"You're not allowed to add more than 25 product in cart", @"Limit Exceed Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtQuantity.Text == "")
                {
                    MessageBox.Show(@"Enter quantity value", @"Quantity Missing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _invoiceNumberCount++;
                _conn = new SqlConnection(Connectionstring);
                _conn.Open();
                string quantity = "";
                string perUnitPrice = "";

                using (SqlConnection conn = new SqlConnection(Connectionstring))
                {
                    for (int i = 0; i <= _cellCount; i++)
                    {
                        if (dataGridViewRecipt.Rows[i].Cells[0].Value.ToString() == comboBoxProductName.Text)
                        {
                            MessageBox.Show(@"Product already added to list.", @"Product Exist", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                            return;
                        }
                    }
                    string query = "select quantity from [dbo].[products] where [name] = '" + comboBoxProductName.Text + "'";


                    using (SqlCommand cmda = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmda.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                quantity = reader["quantity"].ToString();
                            }
                        }
                    }
                }

                //Checking if there are enough unit available in inventory
                if (Convert.ToInt32(quantity) < Convert.ToInt32(txtQuantity.Text))
                {
                    MessageBox.Show(
                        @"You do not have enough items for this product. Please check inventory for available items.",
                        @"Insufficient Inventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (SqlConnection conn = new SqlConnection(Connectionstring))
                {
                    string query = "select per_unit_price from products where name = '" + comboBoxProductName.Text + "'";


                    using (SqlCommand cmda = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmda.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                perUnitPrice = reader["per_unit_price"].ToString();
                            }
                        }
                    }
                }

                dataGridViewRecipt.Rows.Add(comboBoxProductName.Text, txtQuantity.Text, perUnitPrice, Convert.ToDouble(txtQuantity.Text) * Convert.ToDouble(perUnitPrice));

                _totalAmount += Convert.ToDouble(dataGridViewRecipt.Rows[++_cellCount].Cells[3].Value);
                lblTotalAmount.Text = Convert.ToString(Math.Round(_totalAmount), CultureInfo.InvariantCulture);

                MessageBox.Show(@"Product Added to List", @"Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtQuantity.Text = "";
            }

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (_invoiceNumberCount >= 25)
            {
                MessageBox.Show(@"You're not allowed to add more than 25 product in cart", @"Limit Exceed Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtQuantity.Text == "")
            {
                MessageBox.Show(@"Enter quantity value", @"Quantity Missing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _invoiceNumberCount++;
            _conn = new SqlConnection(Connectionstring);
            _conn.Open();
            string quantity = "";
            string perUnitPrice = "";

            using (SqlConnection conn = new SqlConnection(Connectionstring))
            {
                for (int i = 0; i <= _cellCount; i++)
                {
                    if (dataGridViewRecipt.Rows[i].Cells[0].Value.ToString() == comboBoxProductName.Text)
                    {
                        MessageBox.Show(@"Product already added to list.", @"Product Exist", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }
                }
                string query = "select quantity from [dbo].[products] where [name] = '" + comboBoxProductName.Text + "'";


                using (SqlCommand cmda = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmda.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            quantity = reader["quantity"].ToString();
                        }
                    }
                }
            }

            //Checking if there are enough unit available in inventory
            if (Convert.ToInt32(quantity) < Convert.ToInt32(txtQuantity.Text))
            {
                MessageBox.Show(
                    @"You do not have enough items for this product. Please check inventory for available items.",
                    @"Insufficient Inventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = new SqlConnection(Connectionstring))
            {
                string query = "select per_unit_price from products where name = '" + comboBoxProductName.Text + "'";


                using (SqlCommand cmda = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmda.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            perUnitPrice = reader["per_unit_price"].ToString();
                        }
                    }
                }
            }

            dataGridViewRecipt.Rows.Add(comboBoxProductName.Text, txtQuantity.Text, perUnitPrice, Convert.ToDouble(txtQuantity.Text)*Convert.ToDouble(perUnitPrice));

            _totalAmount += Convert.ToDouble(dataGridViewRecipt.Rows[++_cellCount].Cells[3].Value.ToString());
            lblTotalAmount.Text = Convert.ToString(Math.Round(_totalAmount), CultureInfo.InvariantCulture);

            MessageBox.Show(@"Product Added to List", @"Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtQuantity.Text = "";
        }

        private void txtCashReceived_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
            { e.Handled = true; }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                PrintMenu();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text == "" || txtCustomerAddress.Text == "" || txtCustomerContactNo.Text == "")
            {
                MessageBox.Show(@"Please fill all values for creating a new customer", @"Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _con.Open();
                SqlCommand cmd = new SqlCommand
                {
                    CommandText = "Insert into [Customer] (name, address, contact_number) values (@nam, @add, @cn)"
                };
                cmd.Parameters.AddWithValue("@nam", txtCustomerName.Text);
                cmd.Parameters.AddWithValue("@add", txtCustomerAddress.Text);
                cmd.Parameters.AddWithValue("@cn", txtCustomerContactNo.Text);

                cmd.Connection = _con;
                cmd.ExecuteNonQuery();
                MessageBox.Show(@"New Customer added.", @"Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                using (SqlConnection conn = new SqlConnection(Connectionstring))
                {
                    string query = "SELECT * FROM Customer";
                    using (SqlCommand cmd1 = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd1.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                //Adding Customer Data
                                _customerInfo = new CustomerInfo(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                            }
                        }
                    }
                }
                _con.Close();
            }

            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCustomerName.Text = "";
            txtCustomerAddress.Text = "";
            txtCustomerContactNo.Text = "";
        }

        private void btnRefreshCustomer_Click(object sender, EventArgs e)
        {
            customerTableAdapter.Fill(superShopDatabaseDataSetCustomerList.Customer);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            productsTableAdapter.Fill(superShopDatabaseDataSetProductName.Products);
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            _invoiceNumberCount--;
            int rowIndex = dataGridViewRecipt.CurrentCell.RowIndex;
            _totalAmount -= Convert.ToDouble(dataGridViewRecipt.Rows[rowIndex].Cells[3].Value);
            dataGridViewRecipt.Rows.RemoveAt(rowIndex);
            _cellCount--;
            lblTotalAmount.Text = Convert.ToString(Math.Round(_totalAmount), CultureInfo.InvariantCulture);

            MessageBox.Show(@"Product removed from list", @"Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintMenu();
        }

        private void PrintMenu()
        {
            if (_cellCount == -1)
            {
                MessageBox.Show(@"Please add a product first", @"Empty product list Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (txtCashReceived.Text == "")
            {
                MessageBox.Show(@"Enter cash received amount", @"Cash received Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            //Insert entry into Database && remove product from inventory
            _conn = new SqlConnection(Connectionstring);
            _conn.Open();

            for (int i = 0; i <= _cellCount; i++)
            {
                SqlCommand cmd = new SqlCommand
                {
                    CommandText =
                        "Insert into [Items](product_name, quantity, per_unit_price, total_price) values(@name, @qua, @pup, @total)"
                };
                cmd.Parameters.AddWithValue("@name", dataGridViewRecipt.Rows[i].Cells[0].Value.ToString());
                cmd.Parameters.AddWithValue("@qua", dataGridViewRecipt.Rows[i].Cells[1].Value.ToString());
                cmd.Parameters.AddWithValue("@pup", Convert.ToDouble(dataGridViewRecipt.Rows[i].Cells[2].Value.ToString()));
                cmd.Parameters.AddWithValue("@total",
                    Convert.ToString(Convert.ToDouble(dataGridViewRecipt.Rows[i].Cells[1].Value.ToString()) *
                                     Convert.ToDouble(dataGridViewRecipt.Rows[i].Cells[2].Value.ToString()), CultureInfo.InvariantCulture));
                cmd.Connection = _conn;
                cmd.ExecuteNonQuery();

                SqlCommand cmd1 = new SqlCommand
                {
                    CommandText =
                        "Insert into [sales_report](customer_name, employee_name, buy_date) values(@cnam, @enam, @bda)"
                };
                cmd1.Parameters.AddWithValue("@cnam", comboBoxCustomerList.Text);
                cmd1.Parameters.AddWithValue("@enam", _userNameAdmin);
                cmd1.Parameters.AddWithValue("@bda", DateTime.Now.ToString(CultureInfo.InvariantCulture));
                cmd1.Connection = _conn;
                cmd1.ExecuteNonQuery();
                string quantity = "";
                using (SqlConnection conn = new SqlConnection(Connectionstring))
                {
                    string query = "select quantity from products where name = '" +
                                   dataGridViewRecipt.Rows[i].Cells[0].Value + "'";


                    using (SqlCommand cmda = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmda.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                quantity = reader["quantity"].ToString();
                            }
                        }
                    }
                }

                using (SqlConnection conn = new SqlConnection(Connectionstring))
                {
                    string query = "SELECT * FROM salesReportView";


                    using (SqlCommand cmda = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmda.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                _invoiceHigh = Convert.ToInt32(reader["invoice_number"]);
                            }
                        }
                    }
                }
                _invoiceLow = _invoiceHigh - _cellCount;
                SqlCommand cmd2 = new SqlCommand
                {
                    CommandText = "update products set quantity = '" +
                                  ((Convert.ToInt32(quantity) -
                                    Convert.ToInt32(dataGridViewRecipt.Rows[i].Cells[1].Value.ToString()))).ToString() +
                                  "' where name = '" + dataGridViewRecipt.Rows[i].Cells[0].Value + "'",
                    Connection = _conn
                };
                cmd2.ExecuteNonQuery();
            }

            using (SqlConnection conn = new SqlConnection(Connectionstring))
            {
                string query = "SELECT * FROM [Customer] WHERE name = '" + comboBoxCustomerList.Text + "'";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            _customerInfo.CustomerId = Convert.ToInt32(reader["id"]);
                            _customerInfo.Name = reader["name"].ToString();
                            _customerInfo.Address = reader["address"].ToString();
                            _customerInfo.ContactNo = reader["contact_number"].ToString();
                        }
                    }
                }
            }

            using (SqlConnection conn = new SqlConnection(Connectionstring))
            {
                string query = "SELECT * FROM [Company_Info]";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            _companyInfo.Name = reader["company_name"].ToString();
                            _companyInfo.Address = reader["address"].ToString();
                        }
                    }
                }
            }

            //Print Task
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument =
                new PrintDocument {DefaultPageSettings = {PaperSize = new PaperSize("A4", 827, 1170)}};
            printDialog.Document = printDocument; //add the document to the dialog box... 
            printDocument.PrintPage += CreateReceipt;

            DialogResult result = printDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                printDocument.Print();
            }


            //Clearing Sell menu Datagridview
            _invoiceNumberCount = 0;
            _totalAmount = 0;
            _cellCount = -1;
            _amountHaveToPay = 0;
            txtCashReceived.Text = @"0";
            lblTotalAmount.Text = @"0";
            lblChangedAmunt.Text = @"0";
            txtQuantity.Text = "";
            dataGridViewRecipt.Rows.Clear();
        }

        private void CreateReceipt(object sender, PrintPageEventArgs e)
        {
            //Company
            string companyName = _companyInfo.Name;
            string companyAddress = _companyInfo.Address;
            //Cash Details
            string totalAmount = lblTotalAmount.Text;
            string cashReceived = txtCashReceived.Text;
            string changeAmount = lblChangedAmunt.Text;
            //Customer Details
            string customerName = _customerInfo.Name;
            string customerId = _customerInfo.CustomerId.ToString();
            string customerAddress = _customerInfo.Address;
            string customerContactNo = _customerInfo.ContactNo;
            //Employee Details
            string employeeName = _userNameAdmin;
            string invoiceNumbers = _invoiceLow + " to " + _invoiceHigh;
            string buyDate = DateTime.Now.ToString("hh:mm tt dd-MMM-yyyy");

            

            Graphics graphic = e.Graphics;

            Font font = new Font("Courier New", 10); //must use a mono spaced font as the spaces need to line up

            float fontHeight = font.GetHeight();

            int startX = 40;
            int startY = 40;
            int offset = 40;

            graphic.DrawString(companyName, new Font("Courier New", 22, FontStyle.Bold), new SolidBrush(Color.Blue), startX, startY);
            graphic.DrawString(companyAddress, new Font("Courier New", 12), new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight; //make the spacing consistent
            graphic.DrawString("--------------------------------------------------------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 05; //make the spacing consistent
            graphic.DrawString("Customer Information:", new Font("Courier New", 16, FontStyle.Bold), new SolidBrush(Color.Blue), startX, startY + offset);
            graphic.DrawString("Invoice Information:", new Font("Courier New", 16, FontStyle.Bold), new SolidBrush(Color.Blue), startX + 413, startY + offset);
            offset = offset + (int)fontHeight + 10;
            graphic.DrawString("Name: " + customerName, font, new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString("Served By: " + employeeName, font, new SolidBrush(Color.Black), startX + 413, startY + offset);
            offset = offset + (int)fontHeight;
            graphic.DrawString("Customer ID: " + customerId, font, new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString("Invoice Numbers: " + invoiceNumbers, font, new SolidBrush(Color.Black), startX + 413, startY + offset);
            offset = offset + (int)fontHeight;
            graphic.DrawString("Customer Contact: " + customerContactNo, font, new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString("Buy Date: " + buyDate, font, new SolidBrush(Color.Black), startX + 413, startY + offset);
            offset = offset + (int)fontHeight;
            graphic.DrawString("Customer Address: " + customerAddress, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight;
            graphic.DrawString("--------------------------------------------------------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 05; //make the spacing consistent
            graphic.DrawString("Products Information:", new Font("Courier New", 16, FontStyle.Bold), new SolidBrush(Color.Blue), startX, startY + offset);
            offset = offset + (int)fontHeight + 20;

            graphic.DrawString("Product Name", font, new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString("Quantity", font, new SolidBrush(Color.Black), startX + 186 + 100, startY + offset);
            graphic.DrawString("Per Unit Price", font, new SolidBrush(Color.Black), startX + 186 + 186 + 100, startY + offset);
            graphic.DrawString("Total Price", font, new SolidBrush(Color.Black), startX + 186 + 186 + 186 + 100 - 5, startY + offset);
            offset = offset + (int)fontHeight;
            graphic.DrawString("--------------------------------------------------------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 05; //make the spacing consistent

            for (int i = 0; i <= _cellCount; i++)
            {
                graphic.DrawString(dataGridViewRecipt.Rows[i].Cells[0].Value.ToString(), font, new SolidBrush(Color.Black), startX, startY + offset);
                graphic.DrawString(dataGridViewRecipt.Rows[i].Cells[1].Value.ToString(), font, new SolidBrush(Color.Black), startX + 186 + 20 + 100, startY + offset);
                graphic.DrawString(dataGridViewRecipt.Rows[i].Cells[2].Value.ToString(), font, new SolidBrush(Color.Black), startX + 186 + 186 + 32 + 100, startY + offset);
                graphic.DrawString(dataGridViewRecipt.Rows[i].Cells[3].Value.ToString(), font, new SolidBrush(Color.Black), startX + 186 + 186 + 186 + 20 + 100, startY + offset);
                offset = offset + (int)fontHeight;
            }
            offset = offset + (int)fontHeight + 10;
            graphic.DrawString("Grand Total: ", new Font("Courier New", 14, FontStyle.Bold), new SolidBrush(Color.Red), startX + 186 + 186 + 186 - 110, startY + offset);
            graphic.DrawString(_totalAmount.ToString("#.##"), new Font("Courier New", 14, FontStyle.Bold), new SolidBrush(Color.Red), startX + 186 + 186 + 186 + 20 + 100-20+10, startY + offset);
            offset = offset + (int)fontHeight + 20;
            //Page End

            _amountHaveToPay = (int)Math.Round(Convert.ToDouble(totalAmount));

            graphic.DrawString("--------------------------------------------------------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 05; //make the spacing consistent
            graphic.DrawString("Cash Information:", new Font("Courier New", 16, FontStyle.Bold), new SolidBrush(Color.Blue), startX, startY + offset);
            offset = offset + (int)fontHeight + 10;
            graphic.DrawString("Amount Have To Pay: " + _amountHaveToPay, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight;

            graphic.DrawString("In Words: " + NumWordsWrapper(Convert.ToDouble(totalAmount)) + " Taka Only", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight;
            graphic.DrawString("Cash Received: " + cashReceived, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight;
            graphic.DrawString("Change Amount: " + changeAmount, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 40;
            graphic.DrawString("--------------------------------------", font, new SolidBrush(Color.Black), startX + 413, startY + offset);
            offset = offset + (int)fontHeight;
            graphic.DrawString("              Checked By              ", font, new SolidBrush(Color.Black), startX + 413, startY + offset);
        }

        private void txtCashReceived_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lblChangedAmunt.Text = (Double.Parse(txtCashReceived.Text.Trim()) - Math.Round(Double.Parse(lblTotalAmount.Text.Trim()))).ToString(CultureInfo.InvariantCulture);
            }
            catch (Exception )
            {
                lblChangedAmunt.Text = @"0";
                MessageBox.Show(@"Please enter cash received amount", @"Cash Received Blank Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private String NumWordsWrapper(double n)
        {
            double intPart;
            double decPart = 0;
            if (n == 0.0)
                return "zero";
            try
            {
                string[] splitter = n.ToString().Split('.');
                intPart = double.Parse(splitter[0]);
                decPart = double.Parse(splitter[1]);
            }
            catch
            {
                intPart = n;
            }

            var words = NumWords(intPart);

            if (decPart > 0)
            {
                if (words != "")
                    words += " and ";
                int counter = decPart.ToString(CultureInfo.InvariantCulture).Length;
                switch (counter)
                {
                    case 1: words += NumWords(decPart) + " tenths"; break;
                    case 2: words += NumWords(decPart) + " hundredths"; break;
                    case 3: words += NumWords(decPart) + " thousandths"; break;
                    case 4: words += NumWords(decPart) + " ten-thousandths"; break;
                    case 5: words += NumWords(decPart) + " hundred-thousandths"; break;
                    case 6: words += NumWords(decPart) + " millionths"; break;
                    case 7: words += NumWords(decPart) + " ten-millionths"; break;
                }
            }
            return words;
        }

        private String NumWords(double n) //converts double to words
        {
            string[] numbersArr = new string[] { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
            string[] tensArr = new string[] { "Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninty" };
            string[] suffixesArr = new string[] { "Thousand", "Million", "Billion", "Trillion", "Quadrillion", "Quintillion", "Sextillion", "Septillion", "Octillion", "Nonillion", "Decillion", "Undecillion", "Duodecillion", "Tredecillion", "Quattuordecillion", "Quindecillion", "Sexdecillion", "Septdecillion", "Octodecillion", "Novemdecillion", "Vigintillion" };
            string words = "";

            bool tens = false;

            if (n < 0)
            {
                words += "negative ";
                n *= -1;
            }

            int power = (suffixesArr.Length + 1) * 3;

            while (power > 3)
            {
                double pow = Math.Pow(10, power);
                if (n >= pow)
                {
                    if (n % pow > 0)
                    {
                        words += NumWords(Math.Floor(n / pow)) + " " + suffixesArr[(power / 3) - 1] + ", ";
                    }
                    else if (n % pow == 0)
                    {
                        words += NumWords(Math.Floor(n / pow)) + " " + suffixesArr[(power / 3) - 1];
                    }
                    n %= pow;
                }
                power -= 3;
            }
            if (n >= 1000)
            {
                if (n % 1000 > 0) words += NumWords(Math.Floor(n / 1000)) + " thousand, ";
                else words += NumWords(Math.Floor(n / 1000)) + " thousand";
                n %= 1000;
            }
            if (0 <= n && n <= 999)
            {
                if ((int)n / 100 > 0)
                {
                    words += NumWords(Math.Floor(n / 100)) + " hundred";
                    n %= 100;
                }
                if ((int)n / 10 > 1)
                {
                    if (words != "")
                        words += " ";
                    words += tensArr[(int)n / 10 - 2];
                    tens = true;
                    n %= 10;
                }

                if (n < 20 && n > 0)
                {
                    if (words != "" && tens == false)
                        words += " ";
                    words += (tens ? " " + numbersArr[(int)n - 1] : numbersArr[(int)n - 1]);
                    n -= Math.Floor(n);
                }
            }

            return words;

        }

        private void dataGridViewRecipt_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Double price = Convert.ToDouble(dataGridViewRecipt.Rows[e.RowIndex].Cells[1].Value.ToString()) * Convert.ToDouble(dataGridViewRecipt.Rows[e.RowIndex].Cells[2].Value.ToString());
                dataGridViewRecipt.Rows[e.RowIndex].Cells[3].Value = price.ToString();
                _totalAmount = 0;
                for (int i = 0; i <= _cellCount; i++)
                {
                    _totalAmount += Convert.ToDouble(dataGridViewRecipt.Rows[i].Cells[3].Value.ToString());
                }
                lblTotalAmount.Text = Convert.ToString(Math.Round(_totalAmount));
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter quantity amount.", "Quantity Missing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCustomerContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtCustomerName.Text == "" || txtCustomerAddress.Text == "" || txtCustomerContactNo.Text == "")
                {
                    MessageBox.Show("Please fill all values for creating a new customer", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "Insert into [Customer] (name, address, contact_number) values (@nam, @add, @cn)";
                    cmd.Parameters.AddWithValue("@nam", txtCustomerName.Text);
                    cmd.Parameters.AddWithValue("@add", txtCustomerAddress.Text);
                    cmd.Parameters.AddWithValue("@cn", txtCustomerContactNo.Text);

                    cmd.Connection = _con;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New Customer added.", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    using (SqlConnection conn = new SqlConnection(Connectionstring))
                    {
                        string query = "SELECT * FROM Customer";
                        using (SqlCommand cmd1 = new SqlCommand(query, conn))
                        {
                            conn.Open();
                            using (SqlDataReader reader = cmd1.ExecuteReader())
                            {

                                while (reader.Read())
                                {
                                    ///Adding Customer Data
                                    ///
                                    _customerInfo = new CustomerInfo(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                                }
                            }
                        }
                    }
                    _con.Close();
                }
            }
        }
    }
}
