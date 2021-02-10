using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotepadFormProject
{
    static class FindSubClass
    {
        private static RichTextBox target = null;

        public static RichTextBox Target { get => target; set => target = value; }

        public struct Parameters
        {
            public static string textToFind = "";
            public static string subText = "";
            public static bool isDown = true;
            public static bool isCaseSensitive = false;
            public static bool isTextAround = false;
        }

        public static int Find()
        {
            RichTextBoxFinds options = 0;
            if (!Parameters.isDown)
            {
                options &= RichTextBoxFinds.Reverse;
            }
            if (Parameters.isCaseSensitive)
            {
                options &= RichTextBoxFinds.MatchCase;
            }
            //if (Parameters.isTextAround)
            //{
            //    options &= RichTextBoxFinds.WholeWord;
            //}
            Target.Focus(); // TODO: DA CAMBIARE, COSì NON CI PIACE!
            return Target.Find(Parameters.textToFind, 
                Target.SelectionStart + target.SelectionLength,
                options);
        }
    }
}
