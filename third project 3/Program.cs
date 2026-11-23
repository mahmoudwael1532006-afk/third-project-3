using System;
using System.Text;
#region Q01
/*
string title = "clean code";
string upperTitle = title.ToUpper();
Console.WriteLine(title);
Console.WriteLine(upperTitle);
*/
#endregion
#region Q02
/*
string firstTitle = "clean code";
string secondTitle = "clean code";
Console.WriteLine(object.ReferenceEquals(firstTitle, secondTitle));
*/
#endregion
#region Q03
//StringBuilder sb = new StringBuilder("Book List");
//sb.Append(" - Updated");
//Console.WriteLine(sb);
#endregion
#region Q04
/*
StringBuilder sb = new StringBuilder("Book List - Updated");
sb.Replace("Book List", "Library");
Console.WriteLine(sb);
*/
#endregion
#region Q05
/*
string title = "Clean Code";
int pages = 464;
Console.WriteLine("Book: " + title + ", Pages: " + pages);
*/
#endregion
#region Q06
/*
string title = "Clean Code";
int pages = 464;
Console.WriteLine($"Book: {title}, Pages: {pages}");
*/
#endregion
#region Q07
/*
string title = "Clean Code";
int pages = 464;

Console.WriteLine(string.Format("Book: {0}, Pages: {1}", title, pages));
*/
#endregion
#region Q08
/*
int pages = 464;

if (pages > 300)
{
    Console.WriteLine("Long Book");
}
else
{
    Console.WriteLine("Short Book");
}
*/
#endregion
#region Q09
/*
int pages = 464;
bool isAvailable = true;

if(pages > 300 && isAvailable == true)
{
Console.WriteLine("You can borrow this book");
}
*/
#endregion
#region Q10
/*
string title = "Refactoring";
switch (title)
{
    case "Clean Code":
        Console.WriteLine("Great choice!");
        break;

    case "Refactoring":
        Console.WriteLine("Nice pick!");
        break;

    default:
        Console.WriteLine("Never heard of it");
        break;
}
*/
#endregion
#region Q11
/*
int pages = 464;
string sizeLabel = pages > 300 ? "Long Book" : "Short Book";
Console.WriteLine(sizeLabel);
*/
#endregion
#region Q12
/*
string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
for(int i = 0; i < books.Length; i++)
{
    Console.WriteLine($"{i + 1}. {books[i]}");
}
*/
#endregion
#region Q13
/*
string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
int i = 0;

while (i < books.Length)
{
    Console.WriteLine(books[i]);
    i++;
}
*/
#endregion
#region Q14
/*
string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
int count = 0;

do
{
    Console.WriteLine("Checking book...");
    count++;
}
while (count < 3);
*/
#endregion
#region Q15
/*
string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
foreach (string book in books)
{
    Console.WriteLine(book);
}
*/
#endregion
#region Q16
/*
string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
foreach (string book in books)
{
    if (book == "Refactoring")
    {
        break;
    }

    Console.WriteLine(book);
}
*/
#endregion
#region Q17
/*
string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
foreach (string book in books)
{
    if (book == "Refactoring")
    {
        break;
    }

    Console.WriteLine(book);
}
*/
#endregion
#region Q18
/*
string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
PrintFirstBook(books);

void PrintFirstBook(string[] books)
{
    if (books.Length == 0)
    {
        return;
    }

    Console.WriteLine(books[0]);
}
*/
#endregion