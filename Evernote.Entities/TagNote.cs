using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evernote.Entities {

    [Table("TagNotes")]
    public class TagNote:DbEntity {

        [Column("NoteId")]
        public Guid NoteId { get; set; }

        public Note Note { get; set; }

        [Column("TagId")]
        public Guid TagId { get; set; }

        public Tag Tag { get; set; }
    }
}
