/*
    FileName:     Processor
    Author:       8ucchiman
    CreatedDate:  2023-09-25 14:18:58
    LastModified: 2023-02-26 13:30:39 +0900
    Reference:    https://cyzennt.co.jp/blog/2020/07/24/c%EF%BC%9A%E3%82%BB%E3%83%9E%E3%83%95%E3%82%A9%E3%82%92%E7%94%A8%E3%81%84%E3%81%9F%E6%8E%92%E4%BB%96%E5%88%B6%E5%BE%A1/
    Description:  ---
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;

namespace Processor{
    internal class Processor{
        static void Main(string[] argv){
            const int N = 3;
            Parallel.For(0, N, id => {
                Semaphore sem;
                if (Semaphore.TryOpenExisting("semaphore", out sem)) {
                    Console.WriteLine("ID" + id + ":" + DateTime.Now + ": wait for release of a semaphore");
                    sem.WaitOne();
                    Console.WriteLine("ID" + id + ":" + DateTime.Now + ": get semaphore, start running");
                    Thread.Sleep(2000);
                    Console.WriteLine("ID" + id + ":" + DateTime.Now + ": finished");
                    sem.Release();
                    Console.WriteLine("ID" + id + ":" + DateTime.Now + ": release a semaphore");
                }
                else {
                    Console.WriteLine("ID" + id + ":" + DateTime.Now + ": cannot find semaphores");
                }
            });
            Console.ReadLine();
        }
    }
}
