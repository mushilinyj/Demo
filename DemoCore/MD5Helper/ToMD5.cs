using System;
using System.Security.Cryptography;
using System.Text;

namespace DemoCore.MD5Helper
{
    public static class ToMD5
    {
        public static string ToMd5(string content)
        {
            return BitConverter.ToString(MD5.Create().ComputeHash(Encoding.Default.GetBytes(content))).Replace("-", "");
        }
    }
}
