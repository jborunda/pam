﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PAM.Models
{
    [Table("Employees")]
    public class Employee
    {
        public int EmployeeId { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string EmployeeNumber { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        public bool IsAdmin { get; set; } = false;
        public bool IsApprover { get; set; } = false;
        public bool IsProcessor { get; set; } = false;
    }

    public class Requester
    {
        public int RequesterId { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string EmployeeNumber { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        public int? BureauId { get; set; }
        public int? UnitId { get; set; }

        public string MiddleName { get; set; }

        public string PayrollTitle { get; set; }
        public string Department { get; set; }
        public string DepartmentCode { get; set; }

        public string WorkAddress { get; set; }
        public string WorkCity { get; set; }
        public string WorkState { get; set; }
        public string WorkZip { get; set; }
        public string WorkPhone { get; set; }
        public string CellPhone { get; set; }

        // navigation properties
        public Bureau Bureau { get; set; }
        public Unit Unit { get; set; }
    }
}