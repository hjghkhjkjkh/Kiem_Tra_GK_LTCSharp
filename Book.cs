class Book : Document{
    private string Author {get; set;}
    private int NumOfPages {get; set;}

    public Book(int Id, string Name, string Publisher, string Author, int NumOfPages, int CateId) : base(Id, Name, Publisher, CateId) {
        this.Author = Author;
        this.NumOfPages = NumOfPages;
    }
}