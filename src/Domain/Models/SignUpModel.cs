using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Domain.Models
{
    public class SignUpModel
    {
        private Guid _id;

        public Guid Id {
            get { return _id; }
            set { _id = value; }
        }

        private string _username;

        public string UserName {
            get { return _username; }
            set { _username = value; }
        }

        private string _email;

        public string Email {
            get { return _email; }
            set { _email = value; }
        }

        private DateTime _createAt;

        public DateTime CreateAt {
            get { return _createAt; }
            set { _createAt = value == null ? DateTime.Parse(DateTime.UtcNow.ToString(CultureInfo.CreateSpecificCulture("pt-BR"))) : value; }
        }


    }
}
