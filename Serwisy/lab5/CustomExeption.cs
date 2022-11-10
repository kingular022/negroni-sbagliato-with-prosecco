namespace _20._10.Serwisy.lab5
{
    public class InvalidDepartmentExeption : Exception
    { 
      public InvalidDepartmentExeption() : base() { } 
      public InvalidDepartmentExeption(string message) : base(message) { }
      public InvalidDepartmentExeption(string message, Exception innerException) : base(message, innerException) { }
    }
}
