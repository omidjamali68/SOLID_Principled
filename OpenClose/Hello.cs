namespace OpenClose
{
    internal class Hello
    {
        public void Say(string lang)
        {
            if (lang == "pr")
                Console.WriteLine("سلام");
            else if (lang == "fr")
                Console.WriteLine("Bonjour");
            else if (lang == "en")
                Console.WriteLine("Hi");
        }
    }
}
