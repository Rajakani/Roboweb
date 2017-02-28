namespace Roboweb.Controls
{
    public interface ITextBox: IControl
    {
        bool Type(string value);
        string Value();
    }
}