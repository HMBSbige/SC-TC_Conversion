using System;
using System.Collections.Generic;
using System.Text;

namespace SC_TC_Conversion_File
{
    static class TextEncoding
    {
        private static Encoding utf8withoutbom = new UTF8Encoding(false);
        private static Encoding utf8withbom = new UTF8Encoding(true);
        private static Encoding gb2312 = Encoding.GetEncoding(@"gb2312");//936
        private static Encoding big5 = Encoding.GetEncoding(@"big5");//950
        private static Encoding ascii = Encoding.ASCII;
        private static Encoding U16BE = Encoding.BigEndianUnicode;
        private static Encoding U16LE = Encoding.Unicode;

        private static Dictionary<string,Encoding> encodingDic = new Dictionary<string, Encoding>
        {
            {@"UTF-8", utf8withoutbom },
            {@"UTF-8-BOM", utf8withbom },
            {@"GB2312", gb2312 },
            {@"Big5", big5 },
            {@"ANSI",  ascii},
            {@"UTF-16 BE",  U16BE},
            {@"UTF-16 LE",  U16LE},
        };

        public static Encoding GetEncoding(string str)
        {
            foreach (var encoding in encodingDic)
            {
                if (encoding.Key == str)
                {
                    return encoding.Value;
                }
            }

            try
            {
                var codepage = Convert.ToInt32(str);
                return Encoding.GetEncoding(codepage);
            }
            catch
            {
                try
                {
                    return Encoding.GetEncoding(str);
                }
                catch
                {
                    return Encoding.Default;
                }
            }
        }
    }
}
