using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Working_with_files_and_folders
{
    class Program
    {
        /// <summary>
        ///     This would be like for working with the directories.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string rootpath = @"C:\Users\Vikas\Desktop\Tim Corey\files";
            string[] dirs = Directory.GetDirectories(rootpath,"*",SearchOption.AllDirectories);

            foreach (string dir in dirs)
            {
                //Console.WriteLine(dir);
                
            }
            var files = Directory.GetFiles(rootpath, "*.*", SearchOption.AllDirectories);
            foreach (string file in files) 
            {
                //Console.WriteLine(file);


            }
            //___________________________________________________________________________________________
            /*
    C:\Users\Vikas\Desktop\Tim Corey\files\vik.txt
     C:\Users\Vikas\Desktop\Tim Corey\files\Files1\vik1.txt
     C:\Users\Vikas\Desktop\Tim Corey\files\Files1\vik1.xlsx
    C:\Users\Vikas\Desktop\Tim Corey\files\Files2\vik1.accdb
    C:\Users\Vikas\Desktop\Tim Corey\files\Files2\vik1.bmp
    C:\Users\Vikas\Desktop\Tim Corey\files\Files2\vik1.docx
    C:\Users\Vikas\Desktop\Tim Corey\files\Files2\vik1.pptx
    C:\Users\Vikas\Desktop\Tim Corey\files\Files2\vik1.pub
    C:\Users\Vikas\Desktop\Tim Corey\files\Files2\vik1.xlsx

 */
            foreach (string file in files)
            {
                Console.WriteLine(Path.GetFileName(file));


            }


            /*
vik.txt
vik1.txt
vik1.xlsx
vik1.accdb
vik1.bmp
vik1.docx
vik1.pptx
vik1.pub
vik1.xlsx

             
             */

            Console.ReadLine();
        }
    }
}
