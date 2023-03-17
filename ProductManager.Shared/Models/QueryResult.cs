namespace Shared.Models
{
    public class QueryResult<T>
    {
        public IEnumerable<T> Entities { get; set; }
        public QueryResult()
        {
        }

        public QueryResult(IEnumerable<T> entities, int totalCount)
        {
            Entities = entities;
        }
    }
}
