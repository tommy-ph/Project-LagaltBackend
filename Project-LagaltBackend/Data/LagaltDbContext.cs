using Microsoft.EntityFrameworkCore;
using Project_LagaltBackend.Models.Main;

namespace Project_LagaltBackend.Data
{
    public class LagaltDbContext: DbContext
    {
      
        public DbSet<User> Users { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Collabrator> ProjectCollabrators { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<ChatMessage> ChatMessages { get; set; }
        public DbSet<History> UserHistories { get; set; }
        public DbSet<Tag> Tags { get; set; }

        public LagaltDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure many-to-many relationship between User and Skill
            modelBuilder.Entity<User>()
                .HasMany(u => u.Skills)
                .WithMany(s => s.Users)
                .UsingEntity<Dictionary<string, object>>(
                "UserSkill",
                u => u.HasOne<Skill>().WithMany().HasForeignKey("SkillId"),
                s => s.HasOne<User>().WithMany().HasForeignKey("UserId"),
                joinEntity =>
                {
                    joinEntity.HasKey("UserId", "SkillId");
                    joinEntity.ToTable("UserSkills");

                    joinEntity.Property<int>("UserId");
                    joinEntity.Property<int>("SkillId");
                });

            // Configure one-to-many relationship between User and Message
            modelBuilder.Entity<User>()
                .HasMany(u => u.Messages)
                .WithOne(m => m.Sender)
                .HasForeignKey(m => m.SenderId)
                .OnDelete(DeleteBehavior.Cascade);

            // Configure one-to-many relationship between User and Project
            modelBuilder.Entity<User>()
                .HasMany(u => u.Projects)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            // Configure one-to-many relationship between User and Collabrator
            modelBuilder.Entity<User>()
                .HasMany(u => u.ProjectApplications)
                .WithOne(c => c.User)
                .HasForeignKey(c => c.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // Configure one-to-many relationship between User and Tag
            modelBuilder.Entity<User>()
                .HasMany(u => u.UserTags)
                .WithOne(t => t.User)
                .HasForeignKey(t => t.Id)
                .OnDelete(DeleteBehavior.Cascade);

            // Configure one-to-many relationship between User and ChatMessage
            modelBuilder.Entity<User>()
                .HasMany(u => u.ChatMessages)
                .WithOne(cm => cm.User)
                .HasForeignKey(cm => cm.Id)
                .OnDelete(DeleteBehavior.Cascade);

            // Configure many-to-many relationship between Project and Skill
            modelBuilder.Entity<Project>()
                .HasMany(p => p.Skills)
                .WithMany(s => s.Projects)
                .UsingEntity<Dictionary<string, object>>(
                "ProjectSkill",
                p => p.HasOne<Skill>().WithMany().HasForeignKey("SkillId"),
                s => s.HasOne<Project>().WithMany().HasForeignKey("ProjectId"),
                joinEntity =>
                {
                    joinEntity.HasKey("ProjectId", "SkillId");
                    joinEntity.ToTable("ProjectSkills");

                    joinEntity.Property<int>("ProjectId");
                    joinEntity.Property<int>("SkillId");
                });

            modelBuilder.Entity<Project>()
                 .HasOne(p => p.User)
                 .WithMany()
                 .HasForeignKey(p => p.UserId)
                 .OnDelete(DeleteBehavior.Restrict);


            // Configure one-to-many relationship between Project and Collabrator
            modelBuilder.Entity<Project>()
                .HasMany(p => p.Collabrators)
                .WithOne(c => c.Project)
                .HasForeignKey(c => c.ProjectId)
                .OnDelete(DeleteBehavior.Cascade);

            // Configure one-to-many relationship between Project and Tag
            modelBuilder.Entity<Project>()
                .HasMany(p => p.ProjectTags)
                .WithOne(t => t.Project)
                .HasForeignKey(t => t.Id)
                .OnDelete(DeleteBehavior.Cascade);

            // Configure one-to-many relationship between Project and Message
            modelBuilder.Entity<Project>()
                .HasMany(p => p.Messages)
                .WithOne(m => m.Project)
                .HasForeignKey(m => m.ProjectId)
                .OnDelete(DeleteBehavior.Cascade);

            // Configure one-to-many relationship between Project and ChatMessage
            modelBuilder.Entity<Project>()
                .HasMany(p => p.ChatMessages)
                .WithOne(cm => cm.Project)
                .HasForeignKey(cm => cm.Id)
                .OnDelete(DeleteBehavior.Cascade);


            // Add seed data
            modelBuilder.Entity<User>().HasData(SeedData.GetUser());
            modelBuilder.Entity<Skill>().HasData(SeedData.GetSkill());
            modelBuilder.Entity<Project>().HasData(SeedData.GetProject());
            modelBuilder.Entity<Collabrator>().HasData(SeedData.GetProjectApplication());
            modelBuilder.Entity<Message>().HasData(SeedData.GetMessage());
            modelBuilder.Entity<Tag>().HasData(SeedData.GetTag());
            modelBuilder.Entity<ChatMessage>().HasData(SeedData.GetChatMessage());
            modelBuilder.Entity<History>().HasData(SeedData.GetHistory());

            // Configuring the value conversion for the enums
            modelBuilder.Entity<Project>()
                .Property(p => p.Progress)
                .HasConversion<string>();

            modelBuilder.Entity<Message>()
                .Property(m => m.Type)
                .HasConversion<string>();

            modelBuilder.Entity<History>()
                .Property(h => h.ActionType)
                .HasConversion<string>();

            modelBuilder.Entity<ChatMessage>()
                .Property(cm => cm.Type)
                .HasConversion<string>();


        }

    }
}
