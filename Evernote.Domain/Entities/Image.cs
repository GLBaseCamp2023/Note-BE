using System.ComponentModel.DataAnnotations.Schema;

namespace Evernote.Domain.Entities {


    [Table("Images")]
    public class Image : DbEntity {

        [Column("Path")]
        public string Path { get; set; }

        public Guid NoteId { get; set; }
        public Note Note { get; set; }


    }
}
