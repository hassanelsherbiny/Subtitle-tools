using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Subtitles_Tools
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
                NewSubTitleFile += Counter++ + Environment.NewLine + item.ToSubtitleString();
            }
            System.IO.File.WriteAllText(FilePath, NewSubTitleFile, Encoding.Default);
        }

        public static void ShiftAll(this List<SubTitleItem> SubTitleItems, TimeSpan Shift)
        {
            foreach (var item in SubTitleItems)
            {
                item.Shift(Shift);
            }
        }
    }
}
