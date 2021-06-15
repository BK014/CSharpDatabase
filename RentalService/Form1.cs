using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentalService.Models;

namespace RentalService
{
    public partial class Form1 : Form
    {
        DAO dao;
        List<Customer> customers;
        List<Movies> movies;
        List<RentedMovies> rentedMovies;

        public Form1()
        {
            InitializeComponent();
            dao = new DAO();
            BindGridViews();
        }

        // Binds all the data grid views to its data source that is the list elements or functions that return a list.
        private void BindGridViews()
        {
            customers = dao.GetAllCustomers();
            customerGridView.DataSource = customers;

            movies = dao.GetAllMovies();
            moviesGridView.DataSource = movies;
            BindRentedMoviesGridView(dao.GetAllRentedMovies());

            customersMoreMoviesGridView.DataSource = dao.GetCustomersBorrowingMoreMovies();
            mostBorrowedMoviesDataGrid.DataSource = dao.GetMostBorrowedMovies();
        }

        // This function binds the rented movies grid view to a particular data source.
        private void BindRentedMoviesGridView(List<RentedMovies> movies)
        {
            rentedMovies = movies;
            rentedMoviesDataGrid.DataSource = rentedMovies;
        }


        // Handles the event when the user clicks the add customer button. A customer is added.
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer
            {
                Address = tbAddress.Text,
                FirstName = tbFirstName.Text,
                LastName = tbLastName.Text,
                Phone = tbPhone.Text
            };
            dao.AddCustomer(customer);
            MessageBox.Show("Customer Added");

            // Binds all the grid views again.
            BindGridViews();
            MakeBlankCustomerText();
        }


        // Makes all the text boxes related to the customers section blank. 
        private void MakeBlankCustomerText()
        {
            tbFirstName.Text = "";
            tbCustID.Text = "";
            tbLastName.Text = "";
            tbPhone.Text = "";
            tbAddress.Text = "";
        }


        // Handles event when the user clicks the add movie button. It basically adds a movie
        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            Movies movie = new Movies
            {
                Copies = tbCopies.Text,
                Genre = tbGenre.Text,
                Plot = tbPlot.Text,
                Rating = tbRating.Text,
                Title = tbMovieTitle.Text,
                Year = tbYear.Text
            };
            dao.AddMovie(movie);
            MessageBox.Show("Movie Added");

            // Binds all the grid views again.
            BindGridViews();
            MakeBlankMovieText();
        }


        // Makes all the text boxes related to the Movies section blank.
        private void MakeBlankMovieText()
        {
            tbMovieTitle.Text = "";
            tbPlot.Text = "";
            tbGenre.Text = "";
            tbYear.Text = "";
            tbRating.Text = "";
            tbCopies.Text = "";
            tbMovieId.Text = "";
        }

        // When the user selects a row on the customer grid view, the details of the customer gets filled in the text boxes.The textboxes are then used for updating or deleting the customers.
        private void customerGridView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            // If the row is not selected then return
            if (e.StateChanged != DataGridViewElementStates.Selected) return;

            // If the last element is deleted from the table the condition handles that case.
            if(e.Row.Index < customers.Count)
            {
                Customer customer = customers[e.Row.Index];
                tbFirstName.Text = customer.FirstName;
                tbCustID.Text = customer.CustID.ToString();
                tbLastName.Text = customer.LastName;
                tbPhone.Text = customer.Phone;
                tbAddress.Text = customer.Address;
            }
        }

        // When the user selects a row on the movies grid view, the details of the movie gets filled in the text boxes. The textboxes are then used for updating or deleting the movies
        private void moviesGridView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            // If the row is not selected then return
            if (e.StateChanged != DataGridViewElementStates.Selected) return;

            // If the last element is deleted from the table the condition handles that case.
            if (e.Row.Index < movies.Count)
            {
                Movies movie = movies[e.Row.Index];
                tbMovieTitle.Text = movie.Title;
                tbPlot.Text = movie.Plot;
                tbGenre.Text = movie.Genre;
                tbYear.Text = movie.Year;
                tbRating.Text = movie.Rating;
                tbCopies.Text = movie.Copies;
                tbMovieId.Text = movie.MovieId.ToString();
            }
        }

        // Hanldes the update movie button click.
        private void btnUpdateMovie_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(tbMovieId.Text))
            {
                MessageBox.Show("Select A Movie first");
            }
            else
            {
                Movies movie = new Movies
                {
                    Copies = tbCopies.Text,
                    Genre = tbGenre.Text,
                    Plot = tbPlot.Text,
                    Rating = tbRating.Text,
                    Title = tbMovieTitle.Text,
                    Year = tbYear.Text,
                    MovieId = Convert.ToInt32(tbMovieId.Text)
                };
                dao.UpdateMovie(movie);
                MessageBox.Show("Movie Updated");
                BindGridViews();
                MakeBlankMovieText();
            }            
        }

        // Hanldes delete movie button click 
        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbMovieId.Text))
            {
                MessageBox.Show("Select A Movie first");
            }
            else
            {
                dao.DeleteMovie(Convert.ToInt32(tbMovieId.Text));
                MessageBox.Show("Movie Deleted");
                BindGridViews();
                MakeBlankMovieText();
            }
        }


        // handles update customer button click
        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(tbCustID.Text))
            {
                MessageBox.Show("Select A Customer first");
            }
            else
            {
                Customer customer = new Customer
                {
                    Address = tbAddress.Text,
                    FirstName = tbFirstName.Text,
                    LastName = tbLastName.Text,
                    Phone = tbPhone.Text,
                    CustID = Convert.ToInt32(tbCustID.Text)
                };
                dao.UpdateCustomer(customer);
                MessageBox.Show("Customer Updated");
                BindGridViews();
                MakeBlankCustomerText();
            }
        }


        // hanldes delete customer button click
        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbCustID.Text))
            {
                MessageBox.Show("Select A Customer first");
            }
            else
            {
                dao.DeleteCustomer(Convert.ToInt32(tbCustID.Text));
                MessageBox.Show("Customer Deleted");
                BindGridViews();
                MakeBlankCustomerText();
            }
        }

        // Handles the click event when the user clicks the Issue Movie button
        private void btnIssueMovie_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbCustID.Text))
            {
                MessageBox.Show("Select A Customer first");
                return;
            }
            if (String.IsNullOrEmpty(tbMovieId.Text))
            {
                MessageBox.Show("Select A Movie first");
                return;
            }
            RentedMovies rentedMovies = new RentedMovies
            {
                CustIDFK = Convert.ToInt32(tbCustID.Text),
                MovieIDFK = Convert.ToInt32(tbMovieId.Text),
                DateRented = DateTime.Now
            };
            dao.IssueMovie(rentedMovies);
            MessageBox.Show("Movie Issued to Customer");
            BindGridViews();
            tbRMID.Text = "";
            MakeBlankCustomerText();
            MakeBlankMovieText();
        }

        // Handles the click event when the user clicks the Issue Return button
        private void btnReturnMovie_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(tbRMID.Text))
            {
                MessageBox.Show("Select A Rented Movie first");
                return;
            }
            RentedMovies rentedMovie = new RentedMovies
            {
                RMID = Convert.ToInt32(tbRMID.Text),
                DateReturned = DateTime.Now
            };
            if(rentedMovies.FirstOrDefault(r=>r.RMID == rentedMovie.RMID).DateReturned != null)
            {
                MessageBox.Show("The Movie is already returned.");
                return;
            }
            dao.ReturnMovie(rentedMovie);
            MessageBox.Show("Movie Returned by Customer");
            BindGridViews();
            tbRMID.Text = "";
        }

        // When the user selects the row in the rented movies grid view, the RMID text box is populated with the value and that is used further when to return a movie.
        private void rentedMoviesDataGrid_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;
            RentedMovies rentedMovie = rentedMovies[e.Row.Index];
            tbRMID.Text = rentedMovie.RMID.ToString();
        }

        private void rbAllRented_CheckedChanged(object sender, EventArgs e)
        {
            if(((RadioButton)sender).Checked)
            {
                BindRentedMoviesGridView(dao.GetAllRentedMovies());
            }
        }

        private void rbOutRented_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                BindRentedMoviesGridView(dao.GetAllOutMovies());
            }
        }
    }
}
