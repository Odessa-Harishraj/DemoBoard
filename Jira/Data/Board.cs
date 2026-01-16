namespace JiraClone.Data
{
    public class Board
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public int ProjectId { get; set; }
        public Project? Project { get; set; }

        public ICollection<WorkItem> WorkItems { get; set; } = new List<WorkItem>();
    }
}
