namespace graph_ql_server.Models
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public DateTime PublishDate { get; set; }

        public string GetAge()
        {
            var date = DateTime.UtcNow;
            var age = date.Year - PublishDate.Year;
            return $"{age} years old";
        }
    }
}
