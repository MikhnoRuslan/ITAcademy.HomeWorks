namespace Task3.Interfaces
{
    public interface IMotorcycleRepositories<T> where T : class

    {
        void GetMotorcycles(); 
        void GetMotorcycle(string id);
        void Create(T item);
        void Delete(string id);
    }
}