using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SolutionBD.Domain.Entity
{
    [Table(name: "Admin", Schema = "tsb")]
    public class AdminModel
    {
        public int Id { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Address { set; get; }
        public byte RoleCD { set; get; }

        public string UserID { set; get; }
        public string Email { set; get; }
        public string Mobile { set; get; }

        public string AlternativeMobile { set; get; }

        public string Password { set; get; }
        public int CreatedBy { set; get; }
        public int UpdatedBy { set; get; }
        public DateTime CreatedDate { set; get; } = DateTime.Now;
        public DateTime UpdatedDate { set; get; }

    }
}
