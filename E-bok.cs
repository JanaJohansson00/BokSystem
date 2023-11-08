using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BokSystem
{
    public class E_bok : BookClass
    {
        public double FileSize { get; set; }
        public string DownloadUrl { get; set; }

        public E_bok (double fileSize, string downloadUrl)
            :base(string title, string author, int isbn)
        {
            FileSize = FileSize;
            DownloadUrl = downloadUrl;
        }
    }

    public override WriteBookInfo()
    {
        Console.WriteLine($"Titel: {Title}, Författare: {Author}, ISBN-nummer: {Isbn},FilStorlek: {FileSize} DownloadUrl: {DownloadUrl} ");
    }
}
