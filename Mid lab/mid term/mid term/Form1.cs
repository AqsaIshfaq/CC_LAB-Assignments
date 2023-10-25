using System;
using System.Text;
using System.Windows.Forms;

namespace mid_term
{
    public partial class Form1 : Form
    {
        private const string UppercaseCharacters = "Abcdef";
        private const string Numbers = "0002";
        private const string SpecialCharacters = "!@#$%^&*()_+-=[]{}|;:'\",.<>?";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;

            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                MessageBox.Show("Please enter both first and last names.");
                return;
            }

            string initials = $"{firstName[0]}{lastName[0]}";

            Random random = new Random();
            StringBuilder password = new StringBuilder();

            password.Append(initials);
            password.Append(UppercaseCharacters[random.Next(UppercaseCharacters.Length)]);

            for (int i = 0; i < 4; i++)
            {
                password.Append(Numbers[random.Next(Numbers.Length)]);
            }

            for (int i = 0; i < 2; i++)
            {
                password.Append(SpecialCharacters[random.Next(SpecialCharacters.Length)]);
            }

            int remainingLength = 16 - password.Length;
            string allCharacters = UppercaseCharacters + Numbers + SpecialCharacters;

            for (int i = 0; i < remainingLength; i++)
            {
                password.Append(allCharacters[random.Next(allCharacters.Length)]);
            }

            char[] shuffledPassword = password.ToString().ToCharArray();
            for (int i = shuffledPassword.Length - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                char temp = shuffledPassword[i];
                shuffledPassword[i] = shuffledPassword[j];
                shuffledPassword[j] = temp;
            }

            string generatedPassword = new string(shuffledPassword);
            lblGeneratedPassword.Text = "Generated Password: " + generatedPassword;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGeneratePassword_Click_1(object sender, EventArgs e)
        {
            {
                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;

                if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
                {
                    MessageBox.Show("Please enter both first and last names.");
                    return;
                }

                string initials = $"{firstName[0]}{lastName[0]}";

                Random random = new Random();
                StringBuilder password = new StringBuilder();

                password.Append(initials);
                password.Append(UppercaseCharacters[random.Next(UppercaseCharacters.Length)]);

                for (int i = 0; i < 4; i++)
                {
                    password.Append(Numbers[random.Next(Numbers.Length)]);
                }

                for (int i = 0; i < 2; i++)
                {
                    password.Append(SpecialCharacters[random.Next(SpecialCharacters.Length)]);
                }

                int remainingLength = 16 - password.Length;
                string allCharacters = UppercaseCharacters + Numbers + SpecialCharacters;

                for (int i = 0; i < remainingLength; i++)
                {
                    password.Append(allCharacters[random.Next(allCharacters.Length)]);
                }

                char[] shuffledPassword = password.ToString().ToCharArray();
                for (int i = shuffledPassword.Length - 1; i > 0; i--)
                {
                    int j = random.Next(i + 1);
                    char temp = shuffledPassword[i];
                    shuffledPassword[i] = shuffledPassword[j];
                    shuffledPassword[j] = temp;
                }

                string generatedPassword = new string(shuffledPassword);
                lblGeneratedPassword.Text = "Generated Password: " + generatedPassword;
            }
        }
    }
}
