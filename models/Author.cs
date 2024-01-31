namespace OneToManyTask2.models
{
    public class Author
    {
        public int AuthorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Book> books { get; set; }
    }
}
