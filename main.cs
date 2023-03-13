/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
partial class HelloWorld {
    static int sno;
    static string sname;
    static string course;
    static int fees;
    
    public HelloWorld(){
        Console.WriteLine("default constructor");
    }
    
    public HelloWorld(int sNo,string sName,string Course,int Fees){
        sno = sNo;
        sname=sName;
        course=Course;
        fees=Fees;
        
        
    }
    
    static HelloWorld(){
        Console.WriteLine("Static Constructor");
    }
    
    public static void meth1(){
        Console.WriteLine(sno+" "+sname+" "+course+" "+fees);
    }
  static void Main() {
   HelloWorld cons1 =new HelloWorld(01,"varun","Data scientist",0);
   HelloWorld cons2 =new HelloWorld();
   HelloWorld.meth1();
   HelloWorld cons3 =new HelloWorld();
  } 
}




