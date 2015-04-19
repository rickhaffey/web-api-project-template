namespace WebApiProjectTemplate.Data.Entities
{
    public interface IVersionedEntity
    {
        byte[] Version { get; set; }
    }
}