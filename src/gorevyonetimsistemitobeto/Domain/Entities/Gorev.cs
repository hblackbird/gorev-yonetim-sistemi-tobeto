using Domain.Enums;
using NArchitecture.Core.Persistence.Repositories;

namespace Domain.Entities
{
    public class Gorev : Entity<Guid>
    {
        public string Title { get; set; }
        public GorevDurumu Status { get; set; }
        public string Description { get; set; }
        public Guid UserId { get; set; }
        public virtual User? User { get; set; } = null;

        public Gorev()
        {
        }

        public Gorev(string title, string description)
        {
            Title = title;
            Description = description;
        }
    }
    
}
