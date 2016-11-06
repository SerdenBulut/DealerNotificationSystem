namespace Core.UnitOfWorkBase.Interface
{
    public interface IEntity<TKey>
    {
        TKey Id { get; set; }
    }

    public interface IEntity : IEntity<int>
    {
        
    }
}
