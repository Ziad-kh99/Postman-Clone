
namespace PostmanCloneLibrary;

public interface IApiAccess
{
    Task<string> CallApiAsync(string url, bool formattedJson = true, HttpAction httpAction = HttpAction.GET);
    bool IsValidUrl(string url);
}