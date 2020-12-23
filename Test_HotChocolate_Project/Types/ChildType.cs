using HotChocolate.Types;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Test_HotChocolate_Project.DataLoaders;
using Test_HotChocolate_Project.Models;

namespace Test_HotChocolate_Project.Types
{
    public class ChildType : ObjectType<Child>
    {
        protected override void Configure(IObjectTypeDescriptor<Child> descriptor)
        {
            descriptor
                .Field(x => x.TestField)
                .Resolve(y => "test");
            descriptor
                .Field(x => x.Parent)
                .ResolveWith<ChildResolver>(t => t.GetParentAsync(default!, default!, default!));
        }

        private class ChildResolver
        {
            public async Task<Parent> GetParentAsync(
                Child child,
                ParentDataLoader dataLoader,
                CancellationToken cancellationToken)
            {
                var data = await dataLoader.LoadAsync(new int[] { child.ParentId }, cancellationToken);
                return data.FirstOrDefault();
            }
        }
    }
}