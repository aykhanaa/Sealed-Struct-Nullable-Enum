


using Sealed_Struct_Nullable_Enum_AcademyWork;

 //Book book = new Book();

//book.Name = "sdasd";

//Console.WriteLine(book.Name);

//int num = 5;

//Class1 class1 = new Class1();

//class1.MyProperty = 100;

//Console.WriteLine(class1.MyProperty);

string name = null;

//int? num = null;


//Console.WriteLine(book.Id); 

//if(book.Id == null)
//{
//    Console.WriteLine("Book id notfount");
////}

//Book book1 = new Book()
//{
//    Id = 1,
//    Name = "Isgendername",
//    Author = new Author() { /*Name = "Nizami",*/Id =2}
//};

//Book book2 = new Book()
//{
//    Id = 2,
//    Name = "Xosrov ve Shirin"
//};


//Console.WriteLine("asdasd");

//Console.WriteLine("Book:"+ book2.Name +" Autor: " + book2.Author?.Name?.Substring(1,3,5));

//string data = null;

//data.Substring(1, 5);

//Book[] books = { book1, book2 };

//void GetBookById(Book[] books, int? id= null)
//{
//    //Console.WriteLine(id == null);
//    if (id == null)
//    {
//        Console.WriteLine("Your id is null");
//        return;
//    }

//    Book result = books.FirstOrDefault(m=> m.Id == id);
//    Console.WriteLine(result.Name);



//}


//GetBookById(books,5);

//Level level = Level.Low;
//Console.WriteLine((int)level==1);

void GetLevel(string level)
{
    switch (levelNum)
    {
        case nameof(Level.Low):
            Console.WriteLine("Low");
            break;
        case nameof(Level.Medium):
            Console.WriteLine("Medium");
            break;
        case nameof(Level.High):
            Console.WriteLine("High");
            break;
        default:
            Console.WriteLine("empty");
            break;
    }
}
GetLevel("mvnnkkbwknbnk");