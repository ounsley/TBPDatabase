using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using TBPDatabase.Domain;

namespace TBPDatabase.Controls
{
    class MyDataGridViewCell : DataGridViewTextBoxCell
    {
        public MyDataGridViewCell()
            : base()
        {
        }

        protected override bool SetValue(int rowIndex, object value)
        {
            return base.SetValue(rowIndex, ((Individual)value).Name);
        }
    }

    class MyDataGridViewColumn : DataGridViewColumn
    {
        
        
        public override DataGridViewCell CellTemplate
        {
            get
            {
                return new MyDataGridViewCell();
            }
            set
            {
                this.CellTemplate = value;
            }
        }
    }
}
