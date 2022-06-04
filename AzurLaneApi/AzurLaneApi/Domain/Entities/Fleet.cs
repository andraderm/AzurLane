namespace AzurLaneApi.Domain.Entities
{
    public class Fleet : BaseStatus
    {
        public string Name { get; set; }
        public ICollection<Guid> ShipsIds { get; set; }

        public Fleet() : base()
        {
            Name = string.Empty;
            ShipsIds = new List<Guid>();
        }
    }
}
