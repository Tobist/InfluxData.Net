using System.Net.Http;
using System.Text;

namespace InfluxData.Net.Common.Helpers
{
    public static class HttpContentExtensions
    {
        public static MultipartFormDataContent ToMultipartHttpContent(this string content, string name)
        {
            var httpContent = new MultipartFormDataContent();
            httpContent.Add(new StringContent(content), name);

            return httpContent;
        }

        public static MultipartFormDataContent ToMultipartHttpContent(this string content)
        {
            var httpContent = new MultipartFormDataContent();
            httpContent.Add(new StringContent(content));
            return httpContent;
        }

        public static ByteArrayContent ToByteArrayContent(this string content)
        {
            UTF8Encoding encoding = new UTF8Encoding();
            byte[] byteData = encoding.GetBytes(content);
            return new ByteArrayContent(byteData);
        }

        public static StringContent ToStringContent(this string content)
        {
            return new StringContent(content, Encoding.UTF8, "text/plain");
        }
    }
}
