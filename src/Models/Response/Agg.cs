namespace polygon_client_net.Models.Response;

public class Agg
{
    public Agg()
    {

    }

    public Agg(float? open, float? high, float? low, float? close, float? volume, float? vwap, long? timestamp, int? transactions, bool? otc)
    {
        this.Open = open;
        this.High = high;
        this.Low = low;
        this.Close = close;
        this.Volume = volume;
        this.Vwap = vwap;
#pragma warning disable CS8629 // Should never be null, this data makes no sense if it is.
        this.Timestamp = DateTimeOffset.FromUnixTimeMilliseconds((long)timestamp);
#pragma warning restore CS8629
        this.Transactions = transactions;
        this.Otc = otc;
    }

    public float? Open { get; set; }
    public float? High { get; set; }
    public float? Low { get; set; }
    public float? Close { get; set; }
    public float? Volume { get; set; }
    public float? Vwap { get; set; }
    public DateTimeOffset? Timestamp { get; set; }
    public int? Transactions { get; set; }
    public bool? Otc { get; set; }

    public static Agg FromDictionary(Dictionary<string, object> dictionary)
    {
        return new Agg(
            dictionary.ContainsKey("o") ? (float?)Convert.ToDouble(dictionary["o"].ToString()) : null,
            dictionary.ContainsKey("h") ? (float?)Convert.ToDouble(dictionary["h"].ToString()) : null,
            dictionary.ContainsKey("l") ? (float?)Convert.ToDouble(dictionary["l"].ToString()) : null,
            dictionary.ContainsKey("c") ? (float?)Convert.ToDouble(dictionary["c"].ToString()) : null,
            dictionary.ContainsKey("v") ? (float?)Convert.ToDouble(dictionary["v"].ToString()) : null,
            dictionary.ContainsKey("vw") ? (float?)Convert.ToDouble(dictionary["vw"].ToString()) : null,
            dictionary.ContainsKey("t") ? Convert.ToInt64(dictionary["t"].ToString()) : null,
            dictionary.ContainsKey("n") ? Convert.ToInt32(dictionary["n"].ToString()) : null,
            dictionary.ContainsKey("otc") ? Convert.ToBoolean(dictionary["otc"].ToString()) : null
        );
    }
}
