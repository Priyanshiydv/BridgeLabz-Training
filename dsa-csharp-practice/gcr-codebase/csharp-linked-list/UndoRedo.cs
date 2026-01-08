using System;

class TextNode
{
    public string Text;
    public TextNode Prev;
    public TextNode Next;

    public TextNode(string text)
    {
        Text = text;
    }
}

class TextEditor
{
    private TextNode current;

    public void AddState(string text)
    {
        TextNode node = new TextNode(text);

        if (current != null)
        {
            current.Next = node;
            node.Prev = current;
        }
        current = node;
    }

    public void Undo()
    {
        if (current != null && current.Prev != null)
        {
            current = current.Prev;
            Console.WriteLine("Undo: " + current.Text);
        }
    }

    public void Redo()
    {
        if (current != null && current.Next != null)
        {
            current = current.Next;
            Console.WriteLine("Redo: " + current.Text);
        }
    }

    public void Show()
    {
        if (current != null)
            Console.WriteLine("Current Text: " + current.Text);
    }
}

class Program
{
    static void Main()
    {
        TextEditor te = new TextEditor();

        te.AddState("Hello");
        te.AddState("Hello World");
        te.AddState("Hello World!");

        te.Undo();
        te.Redo();
        te.Show();
    }
}
