using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Principal;

namespace Module_05 
{
    public class MagicSquare
    {
        public int [,] Square {get;set;}
        private int size;
        private int magicSum;

        private int currenRow; 
        private int currentCol;


        public MagicSquare(int square_size){
            this.size = square_size;
            this.magicSum = this.size * ((int)Math.Pow(this.size,2) + 1) / 2;

            this.Square = new int[size,size];

            for(int i = 0; i < this.size; i++){
                for(int j = 0; j < this.size;j++){
                    this.Square[i,j] = 0;
                }
            }
        }

        public string Create(int row, int col, int placed){

            this.currenRow = row; 
            this.currentCol = col;

            if(placed >= this.size*this.size && IsMagic()) return "true";

            for(int i = 1; i < this.size*this.size+1; i++){
                if(IsValid(i)){
                    this.Square[row-1,col-1] = i;
                    Tuple<int,int> nextPos = NextPosition(row,col);
                    int newRow = nextPos.Item1,newCol = nextPos.Item2;
                   
                    string result = Create(newRow,newCol,placed + 1);

                    if(result == "true") return "true";
                    this.Square[row-1,col-1] = 0;

                }
            }
            return "false";
        }

        public bool IsValid(int number){
            for(int i = 0; i < this.size; i++){
                for(int j = 0; j < this.size;j++){
                    if(this.Square[i,j] == number) return false;
                }
            }

            int rowSum=0, colSum=0,sumDiagonalLR=0,sumDiagonalRL=0;

            if(number < 1) return false;

            for(int i = 0; i < this.size; i++){
                rowSum += this.Square[this.currenRow-1,i];
                colSum += this.Square[i,this.currentCol-1];

                sumDiagonalLR += this.Square[i,i];
            }

            for(int i = this.size-1, j = 0; i >= 0 && j < this.size ; i--,j++){
                sumDiagonalRL += this.Square[i,j];
            }

            if(rowSum > this.magicSum) return false;
            if(colSum > this.magicSum) return false;
            if(sumDiagonalLR > this.magicSum) return false;
            if(sumDiagonalRL > this.magicSum) return false;

            return true;
        }

        public Tuple<int,int> NextPosition(int row, int col){
            if(col < this.size){
                col += 1;
            }
            else if(col == this.size && row <= this.size -1){
                row += 1;
                col = 1;
            }
            else if(row == this.size && col == this.size){
                row = 1;
                col = 1;
            }

            return new Tuple<int,int>(row,col);
        }

        public bool IsMagic(){
            bool check = true;
            int sumHorizontal = 0, sumVertical = 0, sumDiagonalLR = 0,sumDiagonalRL = 0;

            for(int i = 0; i < this.size;i++){
                for(int j = 0; j < this.size;j++){
                    sumHorizontal += this.Square[i,j];
                    sumVertical += this.Square[j,i];
                }
                if(!(sumVertical == this.magicSum) || !(sumHorizontal == this.magicSum)) check = false;
                sumVertical = 0;
                sumHorizontal = 0;

                sumDiagonalLR += this.Square[i,i];
            }

            if(sumDiagonalLR != this.magicSum) check = false;

            for(int i = this.size-1, j = 0; i >= 0 && j < this.size ; i--,j++){
                sumDiagonalRL += this.Square[i,j];
            }

            if(sumDiagonalLR != this.magicSum) check = false;

            return check;
        }

        public override string ToString()
        {
            string s = "";

            for(int i = 0; i < this.size;i++){
                for(int j = 0; j < this.size;j++){
                    s += this.Square[i,j] + " ";
                }

                s += "\n";
            }

            return s;
        }
    }
}
