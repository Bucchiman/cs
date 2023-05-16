<!--
 FileName:      event
 Author:        8ucchiman
 CreatedDate:   2023-05-16 10:13:28
 LastModified:  2023-01-25 10:56:12 +0900
 Reference:     https://csharp.keicode.com/basic/events-basic.php
 Description:   ---
-->


# Concept
`イベント発生待ち受けとイベント処理を分ける`
`イベント処理(ハンドラ)`


```cs
    using System;


    class MyEventArgs {
        public int x {get; set;}
        public int y {get; set;}

        public MyEventArgs(int x, int y) {
            this.x = x;
            this.y = y;
        }
    }

    class MyButton {
        public event EventHandler<MyEventArgs> ClickHandler;

        public void Click() {
            # var r = new Random();
            # var x = r.Next(100);
            # var y = r.Next(100);

            if (ClickHandler != null) {
                var args = new MyEventArgs(x, y):
                ClickHandler(this, args);
            }
        }
    }

    class Program {
        static void Main(string[] args) {
            var button = new MyButton();
            button.ClickHandler += OnClick;
            button.Click();
        }

        static void OnClick(object sender, MyEventArgs args) {
            Console.WriteLine($"OnClick: ({args.x}, {args.y})");
        }
    }
```

```
    +---------------------------------------+
    |  # Button class                       |
    |     クリック用のイベントハンドラ作成  |
    |     - Click method                    |
    |                                       |
    |                                       |
    |                                       |
    +---------------------------------------+

```
