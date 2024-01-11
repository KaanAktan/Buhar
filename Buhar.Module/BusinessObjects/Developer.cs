using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.EF;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Buhar.Module.BusinessObjects
{
    [NavigationItem("Companies")]
    public class Developer : BaseObject
    {
        public virtual String Name { get; set; }

        [StringLength(4096)]
        public virtual String About { get; set; }

        public virtual IList<Game> Games { get; set; } = new ObservableCollection<Game>();

    }
}
