using System;

public class ScriptureLibrary
{
    private Dictionary<string, string> _scriptures;
    private Random _random;

    public ScriptureLibrary()
    {
        _scriptures = new Dictionary<string, string>
        {
            {"Moses 1:39", "For behold, this is my work and my glory to bring to pass the immortality and eternal life of man."},
            {"Matthew 5:14-16", "Ye are the light of the world. A city that is set on an hill cannot be hid. Neither do men light a candle, and put it under a bushel, but on a candlestick; and it giveth light unto all that are in the house. Let your light so shine before men, that they may see your good works, and glorify your Father which is in heaven."},
            {"1Nephi 3:7", "And it came to pass that I, Nephi, said unto my father I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."},
            {"D&C 1:37-38", "Search these commandments, for they are true and faithful, and the prophecies and promises which are in them shall all be fulfilled. What I the Lord have spoken, I have spoken, and I excuse not myself; and though the heavens and the earth pass away, my word shall not pass away, but shall all be fulfilled, whether by mine own voice or by the voice of my servants, it is the same."}
        };

        _random = new Random();
    }

    public string GetRandomScripture()
    {
        int index = _random.Next(_scriptures.Count);
        var randomScripture = _scriptures.ElementAt(index);
        return $"{randomScripture.Key}: {randomScripture.Value}";
    }

    public string GetScriptureText(string book, int chapter, int verse, int endVerse)
    {
        string key = $"{book} {chapter}:{verse}";
        if (verse != endVerse)
        {
            key += $"-{endVerse}";
        }

        return _scriptures[key];
    }
}