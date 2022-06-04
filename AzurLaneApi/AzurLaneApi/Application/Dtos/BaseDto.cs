namespace AzurLaneApi.Application.Dtos
{
    public class BaseDto
    {
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool Removed { get; set; }

        public BaseDto()
        {
            Id = string.Empty;
            CreatedAt = DateTime.MinValue;
            UpdatedAt = DateTime.MinValue;
            Removed = false;
        }
    }
}
