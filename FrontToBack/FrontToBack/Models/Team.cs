namespace FrontToBack.Models
{
    public class Team: BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<TeamMember> TeamMembers { get; set; }


    }
}
