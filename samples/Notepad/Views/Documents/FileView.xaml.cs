using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using AvaloniaEdit;

namespace Notepad.Views.Documents
{
    public class FileView : UserControl
    {
        private readonly TextEditor _textEditor;

        public FileView()
        {
            this.InitializeComponent();
            _textEditor = this.FindControl<TextEditor>("Editor");
            _textEditor.ShowLineNumbers = true;
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
