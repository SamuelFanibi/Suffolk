namespace GPI.Horizon.Common.Interfaces.Query
{
    public interface IQueryModule
    {
        Task<TResult> ExecuteQueryAsync<TResult>(IQuery<TResult> query);
    }
}
