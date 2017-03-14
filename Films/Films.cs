using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Films
{
    public class Films
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        private int _rating;

        public int Rating
        {
            get { return _rating; }
            set { _rating = value; }
        }
        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }


        public Films(string name, int rating, string description) 
        {
            _name = name;
            _rating = rating;
            _description = description;
        }
    }


}
