using System;
using System.Collections.Generic;
using System.Text;

namespace BookShopForm
{
    public class Book
    {
        public string NameBook { get; set; }
        public string Form { get; set; }
        public DateTime Date { get; set; }

        public Book(string Form, DateTime Date, string NameBook)
        {
            this.NameBook = NameBook;
            this.Form = Form;
            this.Date = Date;
        }
    }
}
