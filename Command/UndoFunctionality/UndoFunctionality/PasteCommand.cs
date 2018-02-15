namespace UndoFunctionality
{
    class PasteCommand : Command
    {
        private string _pasteText;
        public override void Execute()
        {
            var clipboardText = MockClipboard.Text;
            if (clipboardText.Length > 0)
            {
                MockTextField.Text += clipboardText;
                _pasteText = clipboardText;
            }
        }

        public override void Unexecute()
        {
            MockTextField.Text = MockTextField.Text.Substring(0, MockTextField.Text.Length - _pasteText.Length);
        }
    }
}
