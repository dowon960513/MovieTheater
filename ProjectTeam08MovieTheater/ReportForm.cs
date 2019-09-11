using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectTeam08MovieTheater.EF_Classes;
using System.Data.Entity;

namespace ProjectTeam08MovieTheater
{
    public partial class ReportForm : Form
    {
        private MovieTicketEntities context;

        public ReportForm()
        {
            InitializeComponent();

            context = new MovieTicketEntities();

            //add event handlers
            this.Load += ReportForm_Load;
            listBoxMovie.SelectedIndexChanged += ListBoxMovie_SelectedIndexChanged;
        }

        private void ListBoxMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            //list to store selected movie from listbox
            List<string> selectedMovie = new List<string>();

            //add selected item in the listbox
            for (int i = 0; i < listBoxMovie.SelectedItems.Count; i++)
                selectedMovie.Add(listBoxMovie.SelectedItems[i].ToString());

            //select order amount to display
            var movieProfit = (from profit in context.Order
                              from movie in context.Movie
                              from selected in selectedMovie
                              where selected == movie.MovieTitle
                              where movie.MovieId == profit.MovieId
                              select profit.OrderAmount);

            //when the number of certain movie is more than one
            if (movieProfit.Count() > 0)
                labelSelectedMovieProfit.Text = movieProfit.Sum().ToString("c2");
            else
                labelSelectedMovieProfit.Text = "$0";

        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            context.Order.Load();

            //context.Database.ExecuteSqlCommand($"DBCC CHECKIDENT('Order', RESEED, 0)");

            //setting for order datagridview
            dataGridViewOrder.DataSource = context.Order.Local.ToBindingList();
            dataGridViewOrder.ReadOnly = true;
            dataGridViewOrder.AllowUserToAddRows = false;
            dataGridViewOrder.Columns["MovieId"].Visible = false;
            dataGridViewOrder.Columns["CustId"].Visible = false;
            dataGridViewOrder.Columns["TimeId"].Visible = false;
            dataGridViewOrder.Columns["Customer"].Visible = false;
            dataGridViewOrder.Columns["Movie"].Visible = false;
            dataGridViewOrder.Columns["Time"].Visible = false;
            dataGridViewOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            //setting for listbox
            listBoxMovie.Items.Clear();
            listBoxMovie.SelectionMode = SelectionMode.MultiExtended;

            //select the movie list from movie table
            var movieList = context.Movie.Select(p => p.MovieTitle).OrderBy(p => p);

            //add list to listbox
            listBoxMovie.Items.AddRange(movieList.Distinct().ToArray());

            //display the profit of selected movies
            var profit = (from p in context.Order
                          select p.OrderAmount);

            //only when the transaction is more than one
            if (profit.Count() > 0)
                labelTotalProfit.Text = profit.Sum().ToString("c2");
            else
                labelTotalProfit.Text = "$0";
        }
    }
}
