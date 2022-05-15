using PipesAndFiltersPattern.ConsoleApp.Interfaces;
namespace PipesAndFiltersPattern.ConsoleApp.Concretions
{
    public class SendPipeline : PipelineBase<IMessage>
    {
        public SendPipeline(bool setPriority, bool encryptMessage)
        {
            if (setPriority) Register(new MessagePriority());

            if (encryptMessage) Register(new EncryptMessage());

        }
    }
}
