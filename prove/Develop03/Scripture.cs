using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    private List<Word> SplitTextIntoWords(string text)
    {
        return text.Split(new[] {' ', '\r', '\t'}, StringSplitOptions.RemoveEmptyEntries)
            .Select(w=> new Word(w)) .ToList();
    }
    
    public Scripture(string book, int chapter, int verse, string text)
    {
        _reference = new Reference(book, chapter, verse);
        _words = SplitTextIntoWords(text);
    }

    public Scripture(string book, int chapter, int verse, int endVerse, string text)
    {
        _reference = new Reference(book, chapter, verse, endVerse);
        _words = SplitTextIntoWords(text);
    }

    public Scripture(string scriptureString)
    {
        var parts = scriptureString.Split(": ");
        var reference = parts[0];
        var text = parts.Length > 1 ? parts[1] :string.Empty;

        var referenceParts = reference.Split(' ');
        string book = referenceParts[0];
        int chapter = int.Parse(referenceParts[1].Split(':')[0]);

        var verseInfo = referenceParts[1].Split(':')[1];
        var verseRange = verseInfo.Split('-');

        int verse = int.Parse(verseRange[0]);
        int endVerse = verseRange.Length > 1 ? int.Parse(verseRange[1]) : verse;

        _reference = new Reference(book, chapter, verse, endVerse);
        _words = SplitTextIntoWords(text);
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        List<int> availableIndices = Enumerable.Range(0, _words.Count).Where(i => !_words[i].IsHidden())
                                                                        .ToList();
        numberToHide = Math.Min(numberToHide, availableIndices.Count);                                           
        List<int> indicesToHide = availableIndices.OrderBy( x=> random.Next()).Take(numberToHide).ToList();

        foreach (var index in indicesToHide)
        {
            _words[index].Hide();
        }
    }
    public string GetDisplayText()
    {
        return $"{_reference.GetDisplayText()}: " + string.Join(" ", _words.Select(w => w.GetDisplayText()));
    }
    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}