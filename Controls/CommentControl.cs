using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TBPDatabase.Controls
{
    class CommentControl:PropertyControl<string>
    {
        TextBox commentsTextBox;
        
        public CommentControl(string comment)
        {
            this.FlowDirection = FlowDirection.LeftToRight;
            commentsTextBox = new TextBox();
            commentsTextBox.Text = comment;

            this.Controls.Add(new TBPLabel("Comments"));
            this.Controls.Add(commentsTextBox);
        }

        public override string GetProperty()
        {
            return commentsTextBox.Text;
        }
    }
}
