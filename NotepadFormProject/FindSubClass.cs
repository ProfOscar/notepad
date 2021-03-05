using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            public static string textToReplace = "";
            public static bool isUp = false;
            public static bool isCaseSensitive = false;
            public static bool isWholeWord = false;
        }

        public static int Find()
        {
            RichTextBoxFinds options = RichTextBoxFinds.None;
            int start = 0;
            int end = -1;
            if (Parameters.isUp)
            {
                options |= RichTextBoxFinds.Reverse;
                end = Target.SelectionStart;
                if (end == 0) return -1; // we are at the beginning of text
            }
            else
            {
                start = Target.SelectionStart + Target.SelectionLength;
                if (start == Target.TextLength) return -1; // we are at the end of text
            }
            if (Parameters.isCaseSensitive)
            {
                options |= RichTextBoxFinds.MatchCase;
            }
            if (Parameters.isWholeWord)
            {
                options |= RichTextBoxFinds.WholeWord;
            }
            return Target.Find(Parameters.textToFind, start, end, options);
        }

        public static int Replace()
        {
            int retVal = 0;
            if (FindSubClass.Target.SelectedText == FindSubClass.Parameters.textToFind)
            {
                FindSubClass.Target.SelectedText = FindSubClass.Parameters.textToReplace;
                retVal = Find();
            }
            else
            {
                retVal = Find();
            }
            return retVal;
        }

        public static void ReplaceAll()
        {
            RegexOptions options = Parameters.isCaseSensitive ? RegexOptions.None : RegexOptions.IgnoreCase;
            string myTextToFind = Parameters.isWholeWord ? String.Format(@"\b{0}\b", Parameters.textToFind) : Parameters.textToFind;
            Target.Text = Regex.Replace(Target.Text, myTextToFind, Parameters.textToReplace, options);
        }

        public static void showNotFoundMessageBox()
        {
            MessageBox.Show("Impossibile trovare \"" + Parameters.textToFind + "\"",
                "Blocco note",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
