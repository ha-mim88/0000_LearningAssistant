using System.ComponentModel;

namespace web.Entities
{
    public class Skill
    {
        public int Id { get; set; }

        [DisplayName("Title")]
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public int Priority { get; set; }
        public string Status { get; set; } = string.Empty;
    }
}
