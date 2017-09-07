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
    public partial class EditForm : Form
    {
        SoundPlayer playerbaka = new SoundPlayer(@"F:\фігня\cc\BAKA.wav");
        SoundPlayer playernyaa = new SoundPlayer(@"F:\фігня\cc\Nyaa.wav");
        MainPage mpage;
        public EditForm()
        {
            InitializeComponent();
        }

        public EditForm(MainPage mp)
        {
            mpage = mp;
            InitializeComponent();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            MainPage exit = new MainPage();
            this.Hide(); 
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            Client user = CurrentUser.getInstance().currentClient;
            if (NameEditBox.Text != "")
            {
                user.Name = NameEditBox.Text;
                MainPage confirm = new MainPage();
                this.Hide();
            }
            if (SurnameEditBox.Text != "")
            {
                user.Surname = SurnameEditBox.Text;
                MainPage confirm = new MainPage();
                this.Hide();
            }
            if (PasswordEdit1Box.Text == user.Password)
            {
                if (PasswordEdit2Box.Text == PasswordEdit3Box.Text)
                {
                    if (PasswordEdit3Box.Text != "")
                    {
                        user.Password = PasswordEdit3Box.Text;
                        MainPage confirm = new MainPage();
                        this.Hide();
                    }
                    else
                    {
                        playerbaka.Play();
                        MessageBox.Show("BAAKAAA");
                    }
                }
                else
                {
                    playerbaka.Play();
                    MessageBox.Show("BAAKAAA");
                }
            }
            if (PasswordEdit1Box.Text == "" && PasswordEdit2Box.Text == "" && PasswordEdit3Box.Text == "")
            {
                mpage.Redraw();
                this.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
