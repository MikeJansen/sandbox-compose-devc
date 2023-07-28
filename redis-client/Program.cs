using StackExchange.Redis;

static class Program
{
    public static async Task<int> Main(string[] args)
    {
        ConnectionMultiplexer redis = await ConnectionMultiplexer.ConnectAsync("redis");
        var db = redis.GetDatabase();

        const string KEY = "demo:key";
 
        var existingVal = await db.StringGetAsync(KEY);
        Console.WriteLine($"Existing: {existingVal}");
        if (existingVal.IsNull)
        {
            await db.StringSetAsync(KEY, 1, TimeSpan.FromSeconds(60));
        }
        else
        {
            await db.StringIncrementAsync(KEY);
        }

        return 0;
    }
}