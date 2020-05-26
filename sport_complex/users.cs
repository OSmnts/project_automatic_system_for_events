using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sport_complex
{
    public class userClass
    {
        public string login_name { get; set; }
        public string password { get; set; }
        public int telephone { get; set; }
        public int age { get; set; }
        public int special_user { get; set; }
        public string username { get; set; }

        public int id
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public eventClass eventClass
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
    }
}