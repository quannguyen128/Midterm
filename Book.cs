using System;

namespace MidTerm
{
    public class Book 
    {
        //PK
        public int ID {get; set;}
        public string Title {get; set; }
        public string Publisher {get; set;}
        public string Date {get; set;}
        public int Pages {get; set;}

        //Fk
        public int AuthorID {get; set;}
        

    }
    

}