using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace PlayerPlusPlus.Core
{
    /// <summary>
    /// Srt File Data Holder
    /// </summary>
    public class SubTitleItem
    {

        public TimeSpan Start { get; set; }

        public TimeSpan End { get; set; }
        public string Text { get; set; }

        public string ToSubtitleString()
        {

            return string.Format("{0:00}:{1:00}:{2:00},{3:000} --> {4:00}:{5:00}:{6:00},{7:000}{8}{9}{8}{8}",
                        Start.Hours,
                        Start.Minutes,
                        Start.Seconds,
                        Start.Milliseconds,
                        End.Hours,
                        End.Minutes,
                        End.Seconds,
                        End.Milliseconds,
                        Environment.NewLine,
                        Text
                        );

        }

        public void Shift(TimeSpan ts)
        {
            Start = Start.Add(ts);
            End = End.Add(ts);
        }

    }
    public static class SubTitleItemExtensions
    {
        public static void WriteToFile(this List<SubTitleItem> SubTitleItems, string FilePath)
        {
            string NewSubTitleFile = "";
            int Counter = 1;
            foreach (var item in SubTitleItems)
            {

                item.Text = item.Text.Trim();

                NewSubTitleFile += Counter++ + Environment.NewLine + item.ToSubtitleString();
            }
            //System.IO.File.WriteAllText(FilePath, NewSubTitleFile, Encoding.Default);
            System.IO.File.WriteAllText(FilePath, NewSubTitleFile, GetEncoding(FilePath));

        }

        public static void ShiftAll(this List<SubTitleItem> SubTitleItems, TimeSpan Shift)
        {
            foreach (var item in SubTitleItems)
            {
                item.Shift(Shift);
            }
        }
        public static void ShiftAllAfterIndex(this List<SubTitleItem> SubTitleItems, TimeSpan Shift, int index)
        {
            for (int i = index; i < SubTitleItems.Count; i++)
            {
                var item = SubTitleItems[i];
                item.Shift(Shift);
            }
        }
        //Copied From 2Toad's answer at stackoverflow https://stackoverflow.com/a/19283954/7621536
        public static Encoding GetEncoding(string filename)
        {
            // Read the BOM
            var bom = new byte[4];
            using (var file = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                file.Read(bom, 0, 4);
            }

            // Analyze the BOM
            if (bom[0] == 0x2b && bom[1] == 0x2f && bom[2] == 0x76) return Encoding.UTF7;
            if (bom[0] == 0xef && bom[1] == 0xbb && bom[2] == 0xbf) return Encoding.UTF8;
            if (bom[0] == 0xff && bom[1] == 0xfe) return Encoding.Unicode; //UTF-16LE
            if (bom[0] == 0xfe && bom[1] == 0xff) return Encoding.BigEndianUnicode; //UTF-16BE
            if (bom[0] == 0 && bom[1] == 0 && bom[2] == 0xfe && bom[3] == 0xff) return Encoding.UTF32;
            return Encoding.Default;
        }
    }
}
