namespace PipesAndFiltersPattern.ConsoleApp.Interfaces
{
    public interface IMessage
    {
        int Priority { get; set; }
        bool IsEncrypted { get; set; }
        string MessageId { get; }
        string Body { get; }
        string Header { get; }
        string Subject { get; }
        bool IsMessageEncrypted();
        bool IsMessagePrioritySet();
    }
}
