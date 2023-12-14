namespace lab_2.DictionaryComponents;

public record Word
{
    public Word(IList<string> prefix, string root, IList<string> postfix, string fullWord)
    {
        this.Prefix = prefix;
        Root = root;
        this.Postfix = postfix;
        this.fullWord = fullWord;
    }

    public IList<string> Prefix { get; }
    public string Root { get; }
    public IList<string> Postfix { get; }
    
    public string fullWord { get; }
}