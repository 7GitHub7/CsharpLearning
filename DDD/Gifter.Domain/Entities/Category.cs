using Gifter.Domain.DDD;
using Gifter.Domain.ValueObject.Ids;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gifter.Domain.Entities
{
    
    public class Category : Entity<CategoryId, CategoryUniqueId>
    {
        public string Name { get; init; }

        public string DisplayName { get; init; }

        public string WhatWeAreLookingFor { get; init; }

        public Category(CategoryId Id, string name, string displayName,
            string whatWeAreLookingFor) : base()
        {
            this.Id = Id;
            Name = name;
            DisplayName = displayName;
            UniqueId = CategoryUniqueId.NewUniqueId();
            WhatWeAreLookingFor = whatWeAreLookingFor;
        }

        public void InjectUniqueId(CategoryUniqueId uniqueId)
        {
            this.UniqueId = uniqueId;
        }

        public Category(CategoryId Id)
        {
            this.Id = Id;
            UniqueId = CategoryUniqueId.NewUniqueId();

        }

        public Category()
        {
            UniqueId = CategoryUniqueId.NewUniqueId();
            this.Id = CategoryId.Empty();
        }

        public CategoryIds Ids()
        {
            if (this.Id != null && this.Id.Value != default)
                return new CategoryIds()
                {
                    UniqueId = this.UniqueId,
                    CreatedId = this.Id
                };
            else
                return new CategoryIds()
                {
                    UniqueId = this.UniqueId,
                    CreatedId = this.Id,
                    Status = IdsStatus.DudeYouCantReturnCreatedIdWhenYouAreEventSourcing

                };
        }
    }
}


