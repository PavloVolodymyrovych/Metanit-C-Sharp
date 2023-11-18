// https://metanit.com/sharp/practice/1.3.php
//PART #1
int[,,] mas = { { { 1, 2 },{ 3, 4 } },
                { { 4, 5 }, { 6, 7 } },
                { { 7, 8 }, { 9, 10 } },
                { { 10, 11 }, { 12, 13 } }
              };
int row = mas.GetUpperBound(0)+1;
int columns  = mas.GetLength(0)/2;
Console.Write("{");
for (int i = 0; i < row; i++)
{
    Console.Write("{");
    for (int k = 0; k < columns; k++)
    {
        if (k == 1) { Console.Write(","); }
        Console.Write("{");
        
        for (int l = 0; l < columns; l++)
        {
            Console.Write(mas[i,k,l]);
            if(l == 0) { Console.Write(","); }
            
            if(l == 1) {  Console.Write("}");}
        }
    }
    if(i < row-1) { Console.Write("},"); }
    if(i == row - 1) { Console.Write("}"); }
}
Console.Write("}");
