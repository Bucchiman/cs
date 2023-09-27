/*
 * FileName:     Program
 * Author:       8ucchiman
 * CreatedDate:  2023-09-27 11:08:01
 * LastModified: 2023-02-26 13:30:39 +0900
 * Reference:    https://ufcpp.net/study/csharp/sp_delegate.html
 * Description:  ---
 */


#if false
using System;
delegate bool Predicate (int num);

namespace Exercise01{
    class Exercise01{
        static void Main(string[] argv){
            int[] array = {2, 4, 10, 22, 2, 52, 12, 9, 1, 4, 24};
            select(array, new Predicate(MoreThan10));
            select(array, new Predicate(Between5and15));

        }
        static bool MoreThan10 (int num) {
            return num > 10;
        }
        static bool Between5and15 (int num) {
            return 5 < num && num < 15;
        }

        static private void select(int[] array, Predicate predicate) {
            foreach (int num in array)
                if (predicate(num)) {
                    Console.WriteLine($"{num}");
                }
        }
    }
}
#else
using System;
delegate bool Predicate (int num);

namespace Exercise01 {
    class Exerrcise01 {
        static void Main(string[] argv) {
            int[] array = {2, 4, 10, 22, 2, 52, 12, 9, 1, 4, 24};
            select(array, new Predicate((int num) => {return num>10;}));
            select(array, new Predicate((int num) => {return 5<num && num<15;}));
        }

        static private void select(int[] array, Predicate predicate) {
            foreach (int num in array)
                if (predicate(num)) {
                    Console.WriteLine($"{num}");
                }
        }

    }
}
#endif
