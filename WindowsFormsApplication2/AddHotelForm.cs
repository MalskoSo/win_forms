using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApplication2
{
    public partial class AddHotelForm : Form
    {
        SoundPlayer playerbaka = new SoundPlayer(@"F:\фігня\cc\BAKA.wav");
        SoundPlayer playernyaa = new SoundPlayer(@"F:\фігня\cc\Nyaa.wav");

        public AddHotelForm()
        {
            InitializeComponent();
        }

        private void AddHotelForm_Load(object sender, EventArgs e)
        {

        }

        private void ExitAddButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string name = NameAddBox.Text;
            string address = AddressAddBox.Text;
            int price = Int32.Parse(PriceAddBox.Text);
            int free = Int32.Parse(FreeAddBox.Text);
            int totalPrice = Int32.Parse(TotalPriceAddBox.Text);

            if (Hotel.AddHotel(address, name, price, free, totalPrice))
            {
                playernyaa.Play();
                MessageBox.Show("Nyaa~~~");
                this.Hide();
            }
            else
            {
                playerbaka.Play();
                MessageBox.Show("BAAKAAA");
            }
        }

        
    }
}
