using TBPDatabase.Domain;
using NHibernate;

namespace TBPDatabase.Editors
{
    public partial class AgeClassEditor2 : StateEditor<IndividualAgeClass,AgeClass>
    {
        public AgeClassEditor2(ISession session, Individual individual, IndividualAgeClass individualAgeClass = null)
            :base(session,individual,individualAgeClass,"Select c from AgeClass as c")
        {
        }
    }
}
