using GreenDonut;
using HotChocolate.DataLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Test_HotChocolate_Project.Models;
using Test_HotChocolate_Project.Services;

namespace Test_HotChocolate_Project.DataLoaders
{
    public class ParentDataLoader : BatchDataLoader<int, Parent>
    {
        private readonly ParentService _parentService;

        public ParentDataLoader(
            IBatchScheduler batchScheduler,
            ParentService parentService)
            : base(batchScheduler)
        {
            _parentService = parentService;
        }

        protected override async Task<IReadOnlyDictionary<int, Parent>> LoadBatchAsync(
            IReadOnlyList<int> keys,
            CancellationToken cancellationToken)
        {
            List<Parent> parents = new List<Parent>();

            await Task.Run(() => 
            {
                parents = _parentService.GetParentsByIds(keys).ToList();
            });

            return parents.ToDictionary(t => t.Id);
        }
    }

}
