
//------------------------------------------------------------------------------

//  <auto-generated>
//      This code was generated by:
//        TerminalGuiDesigner v1.0.18.0
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// -----------------------------------------------------------------------------
namespace Async01 {
    using System;
    using Terminal.Gui;
    
    
    public partial class MyView : Terminal.Gui.Window {
        
        private Terminal.Gui.Button thread_button;

        private Terminal.Gui.Button count_button;

        private int _count = 0;

        private void InitializeComponent() {
            this.Width = Dim.Fill(0);
            this.Height = Dim.Fill(0);
            this.X = 0;
            this.Y = 0;
            this.Modal = false;
            this.Text = "";
            this.Border.BorderStyle = Terminal.Gui.BorderStyle.Single;
            this.Border.Effect3D = false;
            this.Border.DrawMarginFrame = true;
            this.TextAlignment = Terminal.Gui.TextAlignment.Left;
            this.Title = "Press Ctrl+Q to quit";
            this.thread_button = new Terminal.Gui.Button();
            this.thread_button.Width = 12;
            this.thread_button.X = Pos.Center() - 40;
            this.thread_button.Y = Pos.Center() + 1;
            this.thread_button.Data = "thread_button";
            this.thread_button.Text = "Thread";
            this.thread_button.TextAlignment = Terminal.Gui.TextAlignment.Centered;
            this.thread_button.IsDefault = false;
            this.Add(this.thread_button);

            this.count_button = new Terminal.Gui.Button();
            this.count_button.Width = 12;
            this.count_button.X = Pos.Center() + 40;
            this.count_button.Y = Pos.Center() + 1;
            this.count_button.Data = "count_button";
            this.count_button.Text = "Count";
            this.count_button.TextAlignment = Terminal.Gui.TextAlignment.Centered;
            this.count_button.IsDefault = false;
            this.Add(this.count_button);
        }
    }
}
