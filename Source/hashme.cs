using System;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;

namespace hashme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("hashme (netcore) - v0.1");

            if (args.ToString().Length == 0)
            {
                Console.WriteLine("Usage: hashme.exe \"file.exe\"");
                goto Cleanup;
            }

            Console.WriteLine("Input PE: " + args[0] + "\n");
            if (!File.Exists(args[0]) || args[0].Length > 512)
            {
                Console.WriteLine("ERR: Invalid file path!");
                goto Cleanup;
            }
            Console.WriteLine(String.Format("{0,-6} | {1}", "MD5", ComputeMD5(args[0])));
            Console.WriteLine(String.Format("{0,-6} | {1}", "SHA1", ComputeSHA1(args[0])));
            Console.WriteLine(String.Format("{0,-6} | {1}", "SHA256", ComputeSHA256(args[0])));

            Cleanup:
            Console.ReadKey();
            return;
        }

        static string ComputeMD5(string path)
        {
            try
            {
                using (var md5 = MD5.Create())
                {
                    using (var stream = File.OpenRead(path))
                    {
                        var hash = md5.ComputeHash(stream);
                        return BitConverter.ToString(hash).Replace("-", String.Empty).ToUpperInvariant();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        static string ComputeSHA1(string path)
        {
            try
            {
                using (var sha1 = SHA1.Create())
                {
                    using (var stream = File.OpenRead(path))
                    {
                        var hash = sha1.ComputeHash(stream);
                        return BitConverter.ToString(hash).Replace("-", String.Empty).ToUpperInvariant();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        static string ComputeSHA256(string path)
        {
            try
            {
                using (var sha256 = SHA256.Create())
                {
                    using (var stream = File.OpenRead(path))
                    {
                        var hash = sha256.ComputeHash(stream);
                        return BitConverter.ToString(hash).Replace("-", String.Empty).ToUpperInvariant();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
