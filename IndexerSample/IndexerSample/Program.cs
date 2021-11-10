using System;

namespace IndexerSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Sentence sentence = "Sink your teeth into an action-packed educational adventure.";
            Console.WriteLine(sentence.Word[0]);
            string a = "7";
            string b = "7";
            Console.WriteLine(object.ReferenceEquals(a, b));
        }
    }
    class Sentence
    {
        public Word Word;

        public Sentence(string content)
        {
            Word = new Word(content);
        }

        public static implicit operator Sentence(string str)
        {
            return new Sentence(str);
        }

}

class Word
{
    private string[] Words { get; set; }
    public Word(string text)
    {
        Words = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    }
    public string this[int i]
    {
        get
        {
            return Words[i];
        }

        set
        {
            Words[i] = value;
        }
    }
}
}
