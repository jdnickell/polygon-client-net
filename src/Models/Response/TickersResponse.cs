using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polygon_client_net.Models.Response
{
    public class TickersResponse
    {
        public bool Active { get; set; } = default!;
        public string Cik { get; set; } = default!;
        public string CompositeFigi { get; set; } = default!;
        public string CurrencyName { get; set; } = default!;
        public DateTime LastUpdatedUtc { get; set; }
        public string Locale { get; set; } = default!;
        public string Market { get; set; } = default!;
        public string Name { get; set; } = default!;
        public string PrimaryExchange { get; set; } = default!;
        public string ShareClassFigi { get; set; } = default!;
        public string Ticker { get; set; } = default!;
        public string Type { get; set; } = default!;
    }
}
