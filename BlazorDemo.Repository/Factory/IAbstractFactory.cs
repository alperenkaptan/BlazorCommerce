namespace BlazorDemo.Repository.Factory
{
    public interface IAbstractFactory<T>
    {
        T Create();
    }
}