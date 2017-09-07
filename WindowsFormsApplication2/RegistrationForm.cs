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
    public partial class RegistrationForm : Form
    {
        SoundPlayer playerbaka = new SoundPlayer(@"F:\фігня\cc\BAKA.wav");
        SoundPlayer playernyaa = new SoundPlayer(@"F:\фігня\cc\Nyaa.wav");

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string name = NameBox.Text;
            string surname = SurnameBox.Text;
            string login = LoginBox.Text;
            string password = PasswordBox.Text;
            string sex = SexBox.Text;
            int money = Int32.Parse(MoneyBox.Text);
            int age = Int32.Parse(AgeBox.Text);
            Animal pet;
            if(PetsBox.Text == "Yes")
            {
                string petsName = NamePetsBox.Text;
                string petsBreed = BreedPetsBox.Text;
                string petsSize = SizePetsBox.Text;
                string petsMass = MassPetsBox.Text;
                pet = new Animal(petsName, petsBreed, petsSize, petsMass);
            }
            else
            {
                pet = null;
            }
            Car auto;
            if (AutoBox.Text == "Yes")
            {
                string autoBrand = BrandBox.Text;
                string autoSize = SizeBox.Text;
                auto = new Car(autoBrand, autoSize);
            }
            else
            {
                auto = null;
            }

            if (Client.Registration(name, surname, login, password, sex, money, age, pet, auto))
            {
                playernyaa.Play();
                MessageBox.Show("Nyaa~~~");
                LoginForm loginn = new LoginForm();
                loginn.Show();
                this.Hide();
            }
            else
            {
                playerbaka.Play();
                MessageBox.Show("BAAAKAA");
            }
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            MainForm home = new MainForm();
            home.Show();
            this.Hide();
        }

        private void PetsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string answer = (string)PetsBox.SelectedItem;
            if(answer == "Yes")
            {
                NamePetsLabel.Visible = true;
                BreedPetsLabel.Visible = true;
                SizePetsLabel.Visible = true;
                MassPetsLabel.Visible = true;
                NamePetsBox.Visible = true;
                BreedPetsBox.Visible = true;
                SizePetsBox.Visible = true;
                MassPetsBox.Visible = true;
            }
            else
            {
                MessageBox.Show("You are sick ublydok ಠ▃ಠ");
                NamePetsLabel.Visible = false;
                BreedPetsLabel.Visible = false;
                SizePetsLabel.Visible = false;
                MassPetsLabel.Visible = false;
                NamePetsBox.Visible = false;
                BreedPetsBox.Visible = false;
                SizePetsBox.Visible = false;
                MassPetsBox.Visible = false;
            }
        }

        private void SexBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NamePetsBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void AutoBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string theQuestion = (string)AutoBox.SelectedItem;
            if(theQuestion == "Yes")
            {
                BrandLabel.Visible = true;
                SizeLabel.Visible = true;
                BrandBox.Visible = true;
                SizeBox.Visible = true;
            }
            else
            {
                MessageBox.Show("You are dnishebrod, BITCH!!1!11");
                BrandLabel.Visible = false;
                SizeLabel.Visible = false;
                BrandBox.Visible = false;
                SizeBox.Visible = false;
            }
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
