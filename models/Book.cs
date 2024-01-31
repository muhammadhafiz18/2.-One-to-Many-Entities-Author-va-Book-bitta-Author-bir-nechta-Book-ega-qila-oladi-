namespace OneToManyTask2.models
{
    public class Book
    {
        public int BookID { get; set; }
        public string BookName { get; set; }
        public int AuthorID { get; set; }
        public Author Author { get; set; }
    }
}
