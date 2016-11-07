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

    //////////////////////////////////////////////////////////////
    // The code below creates a class demonstrating inheritance //
    //////////////////////////////////////////////////////////////

    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        /////////////////////////////////////////////////////
        //The code below declaring variables and constants.//
        /////////////////////////////////////////////////////

        const int INSTRUCTOR_BASIC = 1250;
        const int INSTRUCTOR_STANDARD = 1450;
        const int INSTRUCTOR_PREMIUM = 2500;

        private void addNewRoomButton_Click(object sender, EventArgs e)
        {

            //////////////////////////////////////
            // The code below creates an object //
            //////////////////////////////////////
            
            // create a RoomData object.
            RoomData myNewClassroom = new RoomData();

            // get the classroom data.
            GetClassroomData(myNewClassroom);

            // average of items minus instructor
            double avgd;
            avgd = AvgMinusInstructor(myNewClassroom);

            //determine the more expensive item
            MoreExpensiveOfTwo(myNewClassroom);

            //determine the total room cost
            TotalCostOfFour(myNewClassroom);

            // record data to text file.
            RecordData(myNewClassroom);


            ///////////////////////////////////////////////
            //The code below clears all info on the form.//
            ///////////////////////////////////////////////

            // clear the room name.
            RoomNameTextBox.Clear();

            // clear the building location.
            BldgLocationTextBox.Clear();

            // clear the room number.
            roomNumberTextBox.Clear();

            // clear the desk type.
            deskTypeComboBox.SelectedIndex = -1;

            // clear the number of desks.
            NumOfDesksTextBox.Clear();

            // clear the chair type.
            chairTypeComboBox.SelectedIndex = -1;

            // clear the number of chairs.
            numOfChairsTextBox.Clear();

            // clear the computer type.
            computerTypeComboBox.SelectedIndex = -1;

            // clear the number of computers.
            numOfComputersTextBox.Clear();

            // clear the instructor station type.
            InstructorStationComboBox.SelectedIndex = -1;

            // clear the average cost.
            classroomAvgTextBox.Clear();

            // clear the total cost.
            totalCostRoomItemsTextBox.Clear();

            // clear the Math Class label
            dispayTheMaxLabel.Text = "";

        }

        private void saveToFileButton_Click(object sender, EventArgs e)
        {
            RoomData myNewClassroom = new RoomData();

            // get the classroom data.
            GetClassroomData(myNewClassroom);

            // save to file.
            RecordData(myNewClassroom);
        }

        private void RecordData(RoomData myNewClassroom)
        {
            //////////////////////////////////////////
            // The code below writes data to a file //
            //////////////////////////////////////////

            StreamWriter outputfile;
            outputfile = File.AppendText("OfficeDataOutput.txt");

            outputfile.WriteLine("Office Name: " + myNewClassroom.Room_Name);
            outputfile.WriteLine("Building Name: " + myNewClassroom.Building_Location);
            outputfile.WriteLine("Office Number: " + myNewClassroom.Room_Num);
            outputfile.WriteLine("Desk Cost Per Unit: $" + myNewClassroom.Desk_Type);
            outputfile.WriteLine("Desk Quantity: " + myNewClassroom.Num_Of_Desks);
            outputfile.WriteLine("Chair Cost Per Unit: $" + myNewClassroom.Chair_Type);
            outputfile.WriteLine("Chair Quantity: " + myNewClassroom.Num_Of_Chairs);
            outputfile.WriteLine("Computer Cost Per Unit: $" + myNewClassroom.Computer_Type);
            outputfile.WriteLine("Computer Quantity: " + myNewClassroom.Num_of_Comp);
            outputfile.WriteLine("Executive Station Cost: $" + myNewClassroom.Inst_Station_Type);
            outputfile.WriteLine("Average item cost without Executive: " + classroomAvgTextBox.Text);
            outputfile.WriteLine("Total room cost: " + totalCostRoomItemsTextBox.Text);

            outputfile.Close();

            // Let the user know the data was recorded
            MessageBox.Show("The data was saved.");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {

            ///////////////////////////////////////////////
            //The code below clears all info on the form.//
            ///////////////////////////////////////////////

            // clear the room name.
            RoomNameTextBox.Clear();

            // clear the building location.
            BldgLocationTextBox.Clear();

            // clear the room number.
            roomNumberTextBox.Clear();

            // clear the desk type.
            deskTypeComboBox.SelectedIndex = -1;

            // clear the number of desks.
            NumOfDesksTextBox.Clear();

            // clear the chair type.
            chairTypeComboBox.SelectedIndex = -1;

            // clear the number of chairs.
            numOfChairsTextBox.Clear();

            // clear the computer type.
            computerTypeComboBox.SelectedIndex = -1;

            // clear the number of computers.
            numOfComputersTextBox.Clear();

            // clear the instructor station type.
            InstructorStationComboBox.SelectedIndex = -1;

            // clear the average item cost.
            classroomAvgTextBox.Clear();

            // clear the room cost from form.
            totalCostRoomItemsTextBox.Clear();

            dispayTheMaxLabel.Text = "";
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            // close form
            this.Close();
        }

        // The GetClassroomData method accepts a myNewClassroom object
        // as an argument. It assigns the data entered by the user
        // to the object's properties.
        private void GetClassroomData(RoomData myNewClassroom)
        {
            int desk_type = 0; // desk type
            int chair_type = 0;  // chair type
            int computer_type = 0;  // computer type
            int inst_station_type = 0; // instructor station type

            // Get the room name.
            myNewClassroom.Room_Name = RoomNameTextBox.Text;

            // Get the building location.
            myNewClassroom.Building_Location = BldgLocationTextBox.Text;

            ////////////////////////////////////////////
            //The code below uses exception handling. //
            ////////////////////////////////////////////

            // Get the room number.
            try
            {
                myNewClassroom.Room_Num = int.Parse(roomNumberTextBox.Text);
            }
            catch
            {
                // display error msg
                MessageBox.Show("Invalid room number entered.");
            }

            //////////////////////////////////////
            //The code below uses If statements.//
            //////////////////////////////////////

            // Get the desk type.
            if (deskTypeComboBox.SelectedIndex != -1)
            {
                // get selected item.
                desk_type = deskTypeComboBox.SelectedIndex;

                // determine desk price.
                switch (desk_type)
                {
                    case 0:
                        desk_type = 325;
                        break;
                    case 1:
                        desk_type = 425;
                        break;
                    case 2:
                        desk_type = 525;
                        break;
                }

                myNewClassroom.Desk_Type = desk_type;

                // Get the chair type.
                if (chairTypeComboBox.SelectedIndex != -1)
                {
                    // get selected item.
                    chair_type = chairTypeComboBox.SelectedIndex;

                    // determine chair price.
                    switch (chair_type)
                    {
                        case 0:
                            chair_type = 125;
                            break;
                        case 1:
                            chair_type = 225;
                            break;
                        case 2:
                            chair_type = 325;
                            break;
                    }

                    myNewClassroom.Chair_Type = chair_type;

                    // Get the computer type.
                    if (computerTypeComboBox.SelectedIndex != -1)
                    {
                        // get selected item.
                        computer_type = computerTypeComboBox.SelectedIndex;

                        // determine computer price.
                        switch (computer_type)
                        {
                            case 0:
                                computer_type = 500;
                                break;
                            case 1:
                                computer_type = 600;
                                break;
                            case 2:
                                computer_type = 700;
                                break;
                        }

                        myNewClassroom.Computer_Type = computer_type;

                        // Get the instructor station type.
                        if (InstructorStationComboBox.SelectedIndex != -1)
                        {
                            // get selected item.
                            inst_station_type = InstructorStationComboBox.SelectedIndex;

                            // determine computer price.
                            switch (inst_station_type)
                            {
                                case 0:
                                    inst_station_type = INSTRUCTOR_BASIC;
                                    break;
                                case 1:
                                    inst_station_type = INSTRUCTOR_STANDARD;
                                    break;
                                case 2:
                                    inst_station_type = INSTRUCTOR_PREMIUM;
                                    break;
                            }

                            myNewClassroom.Inst_Station_Type = inst_station_type;
                        }
                        else
                        {
                            // No computer was selected
                            MessageBox.Show("Select a computer.");
                        }
                    }
                    else
                    {
                        // No computer was selected
                        MessageBox.Show("Select a computer.");
                    }
                }
                else
                {
                    // No chair was selected
                    MessageBox.Show("Select a chair.");
                }
            }
            else
            {
                // No desk was selected
                MessageBox.Show("Select a desk.");
            }

            // Get the number of desks.
            try
            {
                myNewClassroom.Num_Of_Desks = int.Parse(NumOfDesksTextBox.Text);
            }
            catch
            {
                // display error msg
                MessageBox.Show("Invalid desk quantity entered.");
            }

            // Get the number of chairs.
            try
            {
                myNewClassroom.Num_Of_Chairs = int.Parse(numOfChairsTextBox.Text);
            }
            catch
            {
                // display error msg
                MessageBox.Show("Invalid chair quantity entered.");
            }

            // Get the number of computers.
            try
            {
            myNewClassroom.Num_of_Comp = int.Parse(numOfComputersTextBox.Text);
            }
            catch
            {
                // display error msg
                MessageBox.Show("Invalid computer quantity entered.");
            }
}

        private void deskTypeComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {    
        }

        private void chairTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void computerTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void InstructorStationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private int TotalCostOfFour(RoomData myNewClassroom)
        {
            int desk_type = myNewClassroom.Desk_Type;
            int num_of_desks = myNewClassroom.Num_Of_Desks;
            int chair_type = myNewClassroom.Chair_Type;
            int num_of_chairs = myNewClassroom.Num_Of_Chairs;
            int computer_type = myNewClassroom.Computer_Type;
            int num_of_computers = myNewClassroom.Num_of_Comp;
            int inst_station_type = myNewClassroom.Inst_Station_Type;

            int num1 = desk_type * num_of_desks;
            int num2 = chair_type * num_of_chairs;
            int num3 = computer_type * num_of_computers;
            int num4 = inst_station_type;

            int sum = num1 + num2 + num3 + num4;

            totalCostRoomItemsTextBox.Text = sum.ToString("c");

            return sum;
        }


        ///////////////////////////////////////
        // The code below is a custom method //
        ///////////////////////////////////////
        private double AvgMinusInstructor(RoomData myNewClassroom)
        {

            int desk_type = myNewClassroom.Desk_Type;
            int num_of_desks = myNewClassroom.Num_Of_Desks;
            int chair_type = myNewClassroom.Chair_Type;
            int num_of_chairs = myNewClassroom.Num_Of_Chairs;
            int computer_type = myNewClassroom.Computer_Type;
            int num_of_computers = myNewClassroom.Num_of_Comp;

            int num1 = desk_type * num_of_desks;
            int num2 = chair_type * num_of_chairs;
            int num3 = computer_type * num_of_computers;
            int num4 = num_of_desks + num_of_chairs + num_of_computers;

            int avg = (num1 + num2 + num3) / num4;

            classroomAvgTextBox.Text = avg.ToString("c");

            return avg;

        }

        private void MoreExpensiveOfTwo(RoomData myNewClassroom)
        {
            ///////////////////////////////////////
            //The code below uses the Math Class.//
            ///////////////////////////////////////

            int deskInt = myNewClassroom.Desk_Type;
            int computerInt = myNewClassroom.Computer_Type;
            string deskString = "desk";
            string computerString = "computer";

            int result;
            result = Math.Max(deskInt, computerInt);

            if (deskInt > computerInt)
            {
                dispayTheMaxLabel.Text = "Comparing the " + deskInt.ToString("c") + " desk and the " + computerInt.ToString("c") + " computer, the higher priced item is the " + deskInt.ToString("c") + " " + deskString + ".";
            }
            else
            {
                dispayTheMaxLabel.Text = "Comparing the " + deskInt.ToString("c") + " desk and the " + computerInt.ToString("c") + " computer, the higher priced item is the " + computerInt.ToString("c") + " " + computerString + ".";
            }

        }

        private void viewFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create an instance of the AddForm (RoomData Lookup) Form.
            ViewForm details = new ViewForm();

            // display the form.
            details.ShowDialog();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // close the form.
            this.Close();
        }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // credit for writing the program
            string s = "Application developed by Joel Snyder.\n\nSnyderLogic\n200 E. Main Street\nDenver, CO 80207";
            MessageBox.Show(s, "Application Credit");
        }

        private void closeFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //close form
            this.Close();
        }

        private void calculateButton_Click_1(object sender, EventArgs e)
        {
            // create a RoomData object.
            RoomData myNewClassroomCost = new RoomData();

            // get the classroom data.
            GetClassroomData(myNewClassroomCost);

            // average of items minus instructor
            AvgMinusInstructor(myNewClassroomCost);

            // total cost of room
            TotalCostOfFour(myNewClassroomCost);

            //determine the more expensive item
            MoreExpensiveOfTwo(myNewClassroomCost);
        }

        private void masterLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }
    }
}
