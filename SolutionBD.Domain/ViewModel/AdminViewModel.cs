using System;
using System.Collections.Generic;
using System.Text;

namespace SolutionBD.Domain.ViewModel
{
    public class AdminViewModel
    {
        public int Id { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Address { set; get; }
        public string UserID { set; get; }
        public string Email { set; get; }
        public string Mobile { set; get; }

        public string AlternativeMobile { set; get; }

        public string CreatedBy { set; get; }
        public string UpdatedBy { set; get; }
        public DateTime CreatedDate { set; get; }
        public DateTime UpdatedDate { set; get; }
    }
}
