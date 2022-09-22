//Un-comment below code and fix the issues
//Push to github
int RecursiveFibonacci(int first, int second, int count)
{
    count--;
    
    int next = first + second;
    if(count == 0) {
     return next;   
    }else{
        
        return RecursiveFibonacci(second, next, count);
    }
}
int enternum = Convert.ToInt32(Console.ReadLine());
int lastFibo = RecursiveFibonacci(1,1,enternum);
Console.WriteLine("Last fibo number was " + lastFibo);
Console.ReadLine(); 


