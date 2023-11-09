// Exo : Display (Print) a list of students , save the data into local storage , create a excel file 
using System;
using System.Collections.Generic; // LIST 
using System.IO ; // EXTRACT INFORMATION

namespace Program;
class Student {
    // Properties (data)
    public int ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string Patronymic { get; set;}
    public double Rating { get; set; }
  

}
class Program {

    static void Main(string[] args){
        List<Student> students = new List<Student>();
        new Student { ID = 1, FirstName =  " Кадер", LastName = " Эхсан ", Patronymic= "КЭ", Rating= 4.5};
        new Student { ID = 2, FirstName =  " Умар", LastName = " Шеху Абубакар ", Patronymic= "УША", Rating= 4.5};
        new Student { ID = 3, FirstName =  " Виктор ", LastName = " Аджай ", Patronymic= "ВА", Rating= 4.5};

    // Print the list of students 

    Console.WriteLine ( " List of students : ");

    using (StreamWriter writer = new StreamWriter("students.csv")){
        
        foreach (var student in students){
            writer.WriteLine(" ID : {0}, FirstName : {1}, LastName : {2}, Patronymic : {3}, Rating : {4}", 
            student.ID, student.FirstName, student.LastName, student.Patronymic, student.Rating);
        }
    }
    // Take input from the user 
    Console.WriteLine(" Enter the details of new students");
    Console.WriteLine(" ID: ");
    int id = int.Parse(Console.ReadLine());
    Console.WriteLine(" First Name: ");
    string f_name =  Console.ReadLine();
    Console.WriteLine(" Last Name: ");
    string l_name =  Console.ReadLine();
    Console.WriteLine(" Patronymic: ");
    string patronymic =  Console.ReadLine();
    Console.WriteLine(" Rating : ");
    double rating =   double.Parse(Console.ReadLine());

    students.Add(new Student { ID = id, FirstName = f_name, LastName = l_name, Patronymic =patronymic, Rating = rating});

    // Save the data into csv file 
    using (StreamWriter writer = new StreamWriter("students.csv")){
        
        foreach (var student in students){
            writer.WriteLine(" ID : {0}, FirstName : {1}, LastName : {2}, Patronymic : {3}, Rating : {4}", 
            student.ID, student.FirstName, student.LastName, student.Patronymic, student.Rating);
        }
    }

}
}



