using System;
using System.IO;
using System.IO.Compression;

namespace MCPS3L
{
    public static class ZipHandler
    {
        public static void ExtractAndCleanup(string zipFilePath)
        {
            if (!File.Exists(zipFilePath))
                throw new FileNotFoundException("The zip file was not found.", zipFilePath);

            string extractPath = Path.GetDirectoryName(zipFilePath);

            try
            {
                ZipFile.ExtractToDirectory(zipFilePath, extractPath, overwriteFiles: true);

                File.Delete(zipFilePath);
            }
            catch (Exception ex)
            {
                throw new Exception($"Extraction failed: {ex.Message}", ex);
            }
        }
    }
}