using System;
class Program{
    static void Main(){
        //basic interface to use program.
        bool flag=true;//assigned boolean variable in order to control while loop.
        while(flag){
            Console.WriteLine("***WELCOME TO LOGIN SYSTEM***");
            Console.WriteLine("1. Register");
            Console.WriteLine("2. Login");
            Console.WriteLine("3. Exit");
            Console.Write("Enter the number of process that you want: ");
            int choice=int.Parse(Console.ReadLine());//determine choice from user.
           
            //query of which choice
            switch(choice){
                case 1: //if choice equals to 1.
                    Console.Write("enter student id: ");//get student_id
                    long student_id=long.Parse(Console.ReadLine());//assign the input to long variable.
                    Console.Write("enter name : ");//get name
                    string name=Console.ReadLine();//assign the input to string variable.
                    Console.Write("enter surname : ");//get surname
                    string surname=Console.ReadLine();//assign the input to string variable.
                    Student student = new Student(student_id,name,surname);//created an object by explicit constructor.
                    student.Register(student_id,name,surname);//call the Register() by object.
                    break;
                case 2://if choice equals to 2.
                    Console.Write("enter student id: ");//get student id
                    student_id=long.Parse(Console.ReadLine());//assign the input to long variable.
                    Student.Login(student_id);//call the Login() as static.
                    break;
                case 3://if choice equals to 3.
                    Console.Write("closing program...");
                    flag=false;//it is made in order to break while loop.
                    break;
                default://if choice is invalid according to processes of interface.
                    Console.WriteLine("invalid choice.Try again.");
                    break;
        }}}}
