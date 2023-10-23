using System;

namespace Module_03 
{
    public class Stack
    {
        public string[] elements; 
        public int top; 

        public Stack(int size){
            this.elements = new string[size];
            top = 0;
        }

        public void Push(string data){
            if(this.top == elements.Length) throw new Exception("Stack Overflow");
            this.elements[top] = data;
            this.top++;
        }

        public string Pop(){
            if(this.top == 0) throw new Exception("Stack UnderFlow");
            string temp = elements[this.top-1];

            elements[this.top-1] = "";

            this.top--;

            return temp;
        }
    }
}
