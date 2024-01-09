using lab_2.DictionaryComponents;
using Xunit;
using XUnit;
namespace lab_2;

public class Test
{
    [Fact]
    public static void TestRootSearchNotNull()
    {
        var words = new List<Word>();
        words.Add(new Word(new List<string>(), "сон", new List<string>(), "сон"));
        var storage = new List<List<Word>>();
        storage.Add(words);
        var dictionary = new SingleRootWordsDictionary(storage);
        Assert.NotNull(dictionary.RootSearch("сон"));
        Assert.Equal(words, dictionary.RootSearch("сон"));
    }
    
    [Fact]
    public static void TestRootSearchNull()
    {
        var words = new List<Word>();
        words.Add(new Word(new List<string>(), "сон", new List<string>(), "сон"));
        var storage = new List<List<Word>>();
        storage.Add(words);
        var dictionary = new SingleRootWordsDictionary(storage);
        Assert.Null(dictionary.RootSearch("мечт"));
    }
    
    [Fact]
    public static void TestWordSearchNull()
    {
        var words = new List<Word>();
        words.Add(new Word(new List<string>(), "сон", new List<string>(), "сон"));
        var storage = new List<List<Word>>();
        storage.Add(words);
        var dictionary = new SingleRootWordsDictionary(storage);
        Assert.Null(dictionary.WordSearch("мечта"));
    }
    
    [Fact]
    public static void TestWordSearchNotNull()
    {
        var words = new List<Word>();
        words.Add(new Word(new List<string>(), "сон", new List<string>(), "сон"));
        var storage = new List<List<Word>>();
        storage.Add(words);
        var dictionary = new SingleRootWordsDictionary(storage);
        Assert.NotNull(dictionary.WordSearch("сон"));
        Assert.Equal(words,dictionary.WordSearch("сон"));
    }
}