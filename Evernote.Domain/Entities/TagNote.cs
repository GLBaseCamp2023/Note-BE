using System.ComponentModel.DataAnnotations.Schema;

namespace Evernote.Domain.Entities {

    [Table("TagNotes")]
    public class TagNote : DbEntity {

        [Column("NoteId")]
        public Guid NoteId { get; set; }

        public Note Note { get; set; }

        [Column("TagId")]
        public Guid TagId { get; set; }

        public Tag Tag { get; set; }
    }
}
