using System;
class Program
{   static void Main(String[] args)
    {
        Queue<int>queue1 = new Queue<int>();
        Queue<int>queue2 = new Queue<int>();
        Queue<int>queue3 = new Queue<int>();
        char Fruit = 'a';
        while(Fruit == 'a' || Fruit == 'L'||Fruit == 'M'||Fruit == 'S')
        {
        Fruit = char.Parse(Console.ReadLine());
           CheckFruit(Fruit,queue1,queue2,queue3);
            
        }
        FetchNum(queue1,queue2,queue3);
    } 
    
    static void CheckFruit(char Fruit, Queue<int> queue1,Queue<int>queue2,Queue<int>queue3)
    {
        int L =1;
        int M = 2;
        int S = 3;
         
            if(Fruit == 'L')
            {
                queue1.Push(L);
                
                    for(int i = 0; i < 2; i++ )
                    {
                        queue2.Push(M);
                    }
                    for(int j = 0; j<6; j++)
                    {
                        queue3.Push(S);
                    }     
                
            }
            else if(Fruit == 'M')
            {
                queue1.Push(M);
                    for(int j = 0; j<3; j++)
                        {
                            queue2.Push(S);
                        }
            }
            else if(Fruit == 'S')
            {
                queue1.Push(S);
            }
    } 
    static void FetchNum(Queue<int> queue1,Queue<int>queue2,Queue<int>queue3)
    {
        for(int n = 0; n< queue1.GetLength();n++)
        {
            Console.Write("{0}",queue1.Get(n));   
        }
        for(int n = 0; n< queue2.GetLength();n++)
        {
            Console.Write("{0}",queue2.Get(n));
        }
        for(int n = 0; n< queue3.GetLength();n++)
        {
            Console.Write("{0}", queue3.Get(n));
        }
    } 
}
