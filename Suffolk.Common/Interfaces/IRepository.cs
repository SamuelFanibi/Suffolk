using Ardalis.Specification;

namespace Suffolk.Common.Interfaces
{
    // from Ardalis.Specification
    public interface IRepository<T> : IRepositoryBase<T> where T : class, IAggregateRoot
    {
    }
}
