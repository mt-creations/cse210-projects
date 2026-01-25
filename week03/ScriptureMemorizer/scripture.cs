public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] splitWords = text.Split(" ");
        foreach (string word in splitWords)
        {
            _words.Add(new Word(word));
        }
    }

    public Reference GetReference()
    {
        return _reference;
    }

    public List<Word> GetWords()
    {
        return _words;
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        
        List<Word> leftovers = new List<Word>();
        
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                leftovers.Add(word);
            }
        }

        int countToHide = numberToHide;

        if (leftovers.Count < countToHide)
        {
            countToHide = leftovers.Count;
        }

        for (int i = 0; i < countToHide; i++)
        {
            int index = random.Next(leftovers.Count);
            Word word = leftovers[index];
            word.Hide();
            leftovers.RemoveAt(index);
        }
    }

    public string GetDisplayText()
    {
        string result = _reference.GetDisplayText() + " - ";
        foreach (Word word in _words)
        {
            result += word.GetDisplayText() + " ";
        }
        return result.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
        }

        return true;
    }

}