
//------------------------------------------------------------------------------

//  <auto-generated>
//      This code was generated by:
//        TerminalGuiDesigner v1.0.17.0
//      You can make changes to this file and they will not be overwritten when saving.
//  </auto-generated>
// -----------------------------------------------------------------------------
namespace Sync01{
    using Terminal.Gui;
    
    
    public partial class MyView {
        
        public MyView() {
            InitializeComponent();
            count_button.Clicked += () => this.count_button.Text = _count++.ToString();
            normal_button.Clicked += () => {
                var data = GetData();
                MessageBox.Query("Done", "!");
            };
            // normal_button.Clicked += () => MessageBox.Query("Hello", "Hello There!", "Ok");
        }

        private List<DTO> GetData() {
            var result = new List<DTO> ();
            for (int i=0; i<5; i++) {
                System.Threading.Thread.Sleep(1000);
                result.Add(new DTO(i.ToString(), DateTime.Now.ToString("HH:mm:ss")));
            }
            return result;
        }

        private sealed class DTO {
            public DTO (string id, string datadate) {
                Id = id;
                DataDate = datadate;
            }

            public string Id {get; set;}
            public string DataDate {get; set;}
        }
    }
}