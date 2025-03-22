//created a class in order to models the students
//all attributes are created as private in order to keep security of information.
class Student{
    private long student_id;//created number of students as long type and private.
    private string name;//created name of students as string type and private.
    private string surname;//created surname of students as string type and private.
    static List<Student>Students=new List<Student>();//created basic database as public.

//created a explicit constructor to assign the initial values of class otomatically.
    public Student(long _id,string _name,string _surname){
        student_id=_id;//student_id that entered by user and student_id that is attribute are matched.
        name=_name;//name that entered by user and name that is attribute are matched.
        surname=_surname;//surname that entered by user and surname that is attribute are matched.
    }
//created a public void function in order to register the student.
    public void Register(long student_id,string name,string surname){
           Students.Add(new Student(student_id,name,surname));//registerd the student to temporary basic database.
           Console.WriteLine("register is successfull.");
    }
//created a public static void function in order to login by registered student.
    public static void Login(long id){
        if(Students.Count==0){//controls is there any student in the list.
            Console.WriteLine("Firstly you should register.");
        }
        else{
             foreach(var student in Students){
            if(student.student_id==id){//if the id entered is available in the list
                Console.WriteLine("You are already here!!");
                return;
            }
           }
           Console.WriteLine("Login is failed.");//else there is no any registered student, print login is failed.
        }}}