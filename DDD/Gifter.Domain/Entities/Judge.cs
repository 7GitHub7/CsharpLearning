using Gifter.Domain.DDD;
using Gifter.Domain.ValueObject;
using Gifter.Domain.ValueObject.Ids;
using Gifter.Domain.ValueObject.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gifter.Domain.Entities
{
    public class Judge : Entity<JudgeId, JudgeUniqueId>
    {
        public Login Login { get; init; }
        public Password Password { get; init; }
        public Name Name { get; init; }

        public Category Category { get; init; }

        //Stworzenie listy właściwości był debilnym pomysłem
        //public List<Email> Emails { get; set; }
        public DateTime Birthdate { get; set; }

        public Judge(Login login, Password password, Name name, Category category)
        {
            Id = new JudgeId(0);
            Login = login;
            Password = password;
            Name = name;
            Category = category;
            UniqueId = JudgeUniqueId.NewUniqueId();
            Version = 0;
        }

        public Judge(int id, Login login, Password password, Name name, Category category)
        {
            Id = new JudgeId(id);
            Login = login;
            Password = password;
            Name = name;
            Category = category;
            UniqueId = JudgeUniqueId.NewUniqueId();
            Version = 0;
        }

        //To satisfy EF Core
        public Judge()
        {
            UniqueId = JudgeUniqueId.NewUniqueId();
            Version = 0;
        }

        public bool CanAccept(CategoryId categoryId)
        {
            if (Category != null)
                return categoryId == Category.Id;
            return false;
        }

        public AgeInYears AgeInYearsAt(DateTime date)
        {
            return AgeInYears.Between(Birthdate, date);
        }

        public JudgeIds Ids()
        {
            if (this.Id != null && this.Id.Value != default)
                return new JudgeIds()
                {
                    UniqueId = this.UniqueId,
                    CreatedId = this.Id
                };
            else
                return new JudgeIds()
                {
                    UniqueId = this.UniqueId,
                    CreatedId = this.Id,
                    Status = IdsStatus.DudeYouCantReturnCreatedIdWhenYouAreEventSourcing

                };
        }

    }
}
