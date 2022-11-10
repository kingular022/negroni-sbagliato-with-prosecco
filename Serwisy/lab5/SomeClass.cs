namespace _20._10.Serwisy.lab5
{
    public class SomeClass
    {
        public string Print(string text)
        {
            try
            {
                return text.Length.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new InvalidDepartmentExeption("Custom s#it");
            }
        }
    }
}
