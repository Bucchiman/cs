<!--
 FileName:      readme
 Author:        8ucchiman
 CreatedDate:   2023-07-27 13:18:25
 LastModified:  2023-01-25 10:56:12 +0900
 Reference:     http://hikotech.net/post-449/
 Description:   ---
-->


# How to

```csharp
    delegate void del_func(int val);            # delegateの宣言

    static void Main() {
        del_func_inst = new del_func(func1);    # delegateのインスタンスを生成
        del_func_inst += new del_func(func2);
        del_func_inst += new del_func(func3);

        del_func_inst(value);                   # delegateの実行

        return;
    }

    staic void func1(int val) {
        // codes
    }

    static void func2(int val) {
        // codes
    }

    static void func3(int val) {
        // codes
    }
```
