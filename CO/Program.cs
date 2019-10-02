using System;

namespace CO
{
    class SampleClass
    {
        //Field
       public string sampleField;
       
       //auto implemented property
       public int SampleProperty{get; set;}

       // define field for storing teh property value and providing storing and retreving 
       private int _sample;
       public int _Sample
       {
           // Return the value stored in a field
           get {return _sample;}
           // Store the value in firld
           set {_sample = value; }
       }
       

       //Constructor
       public SampleClass(int _sample)
       {
           //Add Code here
           this._Sample = _sample;
           Console.WriteLine("Parent Class");
       }

       //Defined method
       public virtual void sampleMethod()
       {
            Console.WriteLine(2);
       }

      class Nested 
      {

      }



     




        static void Main(string[] args)
        {

            //Nested class use parent followed by dot then by name of nested class
            SampleClass.Nested  nestedInstance = new SampleClass.Nested();
            //SampleClass s1 = new SampleClass(22);
            //Console.WriteLine(s1._Sample);
           der d1 = new der();

           // s1.sampleMethod();
            //d1.sampleMethod();
           // s1.SampleProperty = 1;
           // Console.WriteLine(s1.SampleProperty);
        }
    }

     class der: SampleClass{
            
            public der(): base(10)
            {
                Console.WriteLine("Derived class");
            }
            // overriding a class
            public override void sampleMethod()
       {
            
            Console.WriteLine(3);
       }

    }
}
