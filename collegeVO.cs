using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleMVC.Core
{
    public class College
    {
        private int _idcollege;
        private string _collegename;
        private string _physicaladdress;
        private string _email;
        public College()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        public int idcollege
        {
            get
            { 
                return _idcollege;
            }

            set
            {
                _idcollege = value;
            }
        }
        public string collegename
        {
            get
            {
                return _collegename;
            }

            set
            {
                _collegename = value;
            }
        }

        public string physicaladdress
        {
            get
            {
                return _physicaladdress;
            }
            set
            {
                _physicaladdress = value;
            }
        }

        public string email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }
    }
}
