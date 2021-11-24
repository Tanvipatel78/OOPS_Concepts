using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concepts
{
    
    class Program
    {
        #region Access modifiers description
        //Modifier Description
        // public :    public : There are no restrictions on accessing public members.
        // private :   private  Access is limited to within the class definition. This is the default access modifier type if none is formally specified
        // Protected:  protected Access is limited to within the class definition and any class that inherits from the class
        // internal :  internal Access is limited exclusively to classes defined within the current project assembly
        // Protected internal :  protected internal Access is limited to the current assembly and types derived from the containing class. All members in current project and all members in derived class can access the variables.
        // Private protected :  private protected Access is limited to the containing class or types derived from the containing class within the current assembly. 
        #endregion

        #region Encapsulation example
        private string Name;
        private int Age;
        public void SetName(string Name)
        {
            if(string.IsNullOrEmpty(Name)==true)
            {
                Console.WriteLine("Name is required");
            }
            else
            {
                this.Name = Name;
            }
        }
        public void getName()
        {
            if (string.IsNullOrEmpty(this.Name) == true)
            {

            }
            else
            {
                Console.WriteLine("Your name is :" + this.Name);
            }
        }
        public void SetAge(int Age)
        {
            if(Age >0)
            {
                this.Age = Age;
            }
            else
            {
                Console.WriteLine("age should not be negative or zero");
            }
        }
        public void getAge()
        {
            if (Age > 0)
            {
                Console.WriteLine("Your Age is :" + this.Age);
            }
            else
            {

            }
        }

        class Person
        {
            static void Main(string[] args)
            {
                Program p = new Program();
                p.SetName("Tanvi");
                p.getName();
                p.SetAge(-20);
                p.getAge();
                Console.ReadLine();
            }
        } 
        #endregion

        #region Static and instance member
        //    public int RollNo;
        //    public string FirstName;
        //    public string LastName;
        //    public int Class;
        //    public static string School = "Shraddha Vidhya Mandir";
        //    public static int Fees = 40000;

        //    public void FullName()
        //    {
        //        //This method is Instance method.
        //        // we can access both instance variable and static variable also.
        //        string FullName = this.FirstName + " " + this.LastName;
        //        Console.WriteLine("Your Full Name is {0}", FullName);
        //        Console.WriteLine(School);
        //    }
        //    public static int GetFees()
        //    {
        //        //In static method we can only access static variables.
        //        // we can't use instance variable in static method.
        //        //If we access the static method or static variable through the class name only.
        //        // we can't create object in static method.
        //        return Fees;
        //    }
        //    public static int GetFeesAnnualIncrement()
        //    {
        //        return Fees / 10;
        //    }
        //    public static int GetFeesAnnualIncrement(int Fee)
        //    {
        //        return Fee / 10;
        //    }
        //}
        //class Program
        //{
        //    static void Main(string[] args)
        //    {
        //        Student s1 = new Student();
        //        s1.RollNo = 20;
        //        s1.FirstName = "Tanvi";
        //        s1.LastName = "Bhut";
        //        s1.Class = 10;
        //        Student s2 = new Student();
        //        s2.RollNo = 23;
        //        s2.FirstName = "Krupa";
        //        s2.LastName = "Patel";
        //        s2.Class = 16;
        //        Console.WriteLine(s1.RollNo);
        //        Console.WriteLine(s1.FirstName);
        //        Console.WriteLine(s1.LastName);
        //        Console.WriteLine(s1.Class);
        //        s1.FullName();
        //        Console.WriteLine(Student.School);
        //        Console.WriteLine("------------");
        //        Console.WriteLine(s2.RollNo);
        //        Console.WriteLine(s2.FirstName);
        //        Console.WriteLine(s2.LastName);
        //        Console.WriteLine(s2.Class);
        //        s2.FullName();
        //        Console.WriteLine(Student.School);
        //        Console.WriteLine(Student.GetFees());
        //        Console.WriteLine(Student.GetFeesAnnualIncrement());
        //        Console.WriteLine(Student.GetFeesAnnualIncrement(30000));
        //        Console.ReadLine();
        //    } 
        #endregion

        #region static class

        // classes that cannot be inherited are known as static classes.
        // static keyword is used before the class name that consistes of static data members and static methods.
        // It is not possible to create instance of a static class using the new keyword.
        // They can only contain ststic members.
        // they  cannot be inherited and cannot contain instance constructors.
        // However , the developer can create static constructors to initialize the static members.


        #endregion

        #region Function Overloading

        //    class funOverload
        //    {
        //        public string name;

        //        //overloaded functions
        //        public void setName(string last)
        //        {
        //            name = last;
        //            Console.WriteLine(name);
        //        }

        //        public void setName(string first, string last)
        //        {
        //            name = first + "" + last;
        //            Console.WriteLine(name);
        //        }

        //        public void setName(string first, string middle, string last)
        //        {
        //            name = first + "" + middle + "" + last;
        //            Console.WriteLine(name);
        //        }

        //        //Entry point
        //        static void Main(string[] args)
        //        {
        //            funOverload obj = new funOverload();

        //            obj.setName("barack");
        //            obj.setName("barack ", " obama ");
        //            obj.setName("barack ", "hussian", "obama");
        //            Console.ReadKey();
        //        }
        //    }
        //}
        #endregion

        #region Polymorphism

        //// Poly(many) + morphism (behaviour) -> One person many roles
        //// 2 types :- 1. Compile time : Method overloading
        ////            2. Run time : Method overriding

        //// 1. Method Overloading :- We can have multiple methods of same name in a class and it is compile time polymorphisam.

        //// Conditions : a) All methods should have same name. 
        ////              b) All methods should be in same class.
        ////              c) But methods should have diff parameters -> diff type of parameters or diff number of parameters or diff sequence of parameters

        //    void Sum(int a, int b) // diff type
        //    {
        //        Console.WriteLine(a + b);
        //    }

        //    void Sum(float a, float b) // diff type
        //    {
        //        Console.WriteLine(a + b);
        //    }

        //    void Sub(int a) // diff number
        //    {
        //        Console.WriteLine(a);
        //    }

        //    void Sub(int a, int b) // diff number
        //    {
        //        Console.WriteLine(a - b);
        //    }

        //    void Mul(int a, float b) // diff sequence
        //    {
        //        Console.WriteLine(a * b);
        //    }

        //    void Mul(float a, int b) // diff sequence
        //    {
        //        Console.WriteLine(a * b);
        //    }


        //    static void Main(string[] args)
        //    {
        //        Program obj = new Program();
        //        obj.Sum(2, 3); // diff type
        //        obj.Sum(2.3f, 3.4f); // diff type
        //        obj.Sub(2); // diff number
        //        obj.Sub(3, 2); // diff number
        //        obj.Mul(3, 1.2f); // diff sequence
        //        obj.Mul(1.2f, 3); // diff sequence
        //        Console.ReadKey();

        //    }

        //// 2. Method Over-riding :- We can override the method of parent class with same method of child class and it is runtime polymorphisam.
        //// Conditions : a) All methods should have same name. 
        ////              b) All methods should be in diff class.
        ////              c) But have method should have same parameters with same type,number & sequence
        ////              d) There should be inheritance between classes

        //class Animal
        //{
        //    public virtual void Eat()
        //    {
        //        Console.WriteLine("Animal is eating");
        //    }
        //}

        //class Dog : Animal
        //{
        //    public override void Eat()
        //    {
        //        Console.WriteLine("Dog is eating"); // here overiding is taking place as Animal's eat method is replaced by Dog's eat method.
        //        //base.Eat(); // to print both the method in method ovverriding.
        //    }

        //    public static void Main(string[] args)
        //    {
        //        Dog obj = new Dog();
        //        obj.Eat();
        //        obj = new Dog();
        //        obj.Eat();

        //        //Animal obj;
        //        //obj = new Animal();
        //        //obj.Eat(); //it will print animal is eating
        //        Console.ReadKey();
        //    }
        //}
        #endregion

        #region Encapsulation

        // Hiding of data or Wrapping the data (variables) and code acting on data (methods) together as a single unit.

        //class Account
        //{
        //    int accountBalance = 1000; // Here by default the variable is private means it can only be accessed if it is accessed through public method

        //    //public void SetBalance(int amount) // here we don't need to make whole method like this in c sharp we can directly call get & set as below 
        //    //{
        //    //    if (amount < 0)
        //    //    {
        //    //        Console.WriteLine("You cannot pass negative value");
        //    //    }
        //    //    else
        //    //    {
        //    //        accountBalance = amount;
        //    //    }
        //    //}

        //    //public void GetBalance()
        //    //{
        //    //    Console.WriteLine("Your account balance is :" + accountBalance);
        //    //}

        //    public int Balance
        //    {
        //        set
        //        {
        //            if (value < 0)
        //            {
        //                Console.WriteLine("You cannot pass negative value");
        //            }
        //            else
        //            {
        //                accountBalance = value;
        //            }
        //        }

        //        get
        //        {
        //            return accountBalance;
        //        }
        //    }


        //}

        //static void Main(string[] args)
        //{
        //    Account obj = new Account();
        //        //obj.SetBalance(-10000);
        //        //obj.GetBalance();

        //        obj.Balance = 10000; // here if we only keep set method then it will be just write only method we can't view it
        //        Console.WriteLine("Your account balance is :" + obj.Balance); // here if we only keep get method then it will be just read only method we can't write it

        //        Console.ReadKey();
        //}

        #endregion

        #region Abstraction

        //public int EmpId;
        //public string EmpName;
        //public double Grosspay;
        //double taxdeduction = 0.1;
        //double Netsalary;

        //public Program(int Eid, string Ename, double Egrosspay)
        //{
        //    this.EmpId = Eid;
        //    this.EmpName = Ename;
        //    this.Grosspay = Egrosspay;
        //}

        //void CalculateSalary() //by default it is private
        //{
        //    if (Grosspay >= 20000)
        //    {
        //        Netsalary = Grosspay - (taxdeduction * Grosspay);
        //        Console.WriteLine("Your Salary is :{0} ", Netsalary);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Your Salary is :{0} ", Grosspay); // It is called Placeholder syntax in place of {0}(placeholder) it display the grosspay amount..
        //    }
        //}
        //public void ShowEmployeeDetails()
        //{
        //    Console.WriteLine("Employee id is :" + this.EmpId);
        //    Console.WriteLine("Employee Name is :" + this.EmpName);
        //    this.CalculateSalary();
        //}

        //class students
        //{
        //    static void Main(string[] args)
        //    {
        //        Program st = new Program(1, "Tanvi", 25000);
        //        st.ShowEmployeeDetails();
        //        Console.ReadLine();
        //    }
        //}
        #endregion

        #region virtual and ovveride
        //class Vehicle
        //{
        //    public double distance = 0.0;
        //    public double hour = 0.0;
        //    public double fuel = 0.0;

        //    public Vehicle(double distance, double hour, double fuel)
        //    {
        //        this.distance = distance;
        //        this.hour = hour;
        //        this.fuel = fuel;
        //    }

        //    public void Average()
        //    {
        //        double average = 0.0;
        //        average = distance / fuel;
        //        Console.WriteLine("Vehicle Average is {0:0.00}", average);
        //    }

        //    public virtual void Speed()
        //    {
        //        double speed = 0.0;
        //        speed = distance / hour;
        //        Console.WriteLine("Vehicle Speed is {0:0.00}", speed);
        //    }
        //}

        //class Car : Vehicle
        //{
        //    public Car(double distance, double hour, double fuel)
        //        : base(distance, hour, fuel)
        //    {
        //    }
        //    public void Average()
        //    {
        //        double average = 0.0;
        //        average = distance / fuel;
        //        Console.WriteLine("Car Average is {0:0.00}", average);
        //    }

        //    public override void Speed()
        //    {
        //        double speed = 0.0;
        //        speed = distance / hour;
        //        Console.WriteLine("Car Speed is {0:0.00}", speed);
        //    }
        //}

        //class Programs
        //{
        //    static void Main(string[] args)
        //    {
        //        double distance, hour, fuel = 0.0;
        //        Console.WriteLine("Enter the Distance");
        //        distance = Double.Parse(Console.ReadLine());
        //        Console.WriteLine("Enter the Hours");
        //        hour = Double.Parse(Console.ReadLine());
        //        Console.WriteLine("Enter the Fuel");
        //        fuel = Double.Parse(Console.ReadLine());
        //        Car objCar = new Car(distance, hour, fuel);
        //        Vehicle objVeh = objCar;
        //        objCar.Average();
        //        objVeh.Average();
        //        objCar.Speed();
        //        objVeh.Speed();
        //        Console.Read();
        //    }
        //} 
        #endregion

        #region Constructor

        //int Emp_ID;
        //string Emp_Name;
        //int Emp_Salary;
        //public Student() //default constructor
        //{
        //    Console.WriteLine("constructor invoke !!");
        //}
        //public Student(int Emp_ID, string Emp_Name, int Emp_Salary) //Parametrized Constructor
        //{
        //    this.Emp_ID = Emp_ID;
        //    this.Emp_Name = Emp_Name;
        //    this.Emp_Salary = Emp_Salary;
        //}
        //public int GetEmp_ID()
        //{
        //    return this.Emp_ID;
        //}
        //public string GetEmp_Name()
        //{
        //    return this.Emp_Name;
        //}
        //public int GetEmp_Salary()
        //{
        //    return this.Emp_Salary;
        //}
        //static void Main(string[] args)
        //{
        //    Student s = new Student();  //object for default constructor
        //    Student objtemp1 = new Student(1, "Tanvi", 200000);
        //    Student objtemp2 = new Student(2, "krupa", 300000);
        //    Console.WriteLine("Employee ID is {0}", objtemp1.GetEmp_ID());
        //    Console.WriteLine("Employee Name is {0}", objtemp1.GetEmp_Name());
        //    Console.WriteLine("Employee Salary is {0}", objtemp1.GetEmp_Salary());
        //    Console.WriteLine("------------------");
        //    Console.WriteLine("Employee ID is {0}", objtemp2.GetEmp_ID());
        //    Console.WriteLine("Employee Name is {0}", objtemp2.GetEmp_Name());
        //    Console.WriteLine("Employee Salary is {0}", objtemp2.GetEmp_Salary());

        //    Console.ReadLine();
        //} 
        #endregion

        #region Copy Constructor
        //        int eid, age;
        //        string address, name;
        //        public Student()
        //        {
        //            Console.WriteLine("ENTER EMPLOYEE DETAILS");
        //            Console.WriteLine("Enter the employee id");
        //            this.eid = int.Parse(Console.ReadLine());
        //            Console.WriteLine("Enter the employee age");
        //            this.age = int.Parse(Console.ReadLine());
        //            Console.WriteLine("Enter the employee name");
        //            this.name = Console.ReadLine();
        //            Console.WriteLine("Enter the employee address:");
        //            this.address = Console.ReadLine();
        //        }
        //        public Student(Student tempobj)
        //        {
        //            this.eid = tempobj.eid;
        //            this.age = tempobj.age;
        //            this.name = tempobj.name;
        //            this.address = tempobj.address;
        //        }
        //        public void Display()
        //        {
        //            Console.WriteLine();
        //            Console.WriteLine("Employee id is:  " + this.eid);
        //            Console.WriteLine("Employee name is:  " + this.name);
        //            Console.WriteLine("Employee age is:  " + this.age);
        //            Console.WriteLine("Employee address is:  " + this.address);
        //        }

        //        class Test
        //        {
        //            static void Main(string[] args)
        //            {
        //                Student tempobj = new Student();
        //                Student e2 = new Student(tempobj);
        //                tempobj.Display();
        //                e2.Display();
        //                Console.ReadKey();
        //            }
        //        }
        //    }
        //}


        #endregion

        #region static constructor

        // static constructor does not take any parameter and does not use any access modifiers.
        //static constructor is called before instance constructor.
        // static constuctor called only once no matter how many object's you create. 
        // only one static constructor can be created in a class.
        // It is called automatically before the first instance of the class created.
        // we cant call static constructor directly.

        //        public static string PersonName;
        //        public static int PersonAge;

        //        static Student()
        //        {
        //            PersonName = "Tanvi";
        //            PersonAge = 20;
        //            Console.WriteLine("Static constructor invoked !!");
        //        }
        //        public Student()
        //        {
        //            Console.WriteLine("Default constructor invoked!!");
        //        }
        //        public static void GetDetails()
        //        {
        //            Console.WriteLine("Person Name is {0}", PersonName);
        //            Console.WriteLine("Person Name is {0}", PersonAge);
        //        }
        //        class program
        //        {
        //            static void Main(string[] args)
        //            {
        //                Student s1 = new Student();
        //                Console.ReadLine();
        //            }
        //        }
        //    }
        //}
        #endregion

        #region Private Constructor

        // when a constuctor is created with a private specifier , it is not possible for other class to derive from this class, neither it is possible to create an instance of this class.
        // one use of a private constructor is when we have only one static member.
        //In the presence of parameterless private constructor you can not create a default constructor.
        //We can not inherit the class in which we have a private constructor .
        //we can have parameters in private constructor.

        //public class Counter
        //{
        //    private Counter() { }

        //    public static int currentCount;

        //    public static int IncrementCount()
        //    {
        //        return ++currentCount;
        //    }
        //}

        //class TestCounter
        //{
        //    static void Main()
        //    {
        //        // If you uncomment the following statement, it will generate
        //        // an error because the constructor is inaccessible:
        //        // Counter aCounter = new Counter();   // Error

        //        Counter.currentCount = 100;
        //        Counter.IncrementCount();
        //        Console.WriteLine("New count: {0}", Counter.currentCount);

        //        // Keep the console window open in debug mode.
        //        Console.WriteLine("Press any key to exit.");
        //        Console.ReadKey();
        //    }
        //}


        #endregion

        #region Constructor Overloading

        //public Student() //default constructor
        //{
        //    Console.WriteLine("This is my first constructor !!");
        //}
        //public Student(int a , int b)
        //{
        //    Console.WriteLine("This is my second constructor !! {0}", (a+b));
        //}
        //public Student(string a, string b)
        //{
        //    Console.WriteLine("This is my fourth constructor !! {0}", (a + b));
        //}
        //public Student(int a , int b , int c) 
        //{
        //    Console.WriteLine("This is my third constructor !! {0}",(a+b+c));
        //}
        //static void Main(string[] args)
        //{
        //    //constuctor overloading
        //    Student s = new Student();
        //    Student s1 = new Student(20, 30);
        //    Student s2 = new Student(10, 20, 30);
        //    Student s3 = new Student("Tanvi", "Patel");
        //    Console.ReadLine();
        //}

        #endregion

        #region characteristics of deconstructor

        // Characteristics of  Destructor
        //Destructors(~) cannot be defined in Structs.
        //Destructors (~) are only used with classes.
        //Destructor cannot be inherited or overloaded.
        //Destructor does not take modifiers or have parameters.
        //Destructor cannot be called. They are invoked automatically.
        //An instance becomes eligible for destruction when it is no longer possible for any code to use the instance.
        //The Programmer has no control over when destructor is called because this is determined by Garbage Collector.
        //Destructor is called when program exits.
        //Execution of the destructor for the instance may occur at any time after the instance becomes eligible for destruction.//Destructor implicitly calls Finalize on the base class of object.

        #endregion

        #region DeConstructor
        //public string Name;
        //public int Age;

        //Student(string Name , int Age)
        //{
        //    this.Name = Name;
        //    this.Age = Age;
        //}
        //public string getName()
        //{
        //    return this.Name;
        //}
        //public int getAge()
        //{
        //    return this.Age;
        //}
        //~Student()
        //{
        //    Console.WriteLine("Destuctor has been Invoked!!");
        //}

        //class program
        //{
        //    static void Main(string[] args)
        //    {
        //        Student s = new Student("Tanvi",20);
        //        Console.WriteLine(s.getName());
        //        Console.WriteLine(s.getAge());
        //        //Console.ReadLine();
        //    }
        //}

        #endregion

        #region Example of deconstructor
        //class First
        //{
        //    ~First()
        //    {
        //        System.Console.WriteLine("First's destructor is called");
        //    }
        //}
        //class Second : First
        //{
        //    ~Second()
        //    {
        //        System.Console.WriteLine("Second's destructor is called");
        //    }
        //}
        //class Third : Second
        //{
        //    ~Third()
        //    {
        //        System.Console.WriteLine("Third's destructor is called");
        //    }
        //}
        //class TestDestructors
        //{
        //    static void Main()
        //    {
        //        Third t = new Third();
        //    }
        //}
        #endregion

        #region Single level Inheritance
        // When one class inherits another class, it is known as single level inheritance. 

        //public class Employee // Example of Data Members
        //{
        //    public float salary = 40000;
        //}

        //public class Programmer : Employee // Example of Data Members
        //{
        //    public float bonus = 10000;
        //}

        //public class Animal // Example of Functions
        //{
        //    public void eat()
        //    {
        //        Console.WriteLine("Eating...");
        //    }
        //}

        //public class Dog : Animal // Example of Functions
        //{
        //    public void bark()
        //    {
        //        Console.WriteLine("Barking...");
        //    }
        //}

        //class TestInheritance
        //{
        //    public static void Main(string[] args)
        //    {
        //        Programmer p1 = new Programmer(); // Example of Data Members
        //        Console.WriteLine("Salary: " + p1.salary);
        //        Console.WriteLine("Bonus: " + p1.bonus);

        //        Dog d1 = new Dog(); // Example of Functions
        //        d1.eat();
        //        d1.bark();

        //        Console.ReadKey();
        //    }
        //}
        #endregion

        #region Multi Level Inheritance

        //// When one class inherits another class which is further inherited by another class, it is known as multi level inheritance in C#. 
        ////Inheritance is transitive so the last derived class acquires all the members of all its base classes.

        //public class Animal // Parent class of Dog
        //{
        //    public void eat() { Console.WriteLine("Eating..."); }
        //}
        //public class Dog : Animal // Child class of Animal & Parent Class of BabyDog
        //{
        //    public void bark() { Console.WriteLine("Barking..."); }
        //}
        //public class BabyDog : Dog // Child class of Dog
        //{
        //    public void weep() { Console.WriteLine("Weeping..."); }
        //}
        //class TestInheritance2
        //{
        //    public static void Main(string[] args)
        //    {
        //        BabyDog d1 = new BabyDog(); // Here BabyDog can inherit properties of Animal as well as Dog classes
        //        d1.eat();
        //        d1.bark();
        //        d1.weep();

        //        Console.ReadKey();
        //    }
        //}
        #endregion

        #region Hierarchical Inheritance

        // This is the type of inheritance in which there are multiple classes derived from one base class.
        // This type of inheritance is used when there is a requirement of one class feature that is needed in multiple classes.


        //public class Parent
        //{
        //    public void DisplayParentsAB()
        //    {
        //        Console.WriteLine("A and B are my parents");
        //    }
        //}

        //public class ChildC : Parent
        //{

        //    public void DisplayChildC()
        //    {
        //        Console.WriteLine("I am the child C");
        //    }
        //}

        //public class ChildD : Parent
        //{
        //    public void DisplayChildD()
        //    {
        //        Console.WriteLine("I am the child D");
        //    }
        //}

        //public class TestInheritance3
        //{
        //    public static void Main(string[] args)
        //    {
        //        ChildC cc = new ChildC();
        //        ChildD cd = new ChildD();

        //        cc.DisplayChildC();
        //        cc.DisplayParentsAB();  // accessing parent class

        //        cd.DisplayChildD();
        //        cd.DisplayParentsAB();   // accessing parent class

        //        Console.ReadKey();
        //    }
        //}
        #endregion

        #region Multiple Inheritance
        // In this type of inheritance, a class inherits another derived/child class which in turn inherits another class.
        // It's like a child inherits the traits of his/her parents, and parents inherit the traits of their grandparents.


        //    public class Grandparent
        //    {
        //        public Grandparent()
        //        {
        //            Console.WriteLine("Constructor called at run-time");
        //        }
        //        public void DisplayGrandParentsAB()
        //        {
        //            Console.WriteLine("A and B are my grandparents");
        //        }
        //    }

        //    public class Parents : Grandparent
        //    {
        //        public void DisplayParentsCD()
        //        {
        //            Console.WriteLine("C and D are my parents");
        //        }
        //    }

        //    public class Child : Parents
        //    {
        //        public void DisplayChildZ()
        //        {
        //            Console.WriteLine("I am the child Z");
        //        }
        //    }

        //    public class TestInheritance4
        //    {
        //        public static void Main(string[] args)
        //        {
        //            Child cd = new Child();
        //            cd.DisplayChildZ();
        //            cd.DisplayParentsCD();
        //            cd.DisplayGrandParentsAB();
        //            Console.ReadLine();
        //        }
        //    }
        //}
        #endregion

        #region Abstraction
        //class program
        //{
        //    abstract class animal
        //    {
        //        public abstract void eat();
        //        public void sound()
        //        {
        //            Console.WriteLine("dog can sound");
        //        }
        //    }
        //    class dog : animal
        //    {
        //        public override void eat()
        //        {
        //            Console.WriteLine("dog can eat");
        //        }
        //    }
        //    static void Main(string[] args)
        //    {
        //        dog mydog = new dog();
        //        animal thePet = mydog;
        //        thePet.eat();
        //        mydog.sound();
        //        Console.ReadLine();
        //    }
        //}
        #endregion

        #region Abstract Class

        //Note for abstract class : we can not create the object of abstract class.
        //                          abstract class is used for commomn attibute like for example i have two class one is student and another is employee. Student class is contain the is , name and age and employee class also contain the id , name and age then we have to put that common property in one abstract class.
        // Abstract class
        //    abstract class Animal
        //    {
        //        // Abstract method (does not have a body)
        //        public abstract void animalSound();
        //        // Regular method
        //        public void sleep()
        //        {
        //            Console.WriteLine("Zzz");
        //        }
        //    }

        //    // Derived class (inherit from Animal)
        //    class Pig : Animal
        //    {
        //        public override void animalSound()
        //        {
        //            // The body of animalSound() is provided here
        //            Console.WriteLine("The pig says: wee wee");
        //        }
        //    }

        //    class Program
        //    {
        //        static void Main(string[] args)
        //        {
        //            Pig myPig = new Pig();  // Create a Pig object
        //            myPig.animalSound();
        //            myPig.sleep();
        //        }
        //    }
        //}
        #endregion

        #region Constructor in Inheritance
        //class BaseClass
        //{
        //    public BaseClass() // Default Constructor of Base Class
        //    {
        //        Console.WriteLine("This is Constructor of Base Class");
        //    }
        //}

        //class DerivedClass : BaseClass
        //{
        //    public DerivedClass() : base() // Default Constructor of Derived Class
        //                                   // Here it does'nt matter if we include base() or not as compiler by default takes it
        //                                   // but if there is parameterised constructor of BaseClass then we have to include it which 
        //    {
        //        Console.WriteLine("This is Constructor of Derived Class");
        //    }
        //}

        //class TestInheritance5
        //{
        //    public static void Main(string[] args)
        //    {
        //        DerivedClass obj = new DerivedClass();
        //        Console.ReadLine();
        //    }
        //}

        #endregion

        #region Constructor ( Parameterised ) in Inheritance

        //class BaseClass
        //{
        //    public BaseClass(string message) // Default Constructor of Base Class with parameter
        //    {
        //        Console.WriteLine(message);
        //    }
        //}

        //class DerivedClass : BaseClass
        //{
        //    public DerivedClass() : base("Hey this is constructor of Base Class") // Default Constructor of Derived Class
        //                                                                         // Here as there is parameterised constructor so we have to pass arguement in base() as shown
        //    {
        //        Console.WriteLine("This is Constructor of Derived Class");
        //    }
        //}

        //class TestInheritance5
        //{
        //    public static void Main(string[] args)
        //    {
        //        DerivedClass obj = new DerivedClass();
        //        Console.ReadLine();
        //    }
        //}

        #endregion

        #region Notes of Access Specifiers

        // public :- Applicable to the application , current class ,derived class ,  outside namespace / assembly , outside namespace but in derived class
        // private :- Applicable to current class only
        // protected :- Applicable to current class , derived class , outside namespace but in derived class
        // internal :- Applicable to the application , current class , derived class
        #endregion
    }

}
