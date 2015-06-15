using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;


namespace SharpSort
{
    class Manager
    {
        private string dir;
        private string[] file_store;

        public string getDir()
        {
            return dir;
        }
        
        public string[] getUndo()
        {
            return file_store;
        }

        public void setDir(string newDir)
        {
            dir = newDir;
            Debug.Print("Manager dir set: " + dir);
            Directory.SetCurrentDirectory(dir);
            Debug.Print("Manager after chdir "+Directory.GetCurrentDirectory());
            file_store = Directory.GetFiles(dir);
            foreach (string item in file_store)
            {
                Debug.Print(GetMimeMapping(item));
            }
        }

        public void setUndo(string[] newUndo)
        {
            file_store = newUndo;
        }
    }
}
