using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.EF;
using System.Collections.ObjectModel;

namespace Buhar.Module.BusinessObjects
{
    [NavigationItem("Game")]
    public class Game : BaseObject
    {

        public virtual String Title { get; set; }

        public virtual double Price { get; set; }

        public virtual Developer Developer { get; set; }

        public virtual Publisher Publisher { get; set; }

        public virtual IList<Category> Categories { get; set; } = new ObservableCollection<Category>();


        public virtual IList<User> Users { get; set; } = new ObservableCollection<User>();

    }
}
