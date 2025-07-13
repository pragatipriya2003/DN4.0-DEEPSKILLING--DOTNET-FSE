using System;
using System.Collections.Generic;
using WebApiLab3.Models;

namespace WebApiLab3.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Salary { get; set; }
        public bool Permanent { get; set; }
        public Department? Department { get; set; }
        public List<Skill> Skills { get; set; } = new List<Skill>();
        public DateTime DateOfBirth { get; set; }
    }
}
