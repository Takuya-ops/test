// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// var fullName = "Taro Yamada";
// Console.WriteLine(fullName);

// // 性だけ表示
// var fullName1 = "Komori Mei";
// var tokens = fullName1.Split(" ");
// var lastName = tokens[0];
// Console.WriteLine(lastName);

// FullNameクラスのFirstNameプロパティを使用
var fullName = new FullName("Takeshi", "Takagi");
Console.WriteLine(fullName.FirstName);

// classで指名を表現する場合
class FullName
{
  public FullName(string firstName5, string lastName5)
  {
    FirstName = firstName5;
    LastName = lastName5;
  }
  public string FirstName { get; }
  public string LastName { get; }
}

