using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.EF;
using System.Collections.ObjectModel;

namespace Buhar.Module.BusinessObjects
{
    [NavigationItem("Game")]
    public class Category : BaseObject
    {

        public virtual String Name { get; set; }

        public virtual IList<Game> Games { get; set; } = new ObservableCollection<Game>();
    }
}
