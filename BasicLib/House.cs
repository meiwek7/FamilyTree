using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicLib
{
    public class House
    {
        private int id;
        private string name;
        private int houseKeeper;
        private string history;
        private string coatOfArms;
        private List<User> houseMembers;
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int HouseKeeper
        {
            get
            {
                return houseKeeper;
            }

            set
            {
                houseKeeper = value;
            }
        }

        public string History
        {
            get
            {
                return history;
            }

            set
            {
                history = value;
            }
        }

        public string CoatOfArms
        {
            get
            {
                return coatOfArms;
            }

            set
            {
                coatOfArms = value;
            }
        }
        public List<User> HouseMembers
        {
            get
            {
                return houseMembers;
            }
            set
            {
                houseMembers = value;
            }           
        }
    }
}