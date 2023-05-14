/*
 * FileName:     Program
 * Author:       8ucchiman
 * CreatedDate:  2023-05-14 10:59:32
 * LastModified: 2023-01-23 14:19:10 +0900
 * Reference:    8ucchiman.jp
 * Description:  ---
 */


using System;
using System.Collections;
using System.Collections.Generic;


namespace HOGE{
    class GEHO{
        static void Main(string[] argv){
            
        }
    }

    public class File {
        private String name = null;

        public File(String name) {
            this.name = name;
        }

        public void remove() {
            Console.WriteLine(name + " was removed.");
        }
    }

    public class Directory {
        private List<Object> list = null;
        private String name = null;

        public Directory(String name) {
            this.name = name;
            list = new List<Object>();
        }

        public void add(File file) {
            this.list.Add(file);
        }

        public void add(Directory dir) {
            this.list.Add(dir);
        }

        public void remove() {
        }
    }
}

