using graph_ql_server.Models;

namespace graph_ql_server.GraphQL
{
    public class Resolvers
    {
        public string GetFormattedDate([Parent] Book book) => book.PublishDate.ToString("D");
    }
}
