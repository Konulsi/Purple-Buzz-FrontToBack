using FrontToBack.Models;

namespace FrontToBack.ViewModel
{
    public class AboutVM
    {
        public AboutUs AboutUs { get; set; }
        public Team Team { get; set; }
        public IEnumerable<TeamMember> TeamMembers { get; set; }
       

    }
}
