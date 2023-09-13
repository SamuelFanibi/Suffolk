using Suffolk.Common.Models;

namespace Suffolk.Core.Models
{
    public class Person: BaseDeletable<Guid>
    {
        public Person()
        {
            this.Id = Guid.NewGuid();
            this.CreatedOn = DateTime.Now;
            this.IsDeleted = false;
            this.ModifiedOn = DateTime.Now;

        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly DateOfBirth { get; set; }

    }
}
