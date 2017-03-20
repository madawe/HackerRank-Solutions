//Write MyBook class

class MyBook : Book
{
    private int price = 0;
    public MyBook(string title, string author, int pr) : base(title, author)
    {
        this.price = pr;
    }
    public override void display()
    {
        Console.WriteLine("Title:" + " " + title);
        Console.WriteLine("Author:" + " " + author);
        Console.WriteLine("Price:" + " " + price);

    }
}