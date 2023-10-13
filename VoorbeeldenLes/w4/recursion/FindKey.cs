using System;
using System.Collections.Generic;

namespace recursion
{
    public class FindKey
    {
        public int count {get;set;}
        
        public string Algorithm1(string folder){

            Queue<string> folders = new Queue<string>();
            
            folders.Enqueue(folder);

            while(folders.Count > 0){
                count++;
                folder = folders.Dequeue();

                if(Directory.GetFiles(folder).Length > 0) return folder;
                else{
                    foreach (string dir in Directory.GetDirectories(folder)){
                        folders.Enqueue(dir);
                    }
                }
            }

            return "not found";

        }

        public string Algorithm2(string folder){
            foreach(string entry in Directory.GetFileSystemEntries(folder)){
                count++;
                if(Directory.Exists(entry)){
                   string value = Algorithm2(entry);
                   if(value != "not found"){return value;}
                }
                else if(File.Exists(entry)){
                    return entry;
                }
            }

            return "not found";
        }
    }

}
