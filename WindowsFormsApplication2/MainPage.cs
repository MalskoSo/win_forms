using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }
        List<Hotel> result;

        private void LogOffButton_Click(object sender, EventArgs e)
        {
            CurrentUser.getInstance().currentClient = null;
            LoginForm nazad = new LoginForm();
            nazad.Show();
            this.Hide();
        }

        public void Redraw()
        {
            NameLabel.Text = CurrentUser.getInstance().currentClient.Name;
            SurnameLabel.Text = CurrentUser.getInstance().currentClient.Surname;
            BallanceLabel.Text = CurrentUser.getInstance().currentClient.Money.ToString();

            BookedView.Clear();
            BookedView.Visible = true;
            BookedView.View = View.Details;
            BookedView.Columns.Add("Address", 46);
            BookedView.Columns.Add("Name", 37);
            BookedView.Columns.Add("Total Price", 53);
            BookedView.Columns.Add("Price", 38);
            BookedView.Columns.Add("Free", 36);
            BookedView.Columns.Add("Owner", 37);

            SearchResultView.Clear();
            SearchResultView.Visible = true;
            SearchResultView.View = View.Details;
            SearchResultView.Columns.Add("Address", 53);
            SearchResultView.Columns.Add("Name", 50);
            SearchResultView.Columns.Add("Total Price", 55);
            SearchResultView.Columns.Add("Price", 50);
            SearchResultView.Columns.Add("Free", 50);
            SearchResultView.Columns.Add("Owner", 53);

            SearchResultView.Items.Clear();
            foreach (var hotel in result)
            {
                ListViewItem item;
                String[] resultFields = new String[6];
                resultFields[0] = hotel.Address.ToString();
                resultFields[1] = hotel.Name.ToString();
                resultFields[2] = hotel.TotalPrice.ToString();
                resultFields[3] = hotel.Price.ToString();
                resultFields[4] = hotel.Free.ToString();
                if (hotel.Owner == null)
                {
                    resultFields[5] = "nobody";
                }
                else
                {
                    resultFields[5] = hotel.Owner.Name + " " + hotel.Owner.Surname;
                }
                item = new ListViewItem(resultFields);
                SearchResultView.Items.Add(item);
            }

            BookedView.Items.Clear();
            foreach (var hotel in CurrentUser.getInstance().currentClient.BookedHotels)
            {
                ListViewItem item;
                String[] resultFields = new String[6];
                resultFields[0] = hotel.Address.ToString();
                resultFields[1] = hotel.Name.ToString();
                resultFields[2] = hotel.TotalPrice.ToString();
                resultFields[3] = hotel.Price.ToString();
                resultFields[4] = hotel.Free.ToString();
                if (hotel.Owner == null)
                {
                    resultFields[5] = "nobody";
                }
                else
                {
                    resultFields[5] = hotel.Owner.Name + " " + hotel.Owner.Surname;
                }
                item = new ListViewItem(resultFields);
                BookedView.Items.Add(item);
            }
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            result = new List<Hotel>();
            Redraw();
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            int torkal = SearchResultView.SelectedIndices[0];
            Hotel selectedHotel = result[torkal];
            if (Client.pokemon(selectedHotel))
            {
                MessageBox.Show("Gotcha!!");
                Redraw();
            }
            else
            {
                MessageBox.Show("Loozer((99(");
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            EditForm edit = new EditForm(this);
            edit.Show();
        }

        private void NameLabel_Click(object sender, EventArgs e)
        {

        }

        private void BookedView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            
            string text = SearchBox.Text;
            if (NameRadio.Checked)
            {
                result = Hotel.SearchByName(text);
            }
            else if (PriceRadio.Checked)
            {
                int price = Int32.Parse(text);
                result = Hotel.SearchByPrice(price);
            }
            else
            {
                result = Hotel.SearchByAddress(text);
            }
            Redraw();
        }

        private void AddHotelButton_Click(object sender, EventArgs e)
        {
            AddHotelForm add = new AddHotelForm();
            add.Show();
        }

        private void ReserveButton_Click(object sender, EventArgs e)
        { 
            int index = SearchResultView.SelectedIndices[0];
            Hotel selectedHotel = result[index];
            if(Hotel.reserve(selectedHotel))
            {
                MessageBox.Show("Tsoi is alive!!1!11!");
                Redraw();
            }
            else
            {
                MessageBox.Show("Naruto will be come HOKAGE");
            }
        }

        private void SearchResultView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
