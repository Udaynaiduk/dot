//reactangular array

int[,] num=new int[3,3];
num[0,0]=100;
num[0,1]=100;
num[0,2]=100;
int i,j;
for(i=0;i<3;i++){
    for(j=0;j<3;j++){
        
        Console.WriteLine(num[i,j]);
    }
    Console.WriteLine();
}

int[,] num1=new int[3,3]{{1,2,3},{4,5,6},{7,8,9}};
for(i=0;i<3;i++){
    for(j=0;j<3;j++){
        Console.Write(num1[i,j]+"  ");
    }
    Console.WriteLine();
}
//jagged array
 int[][] num2=new int[2][]{
    new int[] {1,2,3},new int[] {3,4,6}
 };
 foreach(int[] row in num2){
    foreach(int col in row){
        Console.Write(col);

    }
    Console.WriteLine();
 }
for(i=0;i<2;i++){
    for(j=0;j<num2[i].Length;j++){
        Console.Write(num2[i][j]+" ");
    }
    Console.WriteLine();
}
