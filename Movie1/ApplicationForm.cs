
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
using Movie1.DataBaseOperations;
namespace Movie1
{
    public partial class ApplicationForm : Form
    {
        public ApplicationForm()
        {
            InitializeComponent();
            listBox1RentedMOvies.Enabled = false;
        }

        // add customers 
        private void AddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                string name, address, phone;
                name = txtName.Text.Trim();
                address = txtAddress.Text.Trim();
                phone = txtPhone.Text.Trim();

                if (name == "")
                {
                    MessageBox.Show("Please enter Customer name !");

                }
                else if (address == "")
                {
                    MessageBox.Show(" Please enter Customer address!");

                }
                else if (phone == "")
                {
                    MessageBox.Show("Please enter phone number!");

                }

                else
                {

                    if (new Customer().AddCustomer(name, address, phone))
                    {

                        BindDdlCustomer(); // method calling to Bind dropdownlist Customer
                        BindGridOurCustomers(); // method calling to Bind GridView OurCustomer
                        MessageBox.Show("Well done! customer added!!!", "Information");
                        // set active tab => CUSTOMER
                        TabControl.SelectedTab = TabControl.TabPages["OurCustomers"];
                        txtAddress.Clear();
                        txtName.Clear();
                        txtPhone.Clear();

                    }
                    else
                    {
                        MessageBox.Show("Unable to add this customer!!!");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Connection.DisposeConnection();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindDdlCustomer(); // method calling

            BindGridOurCustomers(); // method calling to bind customer grid
            BindDdlMovie(); // method calling to Bind dropdownlist movie


        }


        //bind movies grid
        private void BindGridMyMovies()
        {
            DataTable dsTable = new Movie().GetAllMovies();
            gvMovies.DataSource = dsTable;
            gvMovies.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        //Bind Customer Grid to show data
        private void BindGridOurCustomers()
        {
            DataTable ds = new Customer().GetAllCustomers();
            CustomersDataGridView.DataSource = ds;
            CustomersDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        // Bind rented movies grid
        private void BindGridRentedMovies()
        {
            DataTable ds = new RentalMovie().GetAllRentedData();
            gvRental.DataSource = ds;
            gvRental.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        //Bind dropdownlist Customer to show data 
        private void BindDdlCustomer()
        {
            DataTable ds = new Customer().GetAllCustomers();

            DataRow row = ds.NewRow();
            row[0] = 0;
            row[1] = "--Choose--";
            ds.Rows.InsertAt(row, 0); 

            ddlCustomer.DisplayMember = "Name";
            ddlCustomer.ValueMember = "CustId";
            ddlCustomer.DataSource = ds; // Bind customer in Customer section
          
            
            // Bind customer in Movie Return section
            ddlAllCust.DisplayMember = "Name";
            ddlAllCust.ValueMember = "CustId";
            ddlAllCust.DataSource = ds;
        }

        // Bind ddl movies Available for rent
        private void BindDdlMovie()
        {
            DataTable dsMovie = new Movie().GetMoviesForDDL();

            DataRow row = dsMovie.NewRow();
            row[0] = 0;
            row[1] = "--Choose--";
            dsMovie.Rows.InsertAt(row, 0);

            ddlMovie.DisplayMember = "Title";
            ddlMovie.ValueMember = "MovieID";
            ddlMovie.DataSource = dsMovie;

        }

        // to delete a customer
        private void DeleteCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                
                string custId = ddlCustomer.SelectedValue.ToString();
                
                    DialogResult result = MessageBox.Show("You want to delete this customer?", "Warning", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        if (new Customer().DeleteCustomer(custId))
                        {
                            BindDdlCustomer(); // method calling to Bind dropdownlist Customer
                            BindGridOurCustomers(); // method calling to Bind GridView OurCustomer
                            txtName.Clear();
                            txtAddress.Clear();
                            txtPhone.Clear();
                            ddlCustomer.SelectedIndex = 0;
                            MessageBox.Show("Well done! Customer Deleted!!!");
                        }
                        else
                        {
                            MessageBox.Show("Unable to delete this customer");
                        }
                    }
                    

            }
            catch (Exception ex)
            {

                if (ex.Message.Contains("REFERENCE"))
                {
                    MessageBox.Show("you Can't delete this record as the customer rented a movie!!!");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
            finally
            {
                Connection.DisposeConnection();
            }
        }

        //Update customer info
        private void UpdateCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                
                string custId = ddlCustomer.SelectedValue.ToString();
                string name, address, phone;
                name = txtName.Text.Trim();
                address = txtAddress.Text.Trim();
                phone = txtPhone.Text.Trim();

                if (name == "")
                {
                    MessageBox.Show("Please Enter Customer Name");
                    
                }
                else if (address == "")
                {
                    MessageBox.Show("Please Enter Customer Address");
                   
                }
                else if (phone == "")
                {
                    MessageBox.Show("Please Enter Customer Phone number!");
                    
                }
               
                else
                {
                    
                    if (new Customer().UpdateCustomer(name, address, phone, custId))
                    {
                        
                        BindDdlCustomer(); // method calling to Bind dropdownlist Customer
                        BindGridOurCustomers(); // method calling to Bind GridView OurCustomer
                       
                        MessageBox.Show("Well done! Customer updated!!!","Information");
                        txtName.Clear();
                        txtAddress.Clear();
                        txtPhone.Clear();
                        ddlCustomer.SelectedIndex = 0;
                        // set Active tab => CUSTOMER
                        TabControl.SelectedTab = TabControl.TabPages["OurCustomers"];
                    }
                    else
                    {
                        MessageBox.Show("Unable to update this customer!");
                    }
                }

            }
            catch (Exception ex)
            {
                    MessageBox.Show(ex.Message);
            }
            finally
            {
                Connection.DisposeConnection();
            }
        }

        // Add New movie 
        private void btnAddMOvie_Click(object sender, EventArgs e)
        {
            try
            {       
                    string Title, RentCost, Year, Rating, Genre;
                    Title = txtTitle.Text.Trim();
                    RentCost = txtRentedCost.Text.Trim();
                    Rating = txtRating.Text.Trim();
                    Year = txtYear.Text.Trim();
                    Genre = txtGenre.Text.Trim();

                    if (Title=="")
                    {
                        MessageBox.Show("movie title is required!");
                    }
                    else if (Year=="")
                    {
                        MessageBox.Show("Released year is required!");
                    }
                   
                    else if (Genre=="")
                    {
                        MessageBox.Show("Genre is required!");
                    }
                    
                    else if (Rating=="")
                    {
                        MessageBox.Show("Rating is required!");
                    }
                    
                    else
                    {
                        
                        if (new Movie().AddMovie(Title,Year,Rating,Genre,RentCost))
                        {

                            BindGridMyMovies(); // method calling to Bind Grid MyMovies
                            BindDdlMovie(); // method calling to Bind dropdownlist Movies
                            MessageBox.Show("Well done! Movie Inseted!!!","Information");
                            //Set Active tab => Movies
                            TabControl.SelectedTab = TabControl.TabPages["MyMovies"];
                            txtTitle.Clear();
                            txtYear.Clear();
                            txtRating.Clear();
                            txtGenre.Clear();
                            txtRentedCost.Clear();
                        }
                    }
                
            }
            catch (Exception ex)
            {
                    MessageBox.Show(ex.Message);
            }
            finally
            {
                Connection.DisposeConnection();
            }
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (TabControl.SelectedTab == TabControl.TabPages["MyMovies"])
            {
                BindGridMyMovies(); // method calling to Bind Grid MyMovies
                BindDdlMovie(); // method calling to Bind dropdownlist Movies

            }
            else if (TabControl.SelectedTab == TabControl.TabPages["OurCustomers"])
            {
                BindDdlCustomer(); // method calling to Bind dropdownlist OurCustomer

                BindGridOurCustomers(); // method calling to Bind Grid OurCustomer
            }
            else if (TabControl.SelectedTab == TabControl.TabPages["RentedMovies"])
            {
                BindGridRentedMovies(); //method calling to Bind Grid for all rental movies
               
            }
        }

        //delete one movie
        private void btnDelMOvie_Click(object sender, EventArgs e)
        {
            try
            {
                TabControl.SelectedTab = TabControl.TabPages["MyMovies"];
                string MovieID = ddlMovie.SelectedValue.ToString();

                DialogResult result = MessageBox.Show("You want to delete this Movie?", "Warning", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (new Movie().DeleteMovie(MovieID))
                    {
                        BindDdlMovie(); // method calling to Bind dropdownlist movie
                        BindGridMyMovies(); // method calling to Bind GridView Mymovie
                        MessageBox.Show("Well done! Movie Deleted!!!","Information");

                        txtTitle.Clear();
                        txtYear.Clear();
                        txtRating.Clear();
                        txtGenre.Clear();
                        txtRentedCost.Clear();

                        ddlMovie.SelectedIndex = 0;
                    }
                    else
                    {
                        MessageBox.Show("Unable to delete this movie");
                    }
                }
                else
                {
                    // Not deleted
                }

            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("REFERENCE"))
                {
                    MessageBox.Show("Can not delete this movie as it is rented by a customer!");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
            finally
            {
                Connection.DisposeConnection();
            }
        }

        //Update Movie Data
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                

                string MovieId = ddlMovie.SelectedValue.ToString();

                string Title, RentCost, Year, Rating, Genre;
                Title = txtTitle.Text.Trim();
                RentCost = txtRentedCost.Text.Trim();
                Rating = txtRating.Text.Trim();
                Year = txtYear.Text.Trim();
                Genre = txtGenre.Text.Trim();

                if (Title=="")
                {
                    MessageBox.Show("Movie title is required!");
                }
                else if (Year=="")
                {
                    MessageBox.Show("Released year is required!");
                }
               
                else if (Genre=="")
                {
                    MessageBox.Show("Genre is required!");
                }
                
               
                else if (Rating=="")
                {
                    MessageBox.Show("Rating is required!");
                }
                
                else
                {
                   
                    if (new Movie().UpdateMovie(Title,Year,Rating,Genre,RentCost, MovieId))
                    {

                        BindGridMyMovies(); // method calling to Bind Grid MyMovies
                        BindDdlMovie(); // method calling to Bind dropdownlist Movies
                        MessageBox.Show("well done! Movie Updated!!!","Information");
                        TabControl.SelectedTab = TabControl.TabPages["MyMovies"];
                        txtTitle.Clear();
                        txtYear.Clear();
                        txtRating.Clear();
                        txtGenre.Clear();
                        txtRentedCost.Clear();
                        ddlMovie.SelectedIndex = 0;
                    }
                    else
                    {
                        MessageBox.Show("Unable to update this Movie!");

                    }
                }
            }
            catch (Exception ex)
            {
                    MessageBox.Show(ex.Message);
            }
            finally
            {
                Connection.DisposeConnection();
            }
        }

        private void ddlCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Bind Customer details on selection changed
            try
            {
                int CustId = int.Parse(ddlCustomer.SelectedValue.ToString());
                if (CustId > 0)
                {
                    string[] data = new Customer().GetCustomersInfo(CustId);

                    if (data != null)
                    {
                        txtName.Text = data[0];
                        txtAddress.Text = data[1];
                        txtPhone.Text = data[2];
                    }

                }
                else
                {
                    txtAddress.Clear();
                    txtName.Clear();
                    txtPhone.Clear();
                    listBox1RentedMOvies.Enabled = false;
                    
                }
               
            }
            catch (Exception ex)
            {
                    MessageBox.Show(ex.Message);
            }
            finally
            {
                Connection.DisposeConnection();
            }
        }

        //Bind movie details on selection changed
        private void ddlMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // get "movie id" here
                int MovieId = int.Parse(ddlMovie.SelectedValue.ToString());
                if (MovieId > 0)
                {

                    string[] data = new Movie().GetMoviesInfo(MovieId);
                    if (data != null)
                    {
                       
                        txtTitle.Text = data[0];
                        txtYear.Text = data[1];
                        txtRentedCost.Text = data[2];
                        txtRating.Text = data[3];
                        txtGenre.Text = data[4];
                        
                    }

                }
                else
                {
                    txtTitle.Clear();
                    txtYear.Clear();
                    txtRentedCost.Clear();
                    txtRating.Clear();
                    txtGenre.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Special Info
        private void button1ShowData_Click(object sender, EventArgs e)
        {
            try
            {
                //Customer Who Borrows Most Movies
                if (radioButton1.Checked)
                {
                    TabControl.SelectedTab = TabControl.TabPages["RentedMovies"];

                    DataTable dt = new RentalMovie().BorrowMostMovies();
                    gvRental.DataSource = dt;
                    gvRental.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
                else if (radioButton2.Checked) //Most Popular Movies
                {
                    TabControl.SelectedTab = TabControl.TabPages["RentedMovies"];
                    DataTable dt = new RentalMovie().PopularMovies();
                    gvRental.DataSource = dt;
                    gvRental.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                
                }
                else if (radioButton3.Checked) //Show All Rented Movies
                {
                    TabControl.SelectedTab = TabControl.TabPages["RentedMovies"];
                    BindGridRentedMovies();
                }
            }
            catch (Exception ex)
             {
                MessageBox.Show(ex.Message);
            }
        }

        private void ddlAllCust_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                int CustID = int.Parse(ddlAllCust.SelectedValue.ToString());
                if (CustID > 0)
                {
                    listBox1RentedMOvies.Enabled = true;

                    SqlCommand cmd = Connection.StartConnection().CreateCommand();
                    string query = "select rm.MovieID, Title from RentedMovies rm join myMovies mv on rm.movieid= mv.movieid where rentedDate is not null and custid=@custID group by Title, rm.MovieID";
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@custID", CustID);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                   
                    if (dt.Rows.Count > 0)
                    {

                        listBox1RentedMOvies.DisplayMember = "Title";
                        listBox1RentedMOvies.ValueMember = "MovieID";
                        listBox1RentedMOvies.DataSource = dt;
                        da.Dispose();
                        cmd.Dispose();

                    }
                    else
                    {
                        listBox1RentedMOvies.DisplayMember = "Title";
                        listBox1RentedMOvies.ValueMember = "MovieID";
                        listBox1RentedMOvies.DataSource = dt;
                        da.Dispose();
                        cmd.Dispose();
                        listBox1RentedMOvies.Enabled = false;
                        // disbale combox list of rented movies 
                    }
                }
                else
                {
                    txtAddress.Clear();
                    txtName.Clear();
                    txtPhone.Clear();
                    listBox1RentedMOvies.Enabled = false;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Compute the Rent Amount
        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string ReleaseYear = txtYear.Text.Trim();
                string PresentYear = DateTime.Now.Year.ToString();
                if (ReleaseYear=="")
                {
                    txtRentedCost.Text = "";
                }

                else
                {
                    int age = int.Parse(PresentYear) - int.Parse(ReleaseYear);
                    //if videos are older than 5 years (Release Date) then they cost $2 otherwise it cost $5
                    if (age > 5)
                    {
                        txtRentedCost.Text = "2";
                    }
                    else
                    {
                        txtRentedCost.Text = "5";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Issue movie to Customer
        private void btnIssueMovie_Click_1(object sender, EventArgs e)
        {
            try
            {
                //Set Active tab = Rented movies
               
                string CustId, MovieId, IssueDate, ReturnDate;
                
                CustId = ddlCustomer.SelectedValue.ToString();
                MovieId = ddlMovie.SelectedValue.ToString();
                IssueDate = dtIsuue.Value.ToShortDateString();
                ReturnDate = dtReturn.Value.ToShortDateString();
                if (CustId=="0")
                {
                    MessageBox.Show("Please select a Customer from customer panel","Information");
                }
                else if (MovieId=="0")
                {
                    MessageBox.Show("Please select a movie from movie panel","Information");
                }
                else
                {
                    if (new RentalMovie().RentMovie(CustId, MovieId, IssueDate, ReturnDate))
                     {

                            BindGridRentedMovies(); //method calling to Bind Grid for all rental movies
                                                   
                            MessageBox.Show("Well done! Movie rented to customer!!!","Information");
                        // set active tab = Rented movie
                        TabControl.SelectedTab = TabControl.TabPages["RentedMovies"];
                        ddlAllCust.SelectedIndex = 0;
                    }
                        else
                        {
                            MessageBox.Show("Failed to rent this movie");
                        }
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Connection.DisposeConnection();
            }
        }

        //Return movie - Implementation
        private void btnReturnMovie_Click_1(object sender, EventArgs e)
        {
            try
            {
                
                listBox1RentedMOvies.SelectionMode = SelectionMode.One;
                if (listBox1RentedMOvies.Items.Count > 0)
                {
                    int MoviId = int.Parse((listBox1RentedMOvies.SelectedItem as DataRowView)["MovieId"].ToString());
                    int CustId = int.Parse(ddlCustomer.SelectedValue.ToString());
                    if (CustId == 0)
                    {
                    }
                    if (new RentalMovie().ReturnMovie(MoviId, CustId))
                    {
                        
                        BindGridRentedMovies(); //method calling to Bind Grid for all rental movies

                        MessageBox.Show("Movie Returned by customer!!!");
                       
                    }
                    else
                    {
                        MessageBox.Show("Unable to return this movie!!!");
                    }
                    //Set Active tab => RentedMovies
                    TabControl.SelectedTab = TabControl.TabPages["RentedMovies"];
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Connection.DisposeConnection();
            }
        }

       
    }
}
