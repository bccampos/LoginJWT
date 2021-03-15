using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartStore.Identity.API.Extensions
{
    public class AppSettings
    {
        public string Secret { get; set; }
        public int ExpiryHour { get; set; }
        public string Issuer { get; set; }
        public string Valid { get; set; }
    }
}
