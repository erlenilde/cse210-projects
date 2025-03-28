public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        
        _words = new List<Word>();
        
        foreach (string word in text.Split())
        {
            _words.Add(new Word(word));
        }
    }
    
    
    public void HideRandomWords(int numberToHide)
    {
        int hiddenwords = 0;

        Random random = new Random();
        
        
        while(hiddenwords < numberToHide)
        {
            int index = random.Next(0, _words.Count);
            Word word = _words[index];

            if(!word.IsHidden())
            {
                word.Hide();
                hiddenwords++;
            }
            
        }
    }

    public string GetDisplayText()
    {

        string wordbyword = "";
        foreach(Word word in _words)
        {
            wordbyword += word.GetDisplayText() + " ";
        }

        return _reference.GetDisplayText()+"\n"+wordbyword;
    }

    public bool IsCompletelyHidden()
    {
        foreach(Word word in _words)
        {
            if(!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }

}