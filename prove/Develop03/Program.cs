using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> verses = new List<string>();

        verses.Add("O that cunning plan of the evil one! O the vainness, and the frailties, and the foolishness of men! When they are learned they think they are wise, and they hearken not unto the counsel of God, for they set it aside, supposing they know of themselves, wherefore, their wisdom is foolishness and it profiteth them not. And they shall perish.");
        verses.Add("But to be learned is good if they hearken unto the counsels of God.");
        
        Scripture scripture = new Scripture(verses);
        scripture.Display();
        
    }
}