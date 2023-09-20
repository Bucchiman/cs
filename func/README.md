<!--
 FileName:      readme
 Author:        8ucchiman
 CreatedDate:   2023-07-27 13:18:25
 LastModified:  2023-01-25 10:56:12 +0900
 Reference:     http://hikotech.net/post-449/
 Description:   ---
-->

# Motivation
- action
    - actionインスタンスに格納されたメソッドは返り値を持たない場合のみ

- func
    - 返り値ありの場合のメソッドも使えるようにした


# How to
`public delegate TResult Func<in T,out TResult>(T arg);`

```csharp
static void Main() {
    int value = 0;
    int ret;

    Func<int, int> del_func_inst = func1;     # Funcのインスタンス生成

    ret = del_func_inst(value);
}

static int func1 (int val) {
    return val + 1;
}
```


