using System.Globalization;

namespace ASPDOTNET6Live.Services.ThaiDate
{
    public class ThaiDate : IThaiDate
    {
        public string ShowThaiDate()
        {
            return DateTime.Now.ToString("dd MMM yyyy",new CultureInfo("th-TH"));
        }
    }
}
