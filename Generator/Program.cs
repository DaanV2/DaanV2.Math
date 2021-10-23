using System;
using System.IO;

namespace Generator {
    public class Program {
        public static readonly String TemplateFolder = Utillity.FindFolder("Template");
        public static readonly String DestinationFolder = Utillity.FindParentFolder("DaanV2.Math");

        public static readonly String[] Types = new String[]{
            "Single",
            "Double",
            "Int16",
            "Int32",
            "Int64",
            "UInt16",
            "UInt32",
            "UInt64"
        };

        public static void Main(String[] args) {
            String[] Files = Directory.GetFiles(TemplateFolder, "*.*", SearchOption.AllDirectories);

            foreach (String template in Files) {
                Console.WriteLine(Path.GetFileName(template));
                String Content = File.ReadAllText(template);

                foreach (String T in Types) {
                    var FI = new FileInfo(template.Replace(TemplateFolder, DestinationFolder).Replace("-Type-", T));

                    FI.Directory.Create();

                    File.WriteAllText(FI.FullName, Content.Replace("%Type%", T));
                }
            }

            Console.WriteLine("==== Done ====");
            Console.ReadLine();
        }
    }
}
