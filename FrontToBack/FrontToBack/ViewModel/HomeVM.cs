using FrontToBack.Models;

namespace FrontToBack.ViewModel
{
    public class HomeVM
    {
        public IEnumerable<SliderInfo> SliderInfos { get; set; }
        public SliderImage SliderImage { get; set; }
        public Services Services { get; set; }
        public IEnumerable<ResentWork> ResentWorks { get; set; }
        public IEnumerable<WorkImage> WorkImages { get; set; }
        public IEnumerable<Work> Works { get; set; }
        public IEnumerable<Category> Categories { get; set; }





    }
}
