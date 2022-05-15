namespace PipesAndFiltersPattern.ConsoleApp.Interfaces
{
    public abstract class PipelineBase<T>
    {
        private readonly List<IOperation<T>> operations = new List<IOperation<T>>();

        public PipelineBase<T> Register(IOperation<T> operation)
        {
            this.operations.Add(operation);
            return this;
        }

        public T PerformOperation(T input)
        {
            return this.operations.Aggregate(input, (current, operation) => operation.Execute(current));
        }
    }
}
