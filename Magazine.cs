class Magazine : Document{
    private string Release_Num {get; set;}
    private string Release_Page {get; set;}

    public Magazine(int Id, string Name, string Publisher, string Release_Num, string Release_Page, int CateId) : base(Id, Name, Publisher, CateId) {
        this.Release_Num = Release_Num;
        this.Release_Page = Release_Page;
    }
}