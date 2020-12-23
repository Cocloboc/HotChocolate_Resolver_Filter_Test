using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_HotChocolate_Project.Models;

namespace Test_HotChocolate_Project.Services
{
    public class ParentService
    {
        private List<Parent> _parents = new List<Parent>() 
        { 
            new Parent() { Id = 1, Name = "TestParent1" },
            new Parent() { Id = 2, Name = "TestParent2" },
            new Parent() { Id = 3, Name = "TestParent3" },
            new Parent() { Id = 4, Name = "TestParent4" },
            new Parent() { Id = 5, Name = "TestParent5" },
            new Parent() { Id = 6, Name = "TestParent6" },
        };

        public IEnumerable<Parent> GetParentsByIds(IEnumerable<int> parentIds)
        {
            return _parents.Where(x => parentIds.Contains(x.Id));
        }
    }
}
