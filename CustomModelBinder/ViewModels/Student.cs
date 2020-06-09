using CustomModelBinder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomModelBinder.ViewModels
{
    public class StudentViewModel
    {
        public StudentId Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}
