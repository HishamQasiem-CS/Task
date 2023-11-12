using Task.Models;

namespace Task.ViewModel
{
    public class CollectionViewModel
    {
        public List<BasicInformation> BasicInformation { get; set; }

        public List<Menu> menus { get; set; }
        public List<Maintenance> managers { get; set; }
    }
}
