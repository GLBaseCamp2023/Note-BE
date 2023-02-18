using Evernote.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Evernote.DataContext {
    public class AppDataContext : DbContext {
        protected AppDataContext(DbContextOptions<AppDataContext> options)
            :base(options)
        {
        }

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