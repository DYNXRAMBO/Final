using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BuffteksWebsite.Models
{
    public class DataSeeder
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using(var db = new BuffteksWebsiteContext(serviceProvider.GetRequiredService<DbContextOptions<BuffteksWebsiteContext>>()))
            {
                db.Database.EnsureCreated();
                if (!db.Projects.Any() && !db.Clients.Any() && !db.Members.Any())
                {
                    
                    // CLIENTS
                    var clients = new List<Client>
                    {
                        new Client { FirstName="Mason", LastName="McCollum", CompanyName="Pantex", Email="masonBmc@yahoo.com", Phone="806-567-3854" },
                        new Client { FirstName="Daniel", LastName="Hix", CompanyName="Nasa", Email="DanTheManHix@Gmail.com", Phone="218-457-4679" },
                        new Client { FirstName="Jessi", LastName="Cundiff", CompanyName="Fox", Email="EmoGirl99@Hotmail.com", Phone="646-973-4356" }
                    };
                    db.AddRange(clients);

                    // Members
                    var members = new List<Member>
                    {
                        new Member { FirstName="John", LastName="Doe", Major="CIS", Email="jdoe1@buffs.wtamu.edu", Phone="555-555-5555" },
                        new Member { FirstName="Jane", LastName="Doe", Major="CIS", Email="janedoe2@buffs.wtamu.edu", Phone="555-555-5555" },
                        new Member { FirstName="Donald", LastName="Trump", Major="CIS", Email="AgentOrange@buffs.wtamu.edu", Phone="555-555-5555" },
                        new Member { FirstName="Barrack", LastName="Obama", Major="CIS", Email="bobama@buffs.wtamu.edu", Phone="555-555-5555" },
                        new Member { FirstName="George", LastName="Bush", Major="CIS", Email="gbush@buffs.wtamu.edu", Phone="555-555-5555" },
                        new Member { FirstName="Ted", LastName="Cruz", Major="CIS", Email="tcruz@buffs.wtamu.edu", Phone="555-555-5555" },
                        new Member { FirstName="Bill", LastName="Clinton", Major="CIS", Email="bclinton@buffs.wtamu.edu", Phone="555-555-5555" },
                        new Member { FirstName="Franklin", LastName="Rossevelt", Major="CIS", Email="froosevelt@buffs.wtamu.edu", Phone="555-555-5555" },
                        new Member { FirstName="George", LastName="Washington", Major="CIS", Email="gwashington@buffs.wtamu.edu", Phone="555-555-5555" },
                        new Member { FirstName="John", LastName="Adams", Major="CIS", Email="jadams@buffs.wtamu.edu", Phone="555-555-5555" }
                    };
                    db.AddRange(members);

                    //Projects
                    var projects = new List<Project>
                    {
                        new Project { ProjectName="The Manhattan Project", ProjectDescription="Goal: Create the biggest stick to slap other countries with *Evil Laugh*" },
                        new Project { ProjectName="Terrocata Soldiers", ProjectDescription="Our dead emperer needs clay defenders!" },
                        new Project { ProjectName="Sugar", ProjectDescription="We literally just need to make some sugar for this super awesome cake" }
                    };
                    db.AddRange(projects);
                    db.SaveChanges();
                }
                else
                {
                    //database has already been seeded
                    return;
                }

                //PROJECT ROSTER BRIDGE TABLE - THERE MUST BE PROJECTS AND PARTICIPANTS MADE FIRST
                if (!db.ProjectRoster.Any())
                {
                    //quickly grab the recent records added to the DB to get the IDs
                    var projectsFromDb = db.Projects.ToList();
                    var clientsFromDb = db.Clients.ToList();
                    var membersFromDb = db.Members.ToList();

                    var projectroster = new List<ProjectRoster>
                    {
                        //take the first project from above, the first client from above, and the first three students from above.
                        new ProjectRoster { ProjectID = projectsFromDb.ElementAt(0).ID.ToString(), 
                                            Project = projectsFromDb.ElementAt(0), 
                                            ProjectParticipantID = clientsFromDb.ElementAt(0).ID.ToString(),
                                            ProjectParticipant = clientsFromDb.ElementAt(0) },

                        new ProjectRoster { ProjectID = projectsFromDb.ElementAt(0).ID.ToString(), 
                                            Project = projectsFromDb.ElementAt(0), 
                                            ProjectParticipantID = membersFromDb.ElementAt(0).ID.ToString(),
                                            ProjectParticipant = membersFromDb.ElementAt(0) },

                        new ProjectRoster { ProjectID = projectsFromDb.ElementAt(0).ID.ToString(), 
                                            Project = projectsFromDb.ElementAt(0), 
                                            ProjectParticipantID = membersFromDb.ElementAt(1).ID.ToString(),
                                            ProjectParticipant = membersFromDb.ElementAt(1) },

                        new ProjectRoster { ProjectID = projectsFromDb.ElementAt(0).ID.ToString(), 
                                            Project = projectsFromDb.ElementAt(0), 
                                            ProjectParticipantID = membersFromDb.ElementAt(2).ID.ToString(),
                                            ProjectParticipant = membersFromDb.ElementAt(2) },                                        
                    };
                    db.AddRange(projectroster);
                    db.SaveChanges();     
                }else{return;}           

            }
        }
    }
}