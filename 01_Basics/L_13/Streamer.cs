using L_13;

namespace L_13
{
    public class Streamer
    {
        public static async Task WriteAsync(string path, List<Product> products)
        {
            using (var writer = new StreamWriter(path))
            {
                foreach (var product in products)
                {
                    await writer.WriteLineAsync(product.ToString());
                }
            }
        }
    }
}
