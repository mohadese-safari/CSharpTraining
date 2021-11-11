using System;

namespace IndexerSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Sentence sentence = "Sink your teeth into an action-packed educational adventure.";
            Console.WriteLine(sentence.Word[0]);
            sentence.Word[7] = "adventures.";
            string a = "7";
            string b = "7";
            Console.WriteLine(object.ReferenceEquals(a, b));
            Console.WriteLine(sentence);
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

        public override string ToString()
        {
            return Word.ToString();
        }

    }

    class Word
    {
        private string[] Words { get; set; }
        private string _contetnt;

        private bool ContentChanged { get; set; }
        public Word(string text)
        {
            Words = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            _contetnt = text;
            ContentChanged = false;
        }

        private string Content
        {
            get
            {
                if (ContentChanged)
                {
                    _contetnt = string.Join(" ", Words);
                    ContentChanged = false;
                }
                return _contetnt;
            }
        }
        public string this[int i]
        {
            get
            {
                return Words[i];
            }

            set
            {
                ContentChanged = Words[i] != value;
                Words[i] = value;
            }
        }

        public override string ToString()
        {
            return Content;
        }
    }
}
