using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC236_bsnyder_Final_Project_ClassroomMgr
{
    class RoomData
    {

        ////////////////////////////////////////////////
        //The code below declares variables as fields.//
        ////////////////////////////////////////////////

        // Fields
        private string _room_name; // room name
        private string _building_location; // building location
        private int _room_num;  // room number
        private int _desk_type; // desk type
        private int _num_of_desks;  // number of desks
        private int _chair_type;  // chair type
        private int _num_of_chairs;  // number of chairs
        private int _computer_type;  // computer type
        private int _num_of_comp;  // number of computers
        private int _inst_station_type;  // instructor station type

        // Constructor
        public RoomData()
        {
            _room_name = ""; // room name
            _building_location = ""; // building location
            _room_num = 0;  // room number
            _desk_type = 0; // desk type
            _num_of_desks = 0;  // number of desks
            _chair_type = 0;  // chair type
            _num_of_chairs = 0;  // number of chairs
            _computer_type = 0;  // computer type
            _num_of_comp = 0;  // number of computers
            _inst_station_type = 0; // instructor station type
        }

        // Room Name property
        public string Room_Name
        {
            get { return _room_name; }
            set { _room_name = value; }
        }

        // Building Location property
        public string Building_Location
        {
            get { return _building_location; }
            set { _building_location = value; }
        }

        // Room Num property
        public int Room_Num
        {
            get { return _room_num; }
            set { _room_num = value; }
        }

        // Desk Type property
        public int Desk_Type
        {
            get { return _desk_type; }
            set { _desk_type = value; }
        }

        // Num of Desks property
        public int Num_Of_Desks
        {
            get { return _num_of_desks; }
            set { _num_of_desks = value; }
        }

        // Chair Type property
        public int Chair_Type
        {
            get { return _chair_type; }
            set { _chair_type = value; }
        }

        // Num of Chairs property
        public int Num_Of_Chairs
        {
            get { return _num_of_chairs; }
            set { _num_of_chairs = value; }
        }

        // Computer Type property
        public int Computer_Type
        {
            get { return _computer_type; }
            set { _computer_type = value; }
        }

        // Num of Computers property
        public int Num_of_Comp
        {
            get { return _num_of_comp; }
            set { _num_of_comp = value; }
        }

        // Instructor Station Type property
        public int Inst_Station_Type
        {
            get { return _inst_station_type; }
            set { _inst_station_type = value; }
        }
    }
}

