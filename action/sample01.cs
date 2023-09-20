/*
    FileName:     cs
    Author:       8ucchiman
    CreatedDate:  2023-09-19 13:53:00
    LastModified: 2023-02-26 13:30:39 +0900
    Reference:    https://www.tutorialsteacher.com/csharp/csharp-action-delegate
    Description:  ---
*/

using System;

#if true
namespace ActionSample{
    class Program_action{
        static void Main(string[] args){
            Action<int> printActionDel = ConsolePrint;
            printActionDel(10);
        }
    
        static void ConsolePrint(int i){
            Console.WriteLine(i);
        }
    }
}
#endif
#if false
namespace ActionSample{
    public delegate void Print(int val);
    class Program_delegate{
        static void ConsolePrint(int i){
            Console.WriteLine(i);
        }

        static void Main(string[] args){
            Print prnt = ConsolePrint;
            prnt(10);
        }
    }
}
#endif


/*
 * delegate void Function()
 * := Action Function
 */

