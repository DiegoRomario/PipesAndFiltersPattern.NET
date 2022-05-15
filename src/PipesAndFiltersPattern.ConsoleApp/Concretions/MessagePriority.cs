using PipesAndFiltersPattern.ConsoleApp.Interfaces;

namespace PipesAndFiltersPattern.ConsoleApp.Concretions
{
    class MessagePriority : IOperation<IMessage>
    {
        public IMessage Execute(IMessage input)
        {
            input.Priority = 1;
            return input;
        }
    }
}
