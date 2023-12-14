using System;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;

namespace Module_03 
{
    public class Assignment
    {
        char[] bracketOptionsOpen =  {'(','[','{','<'};
        char[] bracketOptionsClose = {')',']','}','>'};

        Stack bracketsOpen = new Stack(100);
        Stack bracketsClose = new Stack(100);


        public string Balance(string input){
            foreach(char c in input){
                if(this.bracketOptionsOpen.Contains(c)){
                    this.bracketsOpen.Push(c.ToString());
                }
                else if(this.bracketOptionsClose.Contains(c)){
                    this.bracketsClose.Push(c.ToString());
                }
            }

            if(this.bracketsOpen.top == this.bracketsClose.top && checkBalanced()){
                return "Balanced expression!";
            }
            else if(this.bracketsOpen.top > this.bracketsClose.top && checkBalanced()){
                return "Too many open symbols";
            }
            else if(this.bracketsOpen.top < this.bracketsClose.top && checkBalanced()){
                return "Too many close symbols";
            }
            return "Not balanced expression";                
       }


       private bool checkBalanced(){

        bool check = true;


        while(bracketsOpen.top != bracketsClose.top){
            if(bracketsOpen.top > bracketsClose.top){
                this.bracketsOpen.Pop();
            }
            else{this.bracketsClose.Pop();};
        }

            while(bracketsOpen.top > 0 && bracketsClose.top > 0 ){
                string open = this.bracketsOpen.Pop();
                string close = this.bracketsClose.Pop();

                string opposite = "";

                switch(open){
                    case "(":
                        opposite = ")";
                        break;
                    case "[":
                        opposite = "]";
                        break;
                    case "<":
                        opposite = ">";
                        break;
                    case "{":
                        opposite = "}";
                        break;
                }

                if(close == opposite){
                    check = true;
                }
                else{
                    check = false;
                }

            }
                return check;

       }
    }
}
