using System;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace BookmakerClient.Core
{
    public static class XmlUtils
    {
        private static string RemoveDiacritics(string input)
        {
            string normalized = input.Normalize(NormalizationForm.FormKD);
            Encoding removal = Encoding.GetEncoding(Encoding.ASCII.CodePage, new EncoderReplacementFallback(""), new DecoderReplacementFallback(""));
            byte[] bytes = removal.GetBytes(normalized);
            return Encoding.ASCII.GetString(bytes);
        }

        public static T GetFeedFromXML<T>(string xml)
        {
            xml = RemoveDiacritics(xml);
            xml = xml.Replace("'", "").Replace("&", "and").Replace("amp;", "");

            T obj = (T)Activator.CreateInstance(typeof(T));
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            using (StringReader stringReader = new StringReader(xml))
            {
                obj = (T)xmlSerializer.Deserialize(stringReader);
            }
            return obj;
        }
    }
}
