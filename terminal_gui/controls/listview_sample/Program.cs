using listview_sample;
using Terminal.Gui;

Application.Init();

//class Demo {
    static void Edit(string filename) {
        var top = new Toplevel () {
            X = 0,
            Y = 0,
            Width = Dim.Fill(),
            Height = Dim.Fill()
        };

        var menu = new MenuBar (new MenuBarItem [] {
                new MenuBarItem ("_File", new MenuItem [] {
                        new MenuItem ("_Close", "", () => {
                                Application.RequestStop ();
                                })
                        })
                });
        var win = new Window (filename) {
            X = 0,
            Y = 1,
            Width = Dim.Fill (),
            Height = Dim.Fill () - 1
        };
        var editor = new TextView () {
            X = 0,
            Y = 0,
            Width = Dim.Fill (),
            Height = Dim.Fill ()
        };

        editor.Text = System.IO.File.ReadAllText (filename);
        win.Add (editor);

        top.Add (win, menu);
        Application.Run (top);
        // Application.Shutdown ();
    }
//}
Edit("/home/yk.iwabuchi/LightGBM_compilation.log");
