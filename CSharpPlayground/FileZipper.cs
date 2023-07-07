using ICSharpCode.SharpZipLib.Zip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Fischer.DataSuite.Export
{
    public class FileZipper
    {
        private static readonly string password = "password";

        public static byte[] ZipFile(Dictionary<string, string> dataDict)
        {
            using var stream = new MemoryStream();
            using (var zip = new ZipOutputStream(stream)) {
                zip.SetLevel(9);  // Best compression
                zip.Password = password;

                foreach (var data in dataDict) {
                    AddZipEntry(zip, data);
                }
                zip.Close();
            }

            return stream.ToArray();
        }

        private static void AddZipEntry(ZipOutputStream zip, KeyValuePair<string, string> data)
        {
            var zipEntryFileName = data.Key;
            var jsonString = data.Value;

            var bytes = Encoding.UTF8.GetBytes(jsonString);
            var zipEntry = new ZipEntry(zipEntryFileName) {
                DateTime = DateTime.Now,
                Size = bytes.Length
            };

            zip.PutNextEntry(zipEntry);
            zip.Write(bytes, 0, bytes.Length);
            zip.CloseEntry();
        }

        public static Dictionary<string, string> UnzipFile(string file)
        {
            Dictionary<string, string> dataDict = new();

            using (var zip = new ZipInputStream(File.OpenRead(file))) {
                zip.Password = password;

                ZipEntry zipEntry;
                while ((zipEntry = zip.GetNextEntry()) != null) {
                    if (zipEntry.IsFile) {
                        dataDict.Add(zipEntry.Name, File.ReadAllText(zipEntry.Name));
                    }
                }
            }
            return dataDict;
        }
    }
}
