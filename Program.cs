using System;
using System.Collections.Generic;
using System.Linq;

namespace MidTerm
{
    class Program
    {
        public static void PrintBooksSortedbyLastNameGroupedbyPublisher()
        {
            Console.WriteLine();
            using(var db = new AppDbContext())
            {
                 db.Database.EnsureDeleted();
                 db.Database.EnsureCreated();

                        List<Author> books = new List<Author>()
                        {
                            new Author()
                            {
                                Title = "Pro ASP.NET Core MVC 2 7th Edition",
                                Publisher = "Apress",
                                Date = "October 25 2017",
                                AuthorFirstName = "Adam",
                                AuthorLastName = "Freeman",
                                Pages = 1017
                            },
                            new Author()
                            {
                                Title = "Angular 6 3rd Edition",
                                Publisher = "Apress",
                                Date = "October 10 2018",
                                AuthorFirstName = "Adam",
                                AuthorLastName = "Freeman",
                                Pages = 776
                            },
                            new Author()
                            {
                                Title = "Programming Microsoft Azure Service Fabric (Devoloper Reference) 2nd",
                                Publisher = "N/A",
                                Date = "May 25 2017",
                                AuthorFirstName = "Haishi",
                                AuthorLastName = "Bai",
                                Pages = 528
                            }
                        };   
                        db.Authors.AddRange(books);  
                        db.SaveChanges(); 
                        var booksubset = db.Authors.ToList();
                        var filtered = from s in booksubset
                                            orderby s.AuthorLastName
                                            group s by s.Publisher;

                        foreach(var c in filtered)
                        {
                            Console.WriteLine($"--------Grouped by {c.Key} ----------\n");
                            foreach(var s in c){
                                Console.WriteLine(s);
                            }
                        }              
                        
            }
        }
        public static void PrintBooksGroupedbyPublisher()
        {
            using(var db = new AppDbContext())
            {
                 db.Database.EnsureDeleted();
                 db.Database.EnsureCreated();

                        List<Author> books = new List<Author>()
                        {
                            new Author()
                            {
                                Title = "Pro ASP.NET Core MVC 2 7th Edition",
                                Publisher = "Apress",
                                Date = "October 25 2017",
                                AuthorFirstName = "Adam",
                                AuthorLastName = "Freeman",
                                Pages = 1017
                            },
                            new Author()
                            {
                                Title = "Angular 6 3rd Edition",
                                Publisher = "Apress",
                                Date = "October 10 2018",
                                AuthorFirstName = "Adam",
                                AuthorLastName = "Freeman",
                                Pages = 776
                            },
                            new Author()
                            {
                                Title = "Programming Microsoft Azure Service Fabric (Devoloper Reference) 2nd",
                                Publisher = "N/A",
                                Date = "May 25 2017",
                                AuthorFirstName = "Haishi",
                                AuthorLastName = "Bai",
                                Pages = 528
                            }
                        };   
                        db.Authors.AddRange(books);  
                        db.SaveChanges(); 
                        var booksubset = db.Authors.ToList();
                        var filtered = booksubset.GroupBy(b => b.Publisher); 
                        foreach(var apress in filtered)
                        {
                            Console.WriteLine(apress);
                        }
            }
        }
        public static void PrintBooksOrderedbyTitleDescending()
        {
            using(var db = new AppDbContext())
            {
                 db.Database.EnsureDeleted();
                 db.Database.EnsureCreated();

                        List<Author> books = new List<Author>()
                        {
                            new Author()
                            {
                                Title = "Pro ASP.NET Core MVC 2 7th Edition",
                                Publisher = "Apress",
                                Date = "October 25 2017",
                                AuthorFirstName = "Adam",
                                AuthorLastName = "Freeman",
                                Pages = 1017
                            },
                            new Author()
                            {
                                Title = "Angular 6 3rd Edition",
                                Publisher = "Apress",
                                Date = "October 10 2018",
                                AuthorFirstName = "Adam",
                                AuthorLastName = "Freeman",
                                Pages = 776
                            },
                            new Author()
                            {
                                Title = "Programming Microsoft Azure Service Fabric (Devoloper Reference) 2nd",
                                Publisher = "N/A",
                                Date = "May 25 2017",
                                AuthorFirstName = "Haishi",
                                AuthorLastName = "Bai",
                                Pages = 528
                            }
                        };   
                        db.Authors.AddRange(books);  
                        db.SaveChanges(); 
                        var booksubset = db.Authors.ToList();
                        var filtered = booksubset.OrderByDescending(b => b.Title); 
                        foreach(var apress in filtered)
                        {
                            Console.WriteLine(apress);
                        }
            }
        }
        public static void PrintBooksOrderedbyLastName()
        {
            using(var db = new AppDbContext())
            {
                 db.Database.EnsureDeleted();
                 db.Database.EnsureCreated();

                        List<Author> books = new List<Author>()
                        {
                            new Author()
                            {
                                Title = "Pro ASP.NET Core MVC 2 7th Edition",
                                Publisher = "Apress",
                                Date = "October 25 2017",
                                AuthorFirstName = "Adam",
                                AuthorLastName = "Freeman",
                                Pages = 1017
                            },
                            new Author()
                            {
                                Title = "Angular 6 3rd Edition",
                                Publisher = "Apress",
                                Date = "October 10 2018",
                                AuthorFirstName = "Adam",
                                AuthorLastName = "Freeman",
                                Pages = 776
                            },
                            new Author()
                            {
                                Title = "Programming Microsoft Azure Service Fabric (Devoloper Reference) 2nd",
                                Publisher = "N/A",
                                Date = "May 25 2017",
                                AuthorFirstName = "Haishi",
                                AuthorLastName = "Bai",
                                Pages = 528
                            }
                        };   
                        db.Authors.AddRange(books);  
                        db.SaveChanges(); 
                        var booksubset = db.Authors.ToList();
                        var filtered = booksubset.OrderBy(b => b.AuthorLastName); 
                        foreach(var apress in filtered)
                        {
                            Console.WriteLine(apress);
                        }
            }
        }
        public static void PrintBookWith1000PlusPages()
        {
            using(var db = new AppDbContext())
            {
                 db.Database.EnsureDeleted();
                 db.Database.EnsureCreated();

                        List<Author> books = new List<Author>()
                        {
                            new Author()
                            {
                                Title = "Pro ASP.NET Core MVC 2 7th Edition",
                                Publisher = "Apress",
                                Date = "October 25 2017",
                                AuthorFirstName = "Adam",
                                AuthorLastName = "Freeman",
                                Pages = 1017
                            },
                            new Author()
                            {
                                Title = "Angular 6 3rd Edition",
                                Publisher = "Apress",
                                Date = "October 10 2018",
                                AuthorFirstName = "Adam",
                                AuthorLastName = "Freeman",
                                Pages = 776
                            },
                            new Author()
                            {
                                Title = "Programming Microsoft Azure Service Fabric (Devoloper Reference) 2nd",
                                Publisher = "N/A",
                                Date = "May 25 2017",
                                AuthorFirstName = "Haishi",
                                AuthorLastName = "Bai",
                                Pages = 528
                            }
                        };   
                        db.Authors.AddRange(books);  
                        db.SaveChanges(); 
                        var booksubset = db.Authors.ToList();
                        var filtered = booksubset.Find(b => b.Pages >= 1000); 
                        Console.WriteLine(filtered);
                        
            }
        }
        public static void PrintFirstInstanceofAdam()
        {
            using(var db = new AppDbContext())
            {
                 db.Database.EnsureDeleted();
                 db.Database.EnsureCreated();

                        List<Author> books = new List<Author>()
                        {
                            new Author()
                            {
                                Title = "Pro ASP.NET Core MVC 2 7th Edition",
                                Publisher = "Apress",
                                Date = "October 25 2017",
                                AuthorFirstName = "Adam",
                                AuthorLastName = "Freeman",
                                Pages = 1017
                            },
                            new Author()
                            {
                                Title = "Angular 6 3rd Edition",
                                Publisher = "Apress",
                                Date = "October 10 2018",
                                AuthorFirstName = "Adam",
                                AuthorLastName = "Freeman",
                                Pages = 776
                            },
                            new Author()
                            {
                                Title = "Programming Microsoft Azure Service Fabric (Devoloper Reference) 2nd",
                                Publisher = "N/A",
                                Date = "May 25 2017",
                                AuthorFirstName = "Haishi",
                                AuthorLastName = "Bai",
                                Pages = 528
                            }
                        };   
                        db.Authors.AddRange(books);  
                        db.SaveChanges(); 
                        var booksubset = db.Authors.ToList();
                        var filtered = booksubset.Find(b => b.AuthorFirstName == "Adam"); 
                        Console.WriteLine(filtered);
                        
            }
        }
        public static void PrintBooksPublishedbyApress()
        {
            using(var db = new AppDbContext())
            {
                 db.Database.EnsureDeleted();
                 db.Database.EnsureCreated();

                        List<Author> books = new List<Author>()
                        {
                            new Author()
                            {
                                Title = "Pro ASP.NET Core MVC 2 7th Edition",
                                Publisher = "Apress",
                                Date = "October 25 2017",
                                AuthorFirstName = "Adam",
                                AuthorLastName = "Freeman",
                                Pages = 1017
                            },
                            new Author()
                            {
                                Title = "Angular 6 3rd Edition",
                                Publisher = "Apress",
                                Date = "October 10 2018",
                                AuthorFirstName = "Adam",
                                AuthorLastName = "Freeman",
                                Pages = 776
                            },
                            new Author()
                            {
                                Title = "Programming Microsoft Azure Service Fabric (Devoloper Reference) 2nd",
                                Publisher = "N/A",
                                Date = "May 25 2017",
                                AuthorFirstName = "Haishi",
                                AuthorLastName = "Bai",
                                Pages = 528
                            }
                        };   
                        db.Authors.AddRange(books);  
                        db.SaveChanges(); 
                        var booksubset = db.Authors.ToList();
                        var filtered = booksubset.Where(b => b.Publisher == "Apress"); 
                        foreach(var apress in filtered)
                        {
                            Console.WriteLine(apress);
                        }
            }
        }
        public static void PrintAuthorsWithShortestName()
        {
            using(var db = new AppDbContext())
            {
                 db.Database.EnsureDeleted();
                 db.Database.EnsureCreated();

                        List<Author> books = new List<Author>()
                        {
                            new Author()
                            {
                                Title = "Pro ASP.NET Core MVC 2 7th Edition",
                                Publisher = "Apress",
                                Date = "October 25 2017",
                                AuthorFirstName = "Adam",
                                AuthorLastName = "Freeman",
                                Pages = 1017
                            },
                            new Author()
                            {
                                Title = "Angular 6 3rd Edition",
                                Publisher = "Apress",
                                Date = "October 10 2018",
                                AuthorFirstName = "Adam",
                                AuthorLastName = "Freeman",
                                Pages = 776
                            },
                            new Author()
                            {
                                Title = "Programming Microsoft Azure Service Fabric (Devoloper Reference) 2nd",
                                Publisher = "N/A",
                                Date = "May 25 2017",
                                AuthorFirstName = "Haishi",
                                AuthorLastName = "Bai",
                                Pages = 528
                            }
                        };   
                        db.Authors.AddRange(books);  
                        db.SaveChanges(); 
                        var booksubset = db.Authors.ToList();
                        var minLength = booksubset.Min(s => s.AuthorFirstName.Length);
                        var filtered = booksubset.OrderBy(b => b.AuthorFirstName.Length).First();  
                        Console.WriteLine(filtered);
                        
            }
        }
        public static void PrintAllRecordsToConsole() 
        {
            using(var db = new AppDbContext())
            {
                 db.Database.EnsureDeleted();
                 db.Database.EnsureCreated();

                        List<Author> books = new List<Author>()
                        {
                            new Author()
                            {
                                Title = "Pro ASP.NET Core MVC 2 7th Edition",
                                Publisher = "Apress",
                                Date = "October 25 2017",
                                AuthorFirstName = "Adam",
                                AuthorLastName = "Freeman",
                                Pages = 1017
                            },
                            new Author()
                            {
                                Title = "Angular 6 3rd Edition",
                                Publisher = "Apress",
                                Date = "October 10 2018",
                                AuthorFirstName = "Adam",
                                AuthorLastName = "Freeman",
                                Pages = 776
                            },
                            new Author()
                            {
                                Title = "Programming Microsoft Azure Service Fabric (Devoloper Reference) 2nd",
                                Publisher = "N/A",
                                Date = "May 25 2017",
                                AuthorFirstName = "Haishi",
                                AuthorLastName = "Bai",
                                Pages = 528
                            }
                        };
                        foreach(Author a in books)
                        {
                            Console.WriteLine(a);
                            
                        }     
            }   
    }
        

        static void Main(string[] args)
        {
            //PrintAllRecordsToConsole(); 
            //PrintBooksPublishedbyApress();  
            //PrintAuthorsWithShortestName();
            //PrintFirstInstanceofAdam();
            //PrintBookWith1000PlusPages();
            //PrintBooksOrderedbyLastName();
            //PrintBooksOrderedbyTitleDescending();
            //PrintBooksGroupedbyPublisher(); 
            PrintBooksSortedbyLastNameGroupedbyPublisher();

            
        }
    }
}
