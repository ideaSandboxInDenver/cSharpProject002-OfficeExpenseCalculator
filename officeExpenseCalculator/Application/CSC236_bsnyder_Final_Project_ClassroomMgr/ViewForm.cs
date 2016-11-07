using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CSC236_bsnyder_Final_Project_ClassroomMgr
{
    public partial class ViewForm : Form
    {
        public ViewForm()
        {
            InitializeComponent();
        }

        private void getClassroomButton_Click(object sender, EventArgs e)
        {
            try
            {
                // local variables
                const int SIZE = 10;            // number of values
                string[] roomData = new string[SIZE];   // array of values
                int index = 0;                  // loop counter
                //double averageCost;             // hold the average cost per item.
                //double totalCost;               // hold the total room cost
                StreamReader inputFile;         // for file input

                // open a file and get a streamreader object
                inputFile = File.OpenText("OfficeDefault.txt");

                // clear listbox
                OfficeDataListBox.Items.Clear();

                //////////////////////////////////////////
                // The code below reads data from a file//
                //////////////////////////////////////////

                // read the values into the array
                while (!inputFile.EndOfStream && index < roomData.Length)
                {
                    roomData[index] = (inputFile.ReadLine());
                    index++;
                }

                // close the file
                inputFile.Close();

                // display the values.
                foreach (string value in roomData)
                {
                    OfficeDataListBox.Items.Add(value);
                }
            }
            catch (Exception ex)
            {
                // display an error msg
                MessageBox.Show(ex.Message);
            }
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    // local variables
                    const int SIZE = 10;                    // number of values
                    string[] roomData = new string[SIZE];   // array of values
                    int index = 0;                          // loop counter
                    //double averageCost;                   // hold the average cost per item.
                    //double totalCost;                     // hold the total room cost
                    StreamReader inputFile;                 // for file input

                    //////////////////////////////////////////
                    // The code below reads data from a file//
                    //////////////////////////////////////////

                    // open a file and get a streamreader object
                    inputFile = File.OpenText("PreviousOffice.txt");

                    // clear listbox
                    OfficeDataListBox.Items.Clear();

                    // read the values into the array
                    while (!inputFile.EndOfStream && index < roomData.Length)
                    {
                        roomData[index] = (inputFile.ReadLine());
                        index++;
                    }

                    // close the file
                    inputFile.Close();

                    // display the values.
                    foreach (string value in roomData)
                    {
                        OfficeDataListBox.Items.Add(value);
                    }
                }
                catch (Exception ex)
                {
                    // display an error msg
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {

            /////////////////////////////////
            //The code below uses and array//
            /////////////////////////////////

            string[] best_classroom_ever = { "Marketing", "Headquarters West", "Room: 999", "Premium Desk", "4 Desks",
                "Premium Chairs", "10 Chairs", "Premium Computers", "10 Computers", "Premium Executive Station" };
            int count;

            for (count = 0; count < best_classroom_ever.Length; count++)
            {
                OfficeDataListBox.Items.Add(best_classroom_ever[count]);
            }

            // clear the ListBox's current contents.
            OfficeDataListBox.Items.Clear();

            ///////////////////////////////
            //The code below uses a loop.//
            ///////////////////////////////

            // display the classroom info in the ListBox
            foreach (string value in best_classroom_ever)
            {
                OfficeDataListBox.Items.Add(value);
            }
        }

        private void addClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // close View Form
            this.Close();
            
            // create an instance of the AddForm (RoomData Lookup) Form.
            AddForm details = new AddForm();

            // display the form.
            details.ShowDialog();

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // close the form
            this.Close();
        }

        private void creditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // credit for writing the program
            string s = "Application developed by Joel Snyder.\n\nSnyderLogic\n200 E. Main Street\nDenver, CO 80207";
            MessageBox.Show(s, "Application Credit");
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            // close the form
            this.Close();
        }
    }
}
