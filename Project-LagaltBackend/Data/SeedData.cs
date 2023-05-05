using Project_LagaltBackend.Models.Main;

namespace Project_LagaltBackend.Data
{
    public class SeedData
    {
        public static IEnumerable<User> GetUser()
        {
            return new List<User>()
        {
                
            new User
            {
                Id = 1, 
                KeycloakId = "keycloak1",
                GoogleId = "goggle1",
                UserName = "user1",            
                Status= "Junior Dep1",
                Picture = "Pict1.png",
                Description = "I'm user 1", 
                IsProfileHidden = false,
                Skills = new List<Skill>(),
                Messages = new List<Message>(),
                UserTags = new List<Tag>(),
                ChatMessages = new List<ChatMessage>(),
                Projects = new List<Project>(),
                ProjectApplications = new List<Collabrator>(),
    },
            new User
            {
                Id = 2, 
                KeycloakId = "keycloak2", 
                GoogleId = "google2",
                UserName = "user2", 
                Picture = "Pict2.png",
                Status= "Junior Dep2",
                Description = "I'm user 2", 
                IsProfileHidden = false,
                Skills = new List<Skill>(),
                 Messages = new List<Message>(),
                UserTags = new List<Tag>(),
                ChatMessages = new List<ChatMessage>(),
                Projects = new List<Project>(),
                ProjectApplications = new List<Collabrator>()
            },
             new User
            {
                Id = 3, 
                KeycloakId = "keycloak3",
                GoogleId = "google3",
                UserName = "user3", 
                Picture = "Pict3.png",
                Status= "Junior Dep3",
                Description = "I'm user 3", 
                IsProfileHidden = true,
                Skills = new List<Skill>(),
                Messages = new List<Message>(),
                UserTags = new List<Tag>(),
                ChatMessages = new List<ChatMessage>(),
                Projects = new List<Project>(),
                ProjectApplications = new List<Collabrator>()
            }
        };
        }

        public static IEnumerable<Skill> GetSkill()
        {
            return new List<Skill>()
        {
               
            new Skill
            {
                Id = 1,
                SkillName = "C#"
            },
            new Skill
            {
                Id = 2,
                SkillName = "JavaScript"
            },
             new Skill 
             { 
                 Id = 3, 
                 SkillName = "Python" 
             },
              new Skill 
              { 
                  Id = 4, 
                  SkillName = "JavaScript" 
              }
        };
        }

        public static IEnumerable<Project> GetProject()
        {
            return new List<Project>()
        {
            new Project
            {
                Id = 1,
                Title = "Project 1",
                Description = "This is project 1",
                Progress = Progress.Founding,
                Category = "Web Application",
                Image = "Pict1",
                Link = "https://github.com/project1",
                ProjectTags = new List<Tag>(),
                Skills = new List<Skill>(),
                Applicants = new List<User>(),
                Collabrators = new List<Collabrator>(),
                Messages = new List<Message>(),
                ChatMessages = new List<ChatMessage>(),
                UserId = 1

       },
            new Project
            {
                Id = 2,
                Title = "Project 2",               
                Description = "This is project 2",
                Progress = Progress.InProgress,
                Category = "Mobile Application",
                Image = "Pict2",
                Link = null,
                ProjectTags = new List<Tag>(),
                Skills = new List<Skill>(),
                Applicants = new List<User>(),
                Collabrators = new List<Collabrator>(),
                Messages = new List<Message>(),
                ChatMessages = new List<ChatMessage>(),
                UserId = 2
            }
        };
        }

        public static IEnumerable<Tag> GetTag() 
        {
            return new List<Tag>()
            {
                 
            new Tag
            {
                Id = 1,
                TagType = "Software",
                ProjectId = 1,
                UserId = 1
            },                 
                
            new Tag
            {
                Id = 2, 
                TagType = "Design", 
                ProjectId = 2, 
                UserId = 2
            }
            };
        }

        public static IEnumerable<Collabrator> GetProjectApplication()
        {
            return new List<Collabrator>()
        {
            new Collabrator
            {
                Id = 1,
                ProjectId = 1,
                UserId = 1,
                Status = "Pending"
            },
            new Collabrator
            {
                Id = 2,
                ProjectId = 2,
                UserId = 2,
                Status = "Accepted"
            }
        };
        }

        public static IEnumerable<Message> GetMessage()
        {
            return new List<Message>()
        {
            new Message
            {
                Id = 1,
                ProjectId = 1,
                SenderId = 1,
                Timestamp = DateTime.UtcNow.ToString(), 
                Type = MessageType.Join, 
                Content = "JohnDoe has joined the project."
            },
            new Message
            {
               Id = 2,
                ProjectId = 2,
                SenderId = 2,
                Timestamp = DateTime.UtcNow.ToString(), 
                Type = MessageType.Join, 
                Content = "JaneDoe has joined the project."
            }
        };

        }

        public static IEnumerable<History> GetHistory()
        {
            return new List<History>()
            {
               new History
               {
                    Id = 1,
                    UserId = 1,
                    ProjectId = 1,
                    ActionType = ActionType.Clicked,
                    Timestamp = DateTime.UtcNow.ToString()
               },
               new History
               {
                   Id = 2, 
                   UserId = 2, 
                   ProjectId = 2, 
                   ActionType = ActionType.Clicked, 
                   Timestamp = DateTime.UtcNow.ToString()
               }
            };
        }

        public static IEnumerable<ChatMessage> GetChatMessage() 
        {
            return new List<ChatMessage>()
            {
                new ChatMessage
                {
                    Id = 1, Content = "Hello everyone!",
                    Sender = "JohnDoe",
                    Room = "Project A",
                    Type = ChatMessageType.Chat,
                    Timestamp = DateTime.UtcNow.ToString(),
                    UserId = 1,
                    ProjectId = 1
                }
            };
        }
    }
}
