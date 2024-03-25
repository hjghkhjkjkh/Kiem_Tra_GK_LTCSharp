class Newspaper : Document{
    public DateTime Release_Date {get; set;}

    public Newspaper(int Id, string Name, string Publisher, DateTime Release_Date, int CateId) : base(Id, Name, Publisher, CateId) {
        this.Release_Date = Release_Date;
    }
}