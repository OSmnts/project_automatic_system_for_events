using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq.Mapping;

namespace ClassLibrary
{
    [Table(Name = "db_log")]
    public class usersCl
    {
        [Column(IsPrimaryKey =true, IsDbGenerated = true)]
        public int id
        {
            get;


            set;
        
        }
        [Column(Name = "login_name")]
        public string login_name
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
        [Column(Name = "password")]
        public string password
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
        [Column(Name = "telephone")]
        public int telephone
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
        [Column(Name = "age")]
        public int age
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
        [Column(Name = "sp_user")]
        public bool sp_user
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
        [Column(Name = "username")]
        public string username
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public eventCl eventCl
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