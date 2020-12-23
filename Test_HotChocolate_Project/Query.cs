using HotChocolate;
using HotChocolate.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_HotChocolate_Project.Models;
using Test_HotChocolate_Project.Services;

namespace Test_HotChocolate_Project
{
    public class Query
    {

        [UseFiltering]
        [UseSorting]
        public async Task<IEnumerable<Child>> GetChilds([Service] ChildService childService)
        {
            List<Child> childs = new List<Child>();

            await Task.Run(() =>
            {
                childs = childService.GetAllChilds().ToList();                
            }
            );

            return childs;
        }

    }
}
