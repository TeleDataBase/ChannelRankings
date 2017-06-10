
namespace ChannelRankins.Contracts.Data
{
    public interface IDbManipulationManager
    {
        void AddOwnerToDb(string firstName, string lastName, string netWorth);

        void AddSponsorToDb(string name, string description);

        void UpdateChannel(int channelId, string newChannelName, string newChannelRankplace);

        void UpdateCountry(int countryId, string newCountryName);

        void DeleteOwner(int deleteModelId);

        void DeleteCountry(int deleteModelId);
    }
}
