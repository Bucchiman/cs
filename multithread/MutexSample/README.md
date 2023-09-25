<!--
 FileName:      readme
 Author:        8ucchiman
 CreatedDate:   2023-09-25 12:45:57
 LastModified:  2023-01-25 10:56:12 +0900
 Reference:     https://cyzennt.co.jp/blog/2020/07/04/c%ef%bc%9amutex%e3%81%a7%e3%81%ae%e6%8e%92%e4%bb%96%e5%88%b6%e5%be%a1/
 Description:   Mutexのサンプルコード
-->


```cs

           time             ID0             ID1             ID2
             |
  0.0 sec   ---------------------------------------------------               |     /
             |               | Capture ID0   |               |                .     \
             |               .               .               .                |     /
             |               |               |               |                .     \
             |               .               .               .              Sleep  Wait
             |               |               |               |
             |               . Release ID0   .               .
  0.7 sec   -----------------|-------------------------------|-
             |               .               /               .
             |               |               \ Capture ID1   |
  1.0 sec   -------------------------------------------------.-
             |                               |               |
             |                               .               .
             |                               |               |
  1.4 sec   ---------------------------------------------------
             |                               |               /
             |                               .               \
             |                               |               /
             |                               .               \
  1.9 sec    |                               |               x give up ID2
  2.0 sec   ---------------------------------------------------
             |                                Release ID1
             |
             |
             |
             |
             |
             |
             |
             v
```
