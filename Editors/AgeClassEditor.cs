using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using NHibernate;
using TBPDatabase.Domain;

namespace TBPDatabase.Editors
{
    class AgeClassEditor : StateEditor<IndividualAgeClass,AgeClass>
    {
        public AgeClassEditor(ISession session, Individual individual, IndividualAgeClass individualAgeClass = null)
            :base(session,individual,individualAgeClass,"Select c from AgeClass as c")
        {
        }

    }
}
