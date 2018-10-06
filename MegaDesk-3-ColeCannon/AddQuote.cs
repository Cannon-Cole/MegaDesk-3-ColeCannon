using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_ColeCannon
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {

        }

        private void AddNewQuoteAccept_Click(object sender, EventArgs e)
        {

        }

        private void CancelQuote_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HeightInputValidation(object sender, CancelEventArgs e)
        {
            string errorMessage;
            int height;

            try
            { 
            height = System.Convert.ToInt32(HeightInput.Text);
            }
            catch(FormatException)
            {
                HeightInputErrorLabel.Text = "Not integer";
                height = 0;
            }
            catch (OverflowException)
            {
                HeightInputErrorLabel.Text = "Too big";
                height = 0;
            }

            if (height > 48)
            {
                errorMessage = "Height must be less than or equal to 48";
                HeightInputErrorLabel.Text = errorMessage;
                e.Cancel = true;
            }
            else if (height < 12)
            {
                errorMessage = "Height must be greater than or equal to 12";
                HeightInputErrorLabel.Text = errorMessage;
                e.Cancel = true;
            }
            else
            {
                HeightInputErrorLabel.Text = "";
            }
        }
    }
}