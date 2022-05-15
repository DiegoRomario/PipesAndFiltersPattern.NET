namespace PipesAndFiltersPattern.ConsoleApp.Interfaces
{
    public interface IOperation<T>
    {
        T Execute(T input);
    }
}
