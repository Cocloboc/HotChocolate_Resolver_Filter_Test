using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_HotChocolate_Project.Models;

namespace Test_HotChocolate_Project.Services
{
    public class ChildService
    {
        private List<Child> _childrens = new List<Child>()
        {
            new Child() { Id = 1, Name = "TestChild1", ParentId = 1 },
            new Child() { Id = 2, Name = "TestChild2", ParentId = 2 },
            new Child() { Id = 3, Name = "TestChild3", ParentId = 3 },
            new Child() { Id = 4, Name = "TestChild4", ParentId = 4 },
            new Child() { Id = 5, Name = "TestChild5", ParentId = 5 },
            new Child() { Id = 6, Name = "TestChild6", ParentId = 6 },
        };

        public IEnumerable<Child> GetAllChilds()
        {
            return _childrens;
        }
    }
}
