using System;
using System.IO;

namespace Generator {
    ///DOLATER <summary>add description for class: Utillity</summary>
    public static partial class Utillity {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="SubFolder"></param>
        /// <returns></returns>
        public static String FindFolder(String SubFolder) {
            String StartFolder = Environment.CurrentDirectory;

            while (StartFolder.Length > 3) {
                String Folder = Path.Combine(StartFolder, SubFolder);

                if (Directory.Exists(Folder)) {
                    return Folder;
                }

                StartFolder = Directory.GetParent(StartFolder).FullName;
            }

            return Environment.CurrentDirectory;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="SubFolder"></param>
        /// <returns></returns>
        public static String FindParentFolder(String SubFolder) {
            String StartFolder = Environment.CurrentDirectory;

            while (StartFolder.Length > 3) {
                String Folder = Path.Combine(StartFolder, SubFolder);

                if (Directory.Exists(Folder)) {
                    return StartFolder;
                }

                StartFolder = Directory.GetParent(StartFolder).FullName;
            }

            return Environment.CurrentDirectory;
        }
    }
}
