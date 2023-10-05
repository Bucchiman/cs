/*
 * FileName:     file
 * Author:       8ucchiman
 * CreatedDate:  2023-09-19 13:53:00
 * LastModified: 2023-02-26 13:30:39 +0900
 * Reference:    https://github.com/gui-cs/Terminal.Gui/issues/152
 * Description:  ---
 */


using Terminal.Gui;

namespace listview_sample02 {
    public class Example02 {
        static void Main(string[] args) {
            Application.Init();
            var top = Application.Top;

            top.Add(new QueueView(), new TimeLapseView());

            // Add some controls
            Application.Run();
        }
    }
}
