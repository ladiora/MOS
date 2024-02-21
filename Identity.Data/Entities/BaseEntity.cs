

namespace Identity.Data.Entities
{
    public class BaseEntity
    {
        public long Id { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public long CreatorId { get; set; }

    }
}
