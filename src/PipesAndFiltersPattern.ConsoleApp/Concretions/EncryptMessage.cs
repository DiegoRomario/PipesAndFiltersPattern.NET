using PipesAndFiltersPattern.ConsoleApp.Interfaces;

namespace PipesAndFiltersPattern.ConsoleApp.Concretions
{
    public class EncryptMessage : IOperation<IMessage>
    {
        public IMessage Execute(IMessage input)
        {
            return Encrypt(input);
        }
        private IMessage Encrypt(IMessage input)
        {
            input.IsEncrypted = true;
            return input;
        }
    }
}
