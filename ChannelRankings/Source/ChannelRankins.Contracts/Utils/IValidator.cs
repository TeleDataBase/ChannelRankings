
namespace ChannelRankins.Contracts.Utils
{
    public interface IValidator
    {
        string ValidateNumberValue(string name);

        string ValidateCreationName(string value);

        string ValidateNameForUpdate(string name);
    }
}
