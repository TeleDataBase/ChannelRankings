namespace ChannelRankings.Data.SQLite.Entity
{
    public class Coach : Person
    {
        public virtual Team Team { get; set; }
    }
}
