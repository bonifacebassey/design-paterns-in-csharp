using ICSharpCode.SharpZipLib.Zip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Fischer.DataSuite.UI.Control
{
    public class Zipper
    {
        private readonly string password = "passord";

        public MemoryStream ZipFile(string zipFileName, Dictionary<string, string> dataDict)
        {
            using (var memoryStream = new MemoryStream()) {
                using (var zipStream = new ZipOutputStream(memoryStream)) {
                    zipStream.SetLevel(9);  // Best compression
                    zipStream.Password = password;

                    foreach (KeyValuePair<string, string> data in dataDict) {
                        AddZipEntry(zipStream, data);
                    }
                    zipStream.Close();
                }
                return memoryStream;
            }
        }

        private void AddZipEntry(ZipOutputStream zipStream, KeyValuePair<string, string> data)
        {
            var zipEntryFileName = data.Key;
            var jsonString = data.Value;

            var bytes = Encoding.UTF8.GetBytes(jsonString);
            var zipEntry = new ZipEntry(zipEntryFileName) {
                DateTime = DateTime.Now,
                Size = bytes.Length
            };

            zipStream.PutNextEntry(zipEntry);
            zipStream.Write(bytes, 0, bytes.Length);
            zipStream.CloseEntry();
        }

        public string ToString(MemoryStream stream)
        {
            using (var reader = new StreamReader(stream)) {
                return reader.ReadToEnd();
            }
        }

        public Dictionary<string, string> UnzipFile(string file)
        {
            Dictionary<string, string> dataDict = new();

            using (ZipInputStream zipStream = new ZipInputStream(File.OpenRead(file))) {
                zipStream.Password = password;

                ZipEntry zipEntry;
                while ((zipEntry = zipStream.GetNextEntry()) != null) {
                    if (zipEntry.IsFile) {
                        dataDict.Add(zipEntry.Name, File.ReadAllText(zipEntry.Name));
                    }
                }
            }
            return dataDict;
        }
    }
}
