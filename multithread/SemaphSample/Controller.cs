/*
    FileName:     Program
    Author:       8ucchiman
    CreatedDate:  2023-09-25 14:12:29
    LastModified: 2023-02-26 13:30:39 +0900
    Reference:    8ucchiman.jp
    Description:  ---
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Controller{
    internal class Controller{
        public static void Main(string[] argv){
            using(Semaphore sem = new Semaphore(0, 2, "semaphore")) {
                Console.WriteLine(DateTime.Now + ": make semaphore" + "initial release: 0, max 2 release");
                Thread.Sleep(2000);
                sem.Release(2);
                Console.WriteLine(DateTime.Now + ": Ready to release two semaphore");
                Thread.Sleep(10000);
            }
            Console.ReadLine();
        }
    }
}
