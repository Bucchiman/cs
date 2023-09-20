<!--
 FileName:      readme
 Author:        8ucchiman
 CreatedDate:   2023-07-27 13:18:25
 LastModified:  2023-01-25 10:56:12 +0900
 Reference:     https://www.tutorialsteacher.com/csharp/csharp-action-delegate
 Description:   ---
-->


# Motivation
delegateより宣言が無い分、使いやすい。
- delegateのコールバック順
    1. delegateの宣言
    2. delegateのインスタンス生成
    3. delegateの実行

- actionのコールバック順
    1. Actionのインスタンス生成
    2. Actionの実行


# How to
`public delegate void Action<in T>(T obj);`

Actionを使用でいるのはAction Delegateに格納したメソッドが返り値を持たない場合のみ
```csharp
    int value = 0;

    static void Main() {
        Action<int> del_func_inst = func1;    # Actionのインスタンスを生成
        del_func_inst += func2;
        del_func_inst += func3;

        del_func_inst(value);                   # Actionの実行

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



# Methods

1. Delegate
```csharp
    public delegate void Print(int val);

    static void ConsolePrint(int i) {}

    static void Main() {
        Print prnt = ConsolePrint;
        prnt(10);
    }
```

2. Action
```csharp
    static void ConsolePrint(int i) {}

    static void Main() {
        Action<int> printActionDel = ConsolePrint;
        // or Action<int> printActionDel = new Action<int>(ConsolePrint);
        printActionDel(10);
    }
```

3. Anonymous method with Action delegate (without method)
```csharp
    static void Main () {
        Action<int> printActionDel = delegate(int i) {
            Console.WriteLine(i);
        };
        printActionDel(10);
    }
```

4. Lambda expression with Action delegate
```csharp
    static void Main () {
        Action<int> printActionDel = i => Console.WriteLine(i);
        printActionDel(10);
    }
```
