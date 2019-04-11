// Grading ID: B9073
// Program Number: 2
// Due Date: October 16, 2016 11:59 PM
// Course and Course Section: 199-75
// Brief Description: Creates a tool that allows users to enter credit hours and the first letter of
// their last name and proceeds to tell them the earliest registration date possible for Spring 2017 courses
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program2
{
    public partial class program2Form : Form
    {
        public program2Form()
        {
            InitializeComponent();
        }

        // Creates a click event for the checkRegistrationButton

        private void checkRegistrationButton_Click(object sender, EventArgs e)
        {
            // Establishes constant values
       
            const double SENIORS = 90; // Value of 90 is stored inside constant double SENIORS
            const double JUNIORS = 60; // Value of 60 is stored inside constant double JUNIORS
            const double SOPHOMORES = 30; // Value of 30 is stored inside constant double SOPHOMORES
          
            // Establishes variables

            double creditHours; // Assigns value double to variable creditHours
            char lastName; // Assigns value char to variable lastName

            if (double.TryParse(creditHoursTextBox.Text, out creditHours)) // TryParse used to collect data from creditHoursTextBox and store in creditHours
            {
               creditHours = Math.Abs(creditHours); // Makes certain that if any negative number is entered into creditHoursTextBox that the absolute value is taken so that it is represented as a positive value throughout the rest of code

                if (char.TryParse(lastNameTextBox.Text, out lastName)) // Tryparse used to collect first letter of last name from lastNameTextBox and store in lastName
                {
                    if (char.IsLetter(lastName))
                    {
                        //Seniors

                        lastName = char.ToUpper(lastName); // Makes certain that any letter entered into lastNameTextBox is capitalized and stored in lastName

                        if (creditHours >= SENIORS && lastName >= 'T') // Creates if that tests to see what earliest registration date is based on credit hours and first letter of last name
                        {
                            MessageBox.Show("Registration Date: Friday, November 4 at 11:30 A.M."); // Displays given date if credits are >= 90 and first letter of last name is "T" or later
                        }
                        else if (creditHours >= SENIORS && lastName >= 'P') // If previous test fails, proceeds to this test and test for >= 'P'
                        {
                            MessageBox.Show("Registration Date: Friday, November 4 at 10:00 A.M."); // Displays given date if credits are >= 90 and first letter of last name is "P" or later
                        }
                        else if (creditHours >= SENIORS && lastName >= 'J') // If previous test fails, proceeds to this test and test for >= 'J'
                        {
                            MessageBox.Show("Registration Date: Friday, November 4 at 8:30 A.M."); // Displays given date if credits are >= 90 and first letter of last name is "J" or later
                        }
                        else if (creditHours >= SENIORS && lastName >= 'E') // If previous test fails, proceeds to this test and test for >= 'E'
                        {
                            MessageBox.Show("Registration Date: Friday, November 4 at 4:00 P.M."); // Displays given date if credits are >= 90 and first letter of last name is "E" or later
                        }
                        else if (creditHours >= SENIORS && lastName >= 'A') // If previous test fails, proceeds to this test and test for >= 'A'
                        {
                            MessageBox.Show("Registration Date: Friday, November 4 at 2:00 P.M."); // Displays given date if credits are >= 90 and first letter of last name is "A" or later
                        }


                        // Juniors

                        else if (creditHours >= JUNIORS && lastName >= 'T') // If previous test fails, proceeds to this test and test for >= 'T'
                        {
                            MessageBox.Show("Registration Date: Monday, November 7 at 11:30 A.M."); // Displays given date if credits are >= 60 and first letter of last name is "T" or later
                        }
                        else if (creditHours >= JUNIORS && lastName >= 'P') // If previous test fails, proceeds to this test and test for >= 'P'
                        {
                            MessageBox.Show("Registration Date: Monday, November 7 at 10:00 A.M."); // Displays given date if credits are >= 60 and first letter of last name is "P" or later
                        }
                        else if (creditHours >= JUNIORS && lastName >= 'J') // If previous test fails, proceeds to this test and test for >= 'J'
                        {
                            MessageBox.Show("Registration Date: Monday, November 7 at 8:30 A.M."); // Displays given date if credits are >= 60 and first letter of last name is "J" or later
                        }
                        else if (creditHours >= JUNIORS && lastName >= 'E') // If previous test fails, proceeds to this test and test for >= 'E'
                        {
                            MessageBox.Show("Registration Date: Monday, November 7 at 4:00 P.M."); // Displays given date if credits are >= 60 and first letter of last name is "E" or later
                        }
                        else if (creditHours >= JUNIORS && lastName >= 'A') // If previous test fails, proceeds to this test and test for >= 'A'
                        {
                            MessageBox.Show("Registration Date: Monday, November 7 at 2:00 P.M."); // Displays given date if credits are >= 60 and first letter of last name is "A" or later
                        }


                        //Sophomores

                        else if (creditHours >= SOPHOMORES && lastName >= 'W') // If previous test fails, proceeds to this test and test for >= 'W'
                        {
                            MessageBox.Show("Registration Date: Thursday, November 10 at 8:30 A.M."); // Displays given date if credits are >= 30 and first letter of last name is "W" or later
                        }
                        else if (creditHours >= SOPHOMORES && lastName >= 'T') // If previous test fails, proceeds to this test and test for >= 'T'
                        {
                            MessageBox.Show("Registration Date: Wednesday, November 9 at 4:00 P.M."); // Displays given date if credits are >= 30 and first letter of last name is "T" or later
                        }
                        else if (creditHours >= SOPHOMORES && lastName >= 'R') // If previous test fails, proceeds to this test and test for >= 'R'
                        {
                            MessageBox.Show("Registration Date: Wednesday, November 9 at 2:00 P.M."); // Displays given date if credits are >= 30 and first letter of last name is "R" or later
                        }
                        else if (creditHours >= SOPHOMORES && lastName >= 'P') // If previous test fails, proceeds to this test and test for >= 'P'
                        {
                            MessageBox.Show("Registration Date: Wednesday, November 9 at 11:30 A.M."); // Displays given date if credits are >= 30 and first letter of last name is "P" or later
                        }
                        else if (creditHours >= SOPHOMORES && lastName >= 'M') // If previous test fails, proceeds to this test and test for >= 'M'
                        {
                            MessageBox.Show("Registration Date: Wednesday, November 9 at 10:00 A.M."); // Displays given date if credits are >= 30 and first letter of last name is "M" or later
                        }
                        else if (creditHours >= SOPHOMORES && lastName >= 'J') // If previous test fails, proceeds to this test and test for >= 'J'
                        {
                            MessageBox.Show("Registration Date: Wednesday, November 9 at 8:30 A.M."); // Displays given date if credits are >= 30 and first letter of last name is "J" or later
                        }
                        else if (creditHours >= SOPHOMORES && lastName >= 'G') // If previous test fails, proceeds to this test and test for >= 'G'
                        {
                            MessageBox.Show("Registration Date: Thursday, November 10 at 4:00 P.M."); // Displays given date if credits are >= 30 and first letter of last name is "G" or later
                        }
                        else if (creditHours >= SOPHOMORES && lastName >= 'E') // If previous test fails, proceeds to this test and test for >= 'E'
                        {
                            MessageBox.Show("Registration Date: Thursday, November 10 at 2:00 P.M."); // Displays given date if credits are >= 30 and first letter of last name is "E" or later
                        }
                        else if (creditHours >= SOPHOMORES && lastName >= 'C') // If previous test fails, proceeds to this test and test for >= 'C'
                        {
                            MessageBox.Show("Registration Date: Thursday, November 10 at 11:30 A.M."); // Displays given date if credits are >= 30 and first letter of last name is "C" or later
                        }
                        else if (creditHours >= SOPHOMORES && lastName >= 'A') // If previous test fails, proceeds to this test and test for >= 'A'
                        {
                            MessageBox.Show("Registration Date: Thursday, November 10 at 10:00 A.M."); // Displays given date if credits are >= 30 and first letter of last name is "A" or later
                        }

                        // Freshmen

                        else if (creditHours < SOPHOMORES && lastName >= 'W') // If previous test fails, proceeds to this test and test for >= 'W'
                        {
                            MessageBox.Show("Registration Date: Monday, November 14 at 8:30 A.M."); // Displays given date if credits are < 30 and first letter of last name is "W" or later
                        }
                        else if (creditHours < SOPHOMORES && lastName >= 'T') // If previous test fails, proceeds to this test and test for >= 'T'
                        {
                            MessageBox.Show("Registration Date: Friday, November 11 at 4:00 P.M."); // Displays given date if credits are < 30 and first letter of last name is "T" or later
                        }
                        else if (creditHours < SOPHOMORES && lastName >= 'R') // If previous test fails, proceeds to this test and test for >= 'R'
                        {
                            MessageBox.Show("Registration Date: Friday, November 11 at 2:00 P.M."); // Displays given date if credits are < 30 and first letter of last name is "R" or later
                        }
                        else if (creditHours < SOPHOMORES && lastName >= 'P') // If previous test fails, proceeds to this test and test for >= 'P'
                        {
                            MessageBox.Show("Registration Date: Friday, November 11 at 11:30 A.M."); // Displays given date if credits are < 30 and first letter of last name is "P" or later
                        }
                        else if (creditHours < SOPHOMORES && lastName >= 'M') // If previous test fails, proceeds to this test and test for >= 'M'
                        {
                            MessageBox.Show("Registration Date: Friday, November 11 at 10:00 A.M."); // Displays given date if credits are < 30 and first letter of last name is "M" or later
                        }
                        else if (creditHours < SOPHOMORES && lastName >= 'J') // If previous test fails, proceeds to this test and test for >= 'J'
                        {
                            MessageBox.Show("Registration Date: Friday, November 11 at 8:30 A.M."); // Displays given date if credits are < 30 and first letter of last name is "J" or later
                        }
                        else if (creditHours < SOPHOMORES && lastName >= 'G') // If previous test fails, proceeds to this test and test for >= 'G'
                        {
                            MessageBox.Show("Registration Date: Monday, November 14 at 4:00 P.M."); // Displays given date if credits are < 30 and first letter of last name is "G" or later
                        }
                        else if (creditHours < SOPHOMORES && lastName >= 'E') // If previous test fails, proceeds to this test and test for >= 'E'
                        {
                            MessageBox.Show("Registration Date: Monday, November 14 at 2:00 P.M."); // Displays given date if credits are < 30 and first letter of last name is "E" or later
                        }
                        else if (creditHours < SOPHOMORES && lastName >= 'C') // If previous test fails, proceeds to this test and test for >= 'C'
                        {
                            MessageBox.Show("Registration Date: Monday, November 14 at 11:30 A.M."); // Displays given date if credits are < 30 and first letter of last name is "C" or later
                        }
                        else // If all above tests fail, then the follwing message is disaplayed to the user
                        {
                            MessageBox.Show("Registration Date: Monday, November 14 at 10:00 A.M."); // Displays given date if credits are < 30 and first letter of last name is "A" or later
                        }
                    }

                    // Result if any value other than a letter in the alphabet is input in the lastNameTextBox

                    else
                    {
                        MessageBox.Show("Please enter an alphabetic letter in the first letter of last name text box"); // Displays if any value other than a letter in the alphabet is input
                    }

                    // Result if any value besides one letter value is entered into lastNameTextBox
                }
                else
                {
                    MessageBox.Show("Please enter one letter in the first letter of last name text box."); // Displays a message to the user telling them to enter one letter
                }

                // Result if any value besides a numeric value is entered into creditHoursTextBox
            }
            else
            {
                MessageBox.Show("Please enter a numeric value in the credit hours completed text box."); // Displays a message to the user telling them to enter a numeric value in the credit hours text box
            }
        }
    }
}
