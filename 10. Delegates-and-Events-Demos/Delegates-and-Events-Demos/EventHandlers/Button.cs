using System;

public class Button
{
    public event EventHandler Click;
    //public event EventHandler GotFocus;
    //public event EventHandler TextChanged;

    public string text = "some text here.";

    protected void OnClick()
    {
        if (Click != null)
        {
            Click(this, new EventArgs());
        }
    }

    public void FireClick()
    {
        OnClick();
    }
}