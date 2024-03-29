﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interview.OOP.Basic;

namespace Interview
{

    // Ref tells the compiler that the object is initialized before entering the function,
    // while out tells the compiler that the object will be initialized inside the function.

    // ref: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/out-parameter-modifier

    class RefValTest
    {

        // Always, Always, Always pass by values
        // And this is not related to whether it is value type or a reference type
        //For value type instances, a copy of the instance is passed to the method.This means that the
        //method gets its own private copy of the value type and the instance in the caller isn’t affected.

        // for value type
        internal void PassByValuesValTest()
        {
            int a = 10;
            ChangeVal(a);
            Console.WriteLine(a);
            Console.ReadKey();
        }

        // a is still 10
        private void ChangeVal(int a)
        {
            a = 100;
        }

        // With ref and out keyword's help, we can pass by reference, which is 实参
        // a is 100 now
        internal void CanPassByReferenceValTest()
        {
            int a = 10;
            ChangeValRef(ref a);
            Console.WriteLine(a);
            Console.ReadKey();
        }

        private void ChangeValRef(ref int a)
        {
            a = 100;
        }


        // for reference type
        //When reference type objects are passed, the reference(or pointer) to the object is passed(by
        //value) to the method.This means that the method can modify the object and the caller will see the
        //change
        public void PassByValuesRefTest()
        {
            var book1 = new SciFiBook("book1");
            SetName(book1, "book2");
            Console.WriteLine(book1.Name); 

            var book3 = new SciFiBook("book3");
            SetNewBook(book3, "book4");
            Console.WriteLine(book3.Name); 
            Console.ReadKey();
        }

        private static void SetNewBook(SciFiBook book, string new_name)
        {
            book = new SciFiBook(new_name);
        }

        private static void SetName(SciFiBook book, string new_name)
        {
            book.Name = new_name;
        }

        public void CanPassByReferenceRefTest()
        {
            var book1 = new SciFiBook("book1");
            SetNameRef(ref book1, "book2");
            Console.WriteLine(book1.Name);

            SetNameOut(out SciFiBook book2, "book3");
            Console.WriteLine(book2.Name);
            Console.ReadKey();
        }

        // Note that out is used when you expected to return something in the invoking method
        // And out does not care whether the passed argument is initialize or not, it anyway must be initialized in the method.
        private static void SetNameOut(out SciFiBook book, string new_name)
        {
            book = new SciFiBook(new_name);
        }

        private static void SetNameRef(ref SciFiBook book, string newname)
        {
            book.Name = newname;
        }

        // This is jsut to test whether two var can referenece the same object
        public void TwoVarCanReferenceSameObject()
        {
            var book1 = new SciFiBook("book1");
            var book2 = book1;

            Console.WriteLine(book2.Name);
            Console.WriteLine(ReferenceEquals(book1, book2));

            book2.Name = "book2";
            Console.WriteLine(book1.Name);
            Console.WriteLine(ReferenceEquals(book1, book2));
        }

    }
}
