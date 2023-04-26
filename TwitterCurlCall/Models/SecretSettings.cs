using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterCurlCall.Models
{
    public class SecretSettings
    {
        public string ConsumerKey { get; set; }
        public string Authorization { get; set; }

        public string APIendpoint { get; set; }
        public string ConsumerSecret { get; set; }

    }
}
