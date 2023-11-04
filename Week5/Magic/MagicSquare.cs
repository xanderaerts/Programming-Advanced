using System;
using System.Security.Principal;

namespace Module_5 
{
    public class MagicSquare
    {
        private int size;
        public int [,] Square {get;set;}
        private int magicSum;

        public MagicSquare(int square_size){
            this.size = square_size;
            this.magicSum = (this.size * ((int)Math.Pow(this.size,2) + 1)) / 2;

            this.Square = new int[size,size];

            for(int i = 0; i < this.size; i++){
                for(int j = 0; j < this.size;j++){
                    this.Square[i,j] = 0;
                }
            }
        }

        public string Create(int row, int col, int placed){
            if(placed == this.size * this.size && isMagic()) return "true";

            for(int i = placed; i < this.size*this.size+1; i++){
                if(IsValid(i)){
                    this.Square[row-1,col-1] = i;
                    Tuple<int,int> nextPos = NextPosition(row,col);
                    int newRow = nextPos.Item1,newCol = nextPos.Item2;
                    //Console.WriteLine(this);
                    string result = Create(newRow,newCol,placed + 1);
                    if(result == "true" && isMagic()) return "true";
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
            return true;
        }

        public Tuple<int,int> NextPosition(int row, int col){
            if(row < this.size){
                row += 1;
            }
            else if(row == this.size){
                col += 1;
                row = 1;
            }
            else if(row == this.size && col == this.size){
                row = 1;
                col = 1;
            }

            return new Tuple<int,int>(row,col);

        }

        public bool isMagic(){
            bool check = true;
            int sumHorizontal = 0, sumVertical = 0, sumDiagonalLR = 0,sumDiagonalRL = 0;

            for(int i = 0; i < this.size;i++){
                for(int j = 0; j < this.size;j++){
                    sumVertical += this.Square[i,j];
                    sumHorizontal += this.Square[j,i];
                }
                if(!(sumVertical == 15) && !(sumHorizontal == 15)) check = false;
                sumVertical = 0;
                sumHorizontal = 0;

                sumDiagonalLR += this.Square[i,i];
            }

            if(!(sumDiagonalLR == 15)) check = false;

            for(int i = this.size-1, j = 0; i >= 0 && j < this.size ; i--,j++){
                sumDiagonalRL += this.Square[i,j];
            }

            if(!(sumDiagonalLR == 15)) check = false;

            if(sumHorizontal ==this.magicSum &&  sumVertical == this.magicSum && sumDiagonalLR == this.magicSum && sumDiagonalRL == this.magicSum){
                return true;
            }

            Console.Write(this);
            Console.WriteLine($"ismagic 1:{sumHorizontal} 2:{sumVertical} 3:{sumDiagonalLR} 4: {sumDiagonalRL}");

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
