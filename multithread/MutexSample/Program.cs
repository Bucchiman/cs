/*
    FileName:     Program
    Author:       8ucchiman
    CreatedDate:  2023-09-25 11:17:40
    LastModified: 2023-02-26 13:30:39 +0900
    Reference:    https://cyzennt.co.jp/blog/2020/07/04/c%ef%bc%9amutex%e3%81%a7%e3%81%ae%e6%8e%92%e4%bb%96%e5%88%b6%e5%be%a1/
    Description:  ---
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace MutexTest{
    class Program{
        #if false
        static void Main(string[] argv){
            using (Mutex mutex = new Mutex(false)) {                   // 使い終わったらスレッド解放
                const int N = 3;
                // id0: capture 0.7sec ~ 1.7sec
                // id1: wait from 1.4sec, capture 1.7sec~2.7sec
                // id2: wait from 2.1sec, give up 2.6sec

                Parallel.For(0, N, id => {
                    Thread.Sleep(id * 700);

                    if (mutex.WaitOne(500, false)) {
                        try {
                            Console.WriteLine("Capture ID" + id);
                            Thread.Sleep(1000);
                        }
                        finally {
                            mutex.ReleaseMutex();
                            Console.WriteLine("Release ID" + id);
                        }
                    }
                    else {
                        Console.WriteLine("Cannot capture ID" + id);
                    }
                });
            }
            Console.Read();
        }
        #else
        static void Main(string[] argv) {
            using (Mutex mutex = new Mutex(false, "mutex name")) {
                System.Diagnostics.Process p = System.Diagnostics.Process.GetCurrentProcess();
                Console.WriteLine(DateTime.Now);
                Console.WriteLine("Try to capture" + p.Id);
                if (mutex.WaitOne(5000, false)) {
                    try {
                        Console.WriteLine(DateTime.Now);
                        Console.WriteLine("Capture" + p.Id);
                        Thread.Sleep(10000);
                    }
                    finally {
                        mutex.ReleaseMutex();
                        Console.WriteLine(DateTime.Now);
                        Console.WriteLine("Release" + p.Id);
                    }
                }
                else {
                    Console.WriteLine(DateTime.Now);
                    Console.WriteLine("Cannot capture" + p.Id);
                }
            }
            Console.Read();
        }
        #endif
    }
}

