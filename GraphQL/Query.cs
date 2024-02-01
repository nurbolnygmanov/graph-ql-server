using graph_ql_server.Models;
using System.Security.Claims;

namespace graph_ql_server.GraphQL
{
    public class Query
    {
        public Book GetBook(ClaimsPrincipal claims)
        {
            return new Book { Title = "The Fellowship of the Ring", Author = "J.R.R. Tolkien", Description = "The first book in the Lord of the Rings trilogy", PublishDate = new System.DateTime(1954, 7, 29) };
        }
    }

    public class BookType : ObjectType<Book>
    {
        protected override void Configure(IObjectTypeDescriptor<Book> descriptor)
        {
            descriptor.Field("publishDate").ResolveWith<Resolvers>(r => r.GetFormattedDate(default!));
        }
    }
}
