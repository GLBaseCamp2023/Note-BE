using System.ComponentModel.DataAnnotations;

namespace Evernote.Domain {
    public interface IDbEntity {
        [Key]
        public Guid Id { get; set; }

    }
}
