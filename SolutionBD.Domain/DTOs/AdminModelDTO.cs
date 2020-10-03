using System;
using System.Collections.Generic;
using System.Text;

namespace SolutionBD.Domain.DTOs
{
    public class AdminModelCreate
    {

        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Address { set; get; }
        public byte RoleCD { set; get; }

        public string UserID { set; get; }
        public string Email { set; get; }
        public string Mobile { set; get; }

        public string AlternativeMobile { set; get; }

        public string Password { set; get; }
        public string ConfirmPassword { set; get; }


    }
    public class AdminModelUpdate
    {
        public int Id { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Address { set; get; }

        public string Email { set; get; }
        public string Mobile { set; get; }

        public string AlternativeMobile { set; get; }
    }
}
