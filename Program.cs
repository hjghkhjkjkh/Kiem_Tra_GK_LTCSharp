class Program {
    static void Main(String[] args) {
        var categories = new List<Category> {
            new Category {Id = 1, Name = "Book"},
            new Category {Id = 2, Name = "Newspaper"},
            new Category {Id = 3, Name = "Magazine"}
        };
        var documents = new List<Document> ();
        var book1 = new Book(1, "Sach 1", "NPH 1", "Nguyen Van A", 1000, 1);
        var book2 = new Book(2, "Sach 2", "NPH 2", "Nguyen Van B", 1000, 1);
        documents.Add(book1);
        documents.Add(book2);
        var newspaper1 = new Newspaper(3, "Bao 1", "Le Le", new DateTime(2024, 3, 3), 2);
        var newspaper2 = new Newspaper(4, "Bao 2", "Vinh Vinh", new DateTime(2024, 3, 4), 2);
        documents.Add(newspaper1);
        documents.Add(newspaper2);
        var magazine1 = new Magazine(5, "Tap Chi 1", "Truc Thanh", "123abc", "Page 1", 3);
        var magazine2 = new Magazine(6, "Tap Chi 2", "Huong Huong", "45def", "Page 2", 3);
        documents.Add(magazine1);
        documents.Add(magazine2);

        //Search by category
        Console.Write("Enter category(B, N, M): ");
        string category = Console.ReadLine();
        int cateId = category.Equals("B") ? 1 : category.Equals("N") ? 2: 3;
        var result = documents.Where(d => d.CateId == cateId).ToList();

        foreach (var d in result) {
            Console.WriteLine($"ID: {d.Id}, Name: {d.Name}");
        }

        //Show newspapers published in 3/2024
        var newspapers = new List<Newspaper>();
        foreach (var n in documents) {
            if (n is Newspaper) {
                Newspaper newspaper = (Newspaper) n;
                newspapers.Add(newspaper);
            }
        }
        var newspaper_result = newspapers.Where(n => n.Release_Date.Month == 3 && n.Release_Date.Year == 2024).ToList();
        Console.WriteLine("********Newspapers published in 3/2024********");
        foreach (var n in newspaper_result) {
            Console.WriteLine($"ID: {n.Id}, Name: {n.Name}");
        }
    }
}