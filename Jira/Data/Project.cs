namespace JiraClone.Data
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }

        public ICollection<Board> Boards { get; set; } = new List<Board>();
    }
}
