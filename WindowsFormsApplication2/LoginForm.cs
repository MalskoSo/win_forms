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
    public partial class LoginForm : Form
    {
        SoundPlayer player = new SoundPlayer(@"S:\PedoBear.wav");
        SoundPlayer playerbaka = new SoundPlayer(@"F:\фігня\cc\BAKA.wav");
        SoundPlayer playernyaa = new SoundPlayer(@"F:\фігня\cc\Nyaa.wav");

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            MainForm home = new MainForm();
            home.Show();
            this.Hide();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string login = LoginBox.Text;
            string password = PasswordBox.Text;
            
            if(Client.LogIn(login, password))
            {
                
                playernyaa.Play();
                MessageBox.Show("Nyaa~~~");
                MainPage page = new MainPage();
                page.Show();
                player.Stop();
                this.Hide();
            }
            else
            {
                playerbaka.Play();
                MessageBox.Show("BAAKAAA");
                
            } 
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            player.Play();
        }
    }
}
