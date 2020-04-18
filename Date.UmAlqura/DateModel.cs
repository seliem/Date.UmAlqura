using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Date.UmAlqura
{
    public class DateModel
    {
       
        public string Date { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public CalendarType CalendarType { get; set; }

        ///// <summary>
        ///// allFormats ={"yyyy/MM/dd","yyyy/M/d","dd/MM/yyyy","d/M/yyyy","dd/M/yyyy","d/MM/yyyy","yyyy-MM-dd","yyyy-M-d","dd-MM-yyyy","d-M-yyyy","dd-M-yyyy","d-MM-yyyy","yyyy MM dd","yyyy M d","dd MM yyyy","d M yyyy","dd M yyyy","d MM yyyy"}
        ///// </summary>
        //public string DateFormat { get; set; }

    }
    public class OptionalDateModel
    {
        public string Date { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public CalendarType CalendarType { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CalendarType
    {
        Gregorian,
        Hijri
    }
}
