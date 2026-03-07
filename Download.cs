using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace MCConsolesLauncher
{
    public static class download
    {
        private static readonly HttpClient _httpClient = new HttpClient();
        public static async Task<string> DownloadFileWithProgressAsync(string url, string folderPath, IProgress<double> progress = null)
        {
            using var response = await _httpClient.GetAsync(url, HttpCompletionOption.ResponseHeadersRead);
            response.EnsureSuccessStatusCode();

            string fileName = GetFileNameFromResponse(response, url);
            string destinationPath = Path.Combine(folderPath, fileName);

            if (!Directory.Exists(folderPath)) Directory.CreateDirectory(folderPath);

            var totalBytes = response.Content.Headers.ContentLength;
            using var contentStream = await response.Content.ReadAsStreamAsync();
            using var fileStream = new FileStream(destinationPath, FileMode.Create, FileAccess.Write, FileShare.None, 8192, true);

            var buffer = new byte[8192];
            long totalRead = 0;
            int read;

            while ((read = await contentStream.ReadAsync(buffer, 0, buffer.Length)) > 0)
            {
                await fileStream.WriteAsync(buffer, 0, read);
                totalRead += read;

                if (totalBytes.HasValue)
                {
                    double percentage = (double)totalRead / totalBytes.Value * 100;
                    progress?.Report(percentage);
                }
            }

            return destinationPath;
        }

        private static string GetFileNameFromResponse(HttpResponseMessage response, string url)
        {
            if (response.Content.Headers.ContentDisposition?.FileName != null)
            {
                return response.Content.Headers.ContentDisposition.FileName.Trim('"');
            }

            return Path.GetFileName(new Uri(url).LocalPath) ?? "downloaded_file";
        }
    }
}