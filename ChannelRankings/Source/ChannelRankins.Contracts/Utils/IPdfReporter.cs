using System.IO;

namespace ChannelRankins.Contracts.Utils
{
    public interface IPdfReporter
    {
        void CreateReport(DirectoryInfo savePath);
    }
}
