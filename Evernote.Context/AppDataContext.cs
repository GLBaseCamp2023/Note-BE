using Evernote.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace Evernote.Context {
    public class AppDataContext : DbContext {

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Note>(
                    note => {


                        note.HasOne(n => n.User)
                            .WithMany(u => u.Notes)
                            .HasForeignKey(n => n.UserId);



                        note.HasMany(n => n.Tags)
                            .WithMany(t => t.Notes)
                            .UsingEntity<TagNote>(
                                tn => tn.HasOne(p => p.Tag)
                                    .WithMany(a => a.TagNotes)
                                    .HasForeignKey(a => a.TagId),

                                tn => tn.HasOne(p => p.Note)
                                    .WithMany(a => a.TagNotes)
                                    .HasForeignKey(a => a.NoteId),

                                tn => tn.HasKey(
                                    qtn => new { qtn.NoteId, qtn.TagId })
                                );

                    });
            modelBuilder.Entity<Image>(
                   img => {


                       img.HasOne(n => n.Note)
                           .WithMany(u => u.Images)
                           .HasForeignKey(n => n.NoteId);



                   });


        }
    }
}