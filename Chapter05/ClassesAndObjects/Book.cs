namespace ClassesAndObjects;
class Book
{
    string _title;
    string _author;
    int _numberOfPages;

    public Book(string title, string aurhor, int numberOfPages)
    {
        this._title = title;
        this._author = aurhor;
        this._numberOfPages = numberOfPages;
    }

    public void Read(int pages)
    {
        //lets make sure that the number of pages passed in is <= the number of pages in the book
        if (pages > this._numberOfPages)
        {
            Console.WriteLine("That more pages than what's in the book!");
            return;
        }

        Console.WriteLine("Reading {0} pages...", pages);
    }
}