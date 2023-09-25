/*
    FileName:     Program
    Author:       8ucchiman
    CreatedDate:  2023-09-25 14:12:29
    LastModified: 2023-02-26 13:30:39 +0900
    Reference:    https://cyzennt.co.jp/blog/2020/07/24/c%EF%BC%9A%E3%82%BB%E3%83%9E%E3%83%95%E3%82%A9%E3%82%92%E7%94%A8%E3%81%84%E3%81%9F%E6%8E%92%E4%BB%96%E5%88%B6%E5%BE%A1/
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
