using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* 
 * 
 * Name: Brennan Collins
 * Date: 11/4/2021
 * Assignment: Create a form that consists of five radio buttons. Make each radio button
 * produce a different color to the background of the form.
 * 
 */
namespace CSC240_06_02_FiveColors2_bpc
{
    public partial class FiveColors2 : Form
    {
        public FiveColors2()
        {
            InitializeComponent();
            
        }
       

        // Changing form to BLUE
        private void UxBlueButton_CheckedChanged(object sender, EventArgs e)
        {

            // When BLUE is checked
            if (UxBlueButton.Checked)
            {

                // The drawing of the system (form) turns blue
                BackColor = System.Drawing.Color.Blue;
            }

            // If not, it turns white. Which it is by default since it's unchecked through the GUI
            else
            {
                BackColor = System.Drawing.Color.White;
            }
        }


        // Changing form to BLOOD RED
        private void UxRedButton_CheckedChanged(object sender, EventArgs e)
        {

            // When RED is checked
            if (UxRedButton.Checked)
            {

                // The drawing of the system (form) turns red
                BackColor = System.Drawing.Color.DarkRed;
            }
        }


        // Changing form to VIOLET BLUE
        private void UxVioletBlueButton_CheckedChanged(object sender, EventArgs e)
        {

            // When VIOLET BLUE is checked
            if (UxVioletBlueButton.Checked)
            {

                // The drawing of the system (form) turns violet blue
                BackColor = System.Drawing.Color.BlueViolet;
            }
        }


        // Changing form to PINK
        private void UxPinkButton_CheckedChanged(object sender, EventArgs e)
        {

            // When PINK is checked
            if (UxPinkButton.Checked)
            {

                // The drawing of the system (form) turns pink
                BackColor = System.Drawing.Color.Pink;
            }
        }


        // Changing form to FOREST GREEN
        private void UxGreenButton_CheckedChanged(object sender, EventArgs e)
        {

            // When FOREST GREEN is checked
            if (UxGreenButton.Checked)
            {

                // The drawing of the system (form) turns forest green
                BackColor = System.Drawing.Color.ForestGreen;
            }
        }

       
    }
}
