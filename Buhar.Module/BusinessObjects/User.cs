using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.EF;
using System.Collections.ObjectModel;

namespace Buhar.Module.BusinessObjects
{

    [NavigationItem("User")]
    public class User : BaseObject
    {

        public virtual String UserName { get; set; }

        public virtual DateTime BirthDate { get; set; }


        [FieldSize(255)]
        public virtual String Email { get; set; }

        public virtual IList<Game> Games { get; set; } = new ObservableCollection<Game>();

    }
}
