using System.Linq.Expressions;

namespace Core.Specifications;

public interface ISpecification<T>
{
    Expression<Func<T, bool>> Criteria { get; }     // Generic Expression
    List<Expression<Func<T, object>>> Includes { get; }
}