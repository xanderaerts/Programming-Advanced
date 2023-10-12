using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using System.Collections.Generic;

namespace Module_02
{
    public class Assignment
    {
        public string Space(string input){
            if(string.IsNullOrEmpty(input)) throw new Exception();

            int startTS = 4, startFragment = 18;
    
            string output="",temp;
            bool reading = true;

            string[] list = input.Split("\n");
            List<Message> outputList = new List<Message>();

            int i = 0,time;

            while(i < list.Length-1){
                temp = list[i];

                try{time = Int32.Parse(temp.Substring(startTS,1));}
                catch{throw new Exception();}

                int j = 1;
                string buffer = temp.Substring(startFragment,1),
                        mess= "";

                while(buffer.CompareTo("\"") != 0){
                    mess += buffer;
                    try{buffer = temp.Substring(startFragment + j,1);}
                    catch{throw new Exception();}
                    j++;                    
                }

                Message message = new Message(time,mess);

                if(outputList.Count > 0){
                    for(int x = 0; x < outputList.Count;x++){
                        if(message.TS < outputList[x].TS){
                            outputList.Insert(x,message);
                            break;
                        }
                    }
                }
                else{
                    outputList.Add(message);
                }
                i++;
            }

            for(int x = 0; x < outputList.Count; x++){
                if(x == 0){
                    output = outputList[x].MS;
                }
                else{
                    output += " " + outputList[x].MS;
                }

            }
            


            return output;
        }
    }

    public class Message{

        public int TS {get;set;}
        public string MS {get; set;} 

        public Message(int ts, string ms){
            this.TS = ts;
            this.MS = ms;
        }

        public override string ToString()
        {
            return this.MS;
        }
    }
}
