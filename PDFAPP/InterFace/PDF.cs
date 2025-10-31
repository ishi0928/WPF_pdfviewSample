using System.IO;

namespace PDFAPP
{

    //インターフェース
    public interface pdfApp
    {
        public string encoding { get;}
        public char delimiter { get;}
        public string filepath { get;}
    }

    //実装
    public class PDF : pdfApp
    {

        public string encoding { get; private set; }
        public char delimiter { get; private set; }
        public string filepath { get; private set; }

        public PDF()
        {
            encoding = "utf-8";
            delimiter = ',';
            filepath = @"C:\PDFAPP\作業内容.pdf";
        }
    }
}
