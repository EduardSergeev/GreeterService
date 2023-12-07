using Google.Protobuf;

public static class Extensions
{
    public static IEnumerable<T> Cycle<T>(this IEnumerable<T> source)
    {
        while(true)
        {
            foreach(var elem in source)
            {
                yield return elem;
            }
        }
    }

    public static byte[] Serialize(this IMessage message)
    {
        using var stream = new MemoryStream();
        message.WriteTo(stream);
        return stream.ToArray();
    }      
}
