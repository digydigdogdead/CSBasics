using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasics
{
    internal class Book
    {
        public string Name;
        public int Pages;
        public int CurrentPage;

        public Book(string name, int pages)
        {
            Name = name;
            Pages = pages;
            CurrentPage = 1;
        }

        public void TurnPage()
        {
            if (CurrentPage < Pages)
            {
                CurrentPage++;
            }
            else
            {
                Console.WriteLine("Page does not exist");
            }
        }
    }
}
