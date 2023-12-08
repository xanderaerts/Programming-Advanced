using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace BackTracking
{
    public class NQueens
    {
        int [,] board;

        int n;

        public NQueens(int size){
            this.board = new int [size,size];
            this.n = size;
        }

        public bool Solve(int col){
            if(col >= this.n){
                return true;
            }

            for(int i = 0; i < this.n; i++){
                if(IsSave(i,col)){
                    this.board[i,col] = 1;
                    Console.WriteLine(this);
                    bool result = Solve(col + 1);
                    if(result) return true;
                    this.board[i,col] = 0;
                    Console.WriteLine(this);
                }
            }

            return false;
        }

        private bool IsSave(int row, int col){
            for(int i = 0; i < col;i++){
                if(board[row,i] == 1) return false;
            }

            for(int i = row, j = col; i >= 0 && j >= 0; i--,j--){
                if(board[i,j] == 1) return false;
            }

            for(int i = row, j = col; i < n && j >= 0; i++,j--){
                if(board[i,j] == 1) return false;
            }

            return true;
        }



        public override string ToString()
        {
            string s = "";

            for(int i = 0; i < n; i++){
                for(int j = 0; j < n; j++){
                    s += board[i,j] + " ";
                }
                s+= "\n";
            }
            return s;
        }
    }
}
/* mijn solution
        public bool PlaceQueen(int column){
            for(int i = 0; i < this.n && column < this.n; i++){
                this.board[i,column] = 1;
                if(!this.checkPlace(i,column)){
                    column++;
                    i = 0;
                   continue;
                }
            }


            return true;
        }


        public bool checkPlace(int i, int column){
            for(int j = 0; j < column + 1; j++){
                if(this.board[j,column] == 1){
                    return false;
                }
            }

            for(int j = 0; j < this.n;j++){
                if(this.board[i,j] == 1){
                    return false;

                }
            }

            return true;
        }*/