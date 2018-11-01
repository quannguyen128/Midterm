using System;

namespace MidTerm
{
    public class Author : Book
    {
        
        public string AuthorFirstName {get; set;}
        public string AuthorLastName {get; set;}

        public override string ToString()
        {
            string output = $"\nTitle: {this.Title}\nPublisher: {this.Publisher}\nDate: {this.Date}\nAuthor: {this.AuthorFirstName} {this.AuthorLastName}\nPages: {this.Pages}\n";
            return output;
        }

        

    }

   
}