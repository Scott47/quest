using System;

namespace Quest
{
    public class Prize
    {
        private string _text = "You can have this crappy prize that is only text";


        public void ShowPrize(Adventurer adventurer)
        {
            if (adventurer.Awesomeness > 0)
            {
                for (int i = 0; i <= adventurer.Awesomeness; i++)
                {
                    Console.WriteLine(_text);
                }
            }
        }
    }
}