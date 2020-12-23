using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_HotChocolate_Project.Models
{
    public class Child
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TestField { get; set; }
        public int ParentId { get; set; }
        public Parent Parent { get; set; }
    }
}
