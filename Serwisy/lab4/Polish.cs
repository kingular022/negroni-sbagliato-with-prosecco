namespace _20._10.Serwisy.lab4
{
    public class Polish : Language, ILanguage
    {
        public Polish (string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public override string getLanguageName()
        {
            return "pl";
        }

        public string GetLanguageName()
        {
            throw new NotImplementedException();
        }
    }
}
