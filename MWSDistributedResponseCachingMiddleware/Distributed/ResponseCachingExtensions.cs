using System.Diagnostics;

namespace ExternalNetcoreExtensions.Distributed;

public static class ResponseCachingExtensions
{
    public const string Name = "MWSDistributedResponseCaching";
    private static readonly ActivitySource ActivitySource = new(Name);

    public static Activity? StartActivity(string name)
    {
        return ActivitySource.StartActivity(name);
    }
}
