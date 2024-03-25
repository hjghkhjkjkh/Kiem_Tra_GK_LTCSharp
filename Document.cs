class Document {
    public int Id {get; set;}
    public string Name {get; set;}
    public string Publisher {get; set;}
    public int CateId {get; set;}

    public Document(int Id, string Name, string Publisher, int CateId) {
        this.Id = Id;
        this.Name = Name;
        this.Publisher = Publisher;
        this.CateId = CateId;
    }
}