
namespace ChannelRankins.Contracts.Data
{
    public interface ISqlServerDatabase
    {
        IDbContext Context { get; }

        void Commit();

        void Dispose();
    }
}
