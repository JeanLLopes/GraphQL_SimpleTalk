using GraphQL.Types;
using GraphQL_SimpleTalk.Entities;

namespace GraphQL_SimpleTalk.Queries.Types
{
    public class SNTypeType : ObjectGraphType<SNType>
    {
        public SNTypeType()
        {
            Name = "SNTypeType";
        }
    }
}
