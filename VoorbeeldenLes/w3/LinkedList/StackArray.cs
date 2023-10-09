using System;

namespace LinkedList 
{
     public class Stack
    {
        private string[] stack;
        private int top;

        public Stack(int size){
            this.stack = new string[size];
            this.top = 0;
        }        

        public void Push(string data){

            if(this.top == stack.Length) throw new Exception("Stack OverFlow");
            this.stack[top] = data;
            this.top++;
        }

        public string Pop(){
            if(this.top == 0) throw new Exception("Stack UnderFlow");

            string temp = stack[this.top-1];

            stack[this.top-1] = "";

            this.top--;

            return temp;
        }

        public override string ToString(){
            return string.Join(" | ", stack);
        }
    }
}