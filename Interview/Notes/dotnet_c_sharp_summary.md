﻿

# Introduction C# and .Net

## .Net Concept

.net core VS. net framework VS .net standard VS .Net

My understanding:
- .Net core is cross-platform, open-source, CLI(command-line interface) supported
- .Net framework is mainly target for windows OS and web development
- .Net standrad is a interface, a wider, more common library definition. 
  - .Net core and .Net framework are the implemetation of .Net library.
  - > "In short: to achieve maximum portability, make your library target .NET Standard."

- .Net is the future, which almost includes everything, covering all the advantages of both Framework and Core:
  - For everything: windows. linux, web, mobile...
  - Open Source
  - Support all major platform for Framework, core and Xamarin 
  - Scalable, fast, and high performance.
  - Smaller deployment and packages.
  - Support of the most productive IDEs and tools including Visual Studio, VS Code, VS for Mac, and Command Line Interface (CLI) 

ref:

- https://www.c-sharpcorner.com/article/net-framework-vs-net-core-vs-net-standard/
- https://stackoverflow.com/questions/38063837/whats-the-difference-between-net-core-net-framework-and-xamarin
- https://stackoverflow.com/questions/57720865/dot-net-framework-vs-dot-net-core-sdk
- https://stackoverflow.com/questions/44085424/net-standard-vs-net-core
- https://gist.github.com/davidfowl/8939f305567e1755412d6dc0b8baf1b7
- https://www.c-sharpcorner.com/article/future-of-dot-net/


## .Net component

.Net = CLR + FCL + progamming language, + compiler, so complier is not part of .Net.

> Back to year 09: .Net Framework? = libraries (FCL, BCL), language compilers (C#, VB.NET) and Common Language Runtime (CLR)

> But noted that later, microsoft decoupled the C# compiler, language version, and .NET Framework. 

So I guess .Net framework Only includes Libraries and  CLR. And complier is integrated with IDE, like VS. 

### Some terms in 
- CLR -> common language runtime -> Runtime, a virtual machine.
- FCL -> Framework class library -> library
- BCL -> Base Class library, BCL is included in the FCL
- IL -> immediate language
- CLS -> Common language Specifications
- CTS -> Common language Type

My understanding: 
- CLR is the virtual machine, that being responsible for executing code with JIT compliers, managing memory,
handling exceptions, debugging, collecting garbage, supporting threads, etc. CLR can of course run other language's IL.
- FCL is the library, that includes the implementations ASP.Net, ADO.Net. etc. 
- BCL is just like the name defines, the very base library, used to define basic fundamental types like System.string.
- IL is the immediate language, which is being complied during compling the source code of the .Net based source code
- CLS: CLS is includes in the CTS

Ref:
https://stackoverflow.com/questions/807880/bcl-base-class-library-vs-fcl-framework-class-library
https://www.linkedin.com/pulse/what-ctscls-fcl-bcl-crl-net-framework-pawan-verma
https://www.cnblogs.com/eshizhan/archive/2010/01/26/1657041.html
https://www.zhihu.com/question/20607178
https://docs.microsoft.com/zh-cn/dotnet/standard/clr

## .net complie 

### Complier:
- csc.exe - the obsolete complier
- roslyn, - the complier API， but looks like roslyn also includes csc.exe

ref:
https://www.cnblogs.com/chucklu/p/11300738.html

### complile process

C# source code -> (complied as) CIL(dll, exe) -> (execuated) CLR -> machine code

- > Compiling Source Code into Managed Module.
- > Combining newly created managed module into the assembly / assemblies.
- > Loading the CLR.
- > Executing the assembly in & by CRL.

https://www.c-sharpcorner.com/UploadFile/a8024d/C-Sharp-program-compliation-steps/


- source code is complied in managed module. 
  - Suppose if we create a console application & compile it then it creates .exe file. If we create web application & compile it then it creates .dll files
- Managed module is standard windows Portable Executable (PE) file
- combining newly created managed module into the assembly
- Executing the assembly in & by CLR

ref:

https://docs.microsoft.com/zh-cn/dotnet/standard/managed-execution-process

https://www.c-sharpcorner.com/UploadFile/a8024d/C-Sharp-program-compliation-steps/

https://zhuanlan.zhihu.com/p/37146324

https://www.cnblogs.com/May-day/p/6594574.html

## command line

cmd dotnet

- dotnet --info
- dotnet --help
- dotnet --new
- dotnet new
- dotnet restore
- dotnet build
- dotnet test
- dotnet run

## .net project in IDE

**how do I know my langauge version:**
https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/configure-language-version

**how do I know CLR version:**
https://docs.microsoft.com/en-us/dotnet/api/system.environment.version?view=net-5.0

**how do I know the complier I am using:**
https://stackoverflow.com/questions/47633139/how-to-determine-c-sharp-compiler-version-in-command-line

> The latest C# compiler determines a default language version based on your project's target framework or frameworks. 
> Visual Studio doesn't provide a UI to change the value, but you can change it by editing the csproj file. 
> The choice of default ensures that you use the latest language version compatible with your target framework. 
> You benefit from access to the latest language features compatible with your project's target. 
> This default choice also ensures you don't use a language that requires types or runtime behavior not available in your target framework. 
> Choosing a language version newer than the default can cause hard to diagnose compile-time and runtime errors.

complier, language, .net, their relationship are strictly linked.

https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/configure-language-version

### project folder

- .csproj --> c# project
- bin
- obj

## .Net's packages -> nuget

> "What is NuGet? NuGet is the package manager for the Microsoft development platform including .NET. The NuGet client tools provide the ability to produce and consume packages. 
> The NuGet Gallery is the central package repository used by all package authors and consumers.

Like in pip in the python, and npm in the js

## Managed Code VS Unmanaged Code

**Managed Code**

- Managed code is the **code that is developed using the .NET framework** and its supported programming languages such as C# or VB.NET. 
- Managed code is **directly executed** by the Common Language Runtime (CLR or Runtime) and its lifecycle including object creation, 
memory allocation, and object disposal is managed by the Runtime. 
- Any language that is written in .NET Framework is managed code.
 
**Unmanaged Code**
 
- The code that is developed outside of the .NET framework is known as unmanaged code. 
- “Applications that do not run under the control of the CLR are said to be unmanaged. 
- Languages such as C or C++ or Visual Basic are unmanaged.
- The object creation, execution, and disposal of unmanaged code is directly managed by the programmers.If programmers write bad code, it may lead to memory leaks and unwanted resource allocations.”
 
The .NET Framework provides a mechanism for unmanaged code to be used in managed code and vice versa. The process is done with the help of wrapper classes.

**PDB, dll, exe, debug**


https://docs.microsoft.com/zh-cn/dotnet/standard/managed-code
https://docs.microsoft.com/zh-cn/dotnet/standard/automatic-memory-management


https://www.wintellect.com/pdb-files-what-every-developer-must-know/
https://docs.microsoft.com/en-us/visualstudio/debugger/how-to-set-debug-and-release-configurations?view=vs-2019


# C# Basic Syntax

## main() method
- The Main method is the entry point of the C# application.
- Library and Service Does not require a Main method as an entry point
- **There can only be one entry point in a C# program**
- The Main method can be declared with or without a string[] parameter that contains **command-line arguments**.
- Main must be static and it need not be public. 

ref:

https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/program-structure/main-command-line

## data type $ variable declarision

- sbyte, byte
- short, int, long
- float
- double
- char
- string 
- implcity typing -> var. implcit type varible must be initialized

## string and string bulider

**Something is mutable only when we are able to change the *values* held in the memory location without changing the memory location itself**

**String**
- A string is immutable object. 
- A moidification to a string is actually creating a new instance in the memory for hold the new value in a string object
- Performace is not that good as it will create new memory instance and point var to it

**StringBuilder**

- Stringbuilder object is mutable.
- Performance is better.
- Belong to System.Text.Stringbuilder

Stringbuilder has methods like append, clear.

ref:

https://docs.microsoft.com/en-us/dotnet/api/system.text.stringbuilder?view=net-5.0
https://stackoverflow.com/questions/9097994/arent-python-strings-immutable-then-why-does-a-b-work

## Array 

    float[] numbers = new float[3];
    float[] numbers = new float[3]{1.1,2.2,3.3};
    float[] numbers = new float[]{1.1,2.2,3.3};
    var numbers = new[]{1,2,3,4};

- array can be fixed or dynamic. You can even change a dynamic array to static after it is defined.
- can initiate single, multi-dimension arrays 
- can define jagged array, which is array include array
- array has several ways to be initiated. The default value of array depends on the member type, if it is value type, its 0; if ref type, then it is null
- array is a reference type itself, array is a class, method like append, sort, binarysearch are all included

This is very different with Python...

ref:

https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/single-dimensional-arrays

#### jagged array and multi-dimensional array difference



A jagged array is an array-of-arrays, so an int[][] is an array of int[], each of which can be of different lengths and occupy their own block in memory. 
A multidimensional array (int[,]) is a single block of memory (essentially a matrix).

https://stackoverflow.com/questions/4648914/why-we-have-both-jagged-array-and-multidimensional-array

#### copyto() and clone()

The Array.Clone() method creates a shallow copy of an array. 
A shallow copy of an Array copies only the elements of the Array, whether they are reference types or value types, but it does not copy the objects that the references refer to. 
The references in the new Array point to the same objects that the references in the original Array point to.
 
The CopyTo() static method of the Array class copies a section of an array to another array. 
The CopyTo method copies all the elements of an array to another one-dimension array. 

Both of them are shadow copy, no new instance is created.

ref:

https://www.geeksforgeeks.org/shallow-copy-and-deep-copy-in-c-sharp/

https://stackoverflow.com/questions/198496/difference-between-the-system-array-copyto-and-system-array-clone

## List

    List<int> numbers = new List<int>();
    List<int> numbers = new List<int>(20);
    List<int> numbers = new List<int>(IEnumerable<T>);
    var numbers = new List<double>{1.1, 1.2, 1.3}; # this is actually called collection initializer

List VS array.

> It is rare, in reality, that you would want to use an array. Definitely use a List<T> any time you want to add/remove data, since resizing arrays is expensive. 
> If you know the data is fixed length, and you want to micro-optimise for some very specific reason (after benchmarking), then an array may be useful.
> 
> List<T> offers a lot more functionality than an array (although LINQ evens it up a bit), and is almost always the right choice. Except for params arguments, of course. ;-p
> As a counter - List<T> is one-dimensional; where-as you have have rectangular (etc) arrays like int[,] or string[,,] - but there are other ways of modelling such data (if you need) in an object model.
> 
> https://stackoverflow.com/questions/434761/array-versus-listt-when-to-use-which


The Parentheses --> ? 
https://stackoverflow.com/questions/39548446/c-sharp-list-definition-parentheses-vs-curly-braces
 
## hashtable

- key/value pair acheived through hash algorithm
- Dictionary implementation in the .Net is based on the Hashtable

> The generic Dictionary was copied from Hashtable's source

ref: 
https://stackoverflow.com/questions/301371/why-is-dictionary-preferred-over-hashtable-in-c

https://docs.microsoft.com/zh-cn/archive/blogs/ericlippert/ambiguous-optional-parentheses-part-one

## Generics

- Can hold different type of object
- No casting
- no boxing and unboxing
- Type safe
- Better performance

> You could use the ArrayList class, but the downside is that it's containing type is an object. So when you'd iterate over the list, 
> you'd have to cast every item to its correct type (either string or Animal) which is more code and has a performance penalty. 
> Plus, since an ArrayList holds objects, it isn't type-safe.

ref:

Why Should I use generics? Why it is good

https://stackoverflow.com/questions/3606595/understanding-c-sharp-generics-much-better/3606655


## Type: 

### Reference Types and Value Types

The reference type varible holds a reference to the object

    var b = new Book("Grades");

Anytime you are working with the Class, or writing a Class or using a class, the class provided by .Net or Nuget packages,
You are using what is Known as the reference type.

The value type varible holds itself

    var b = 3;

When you work with int, float, doubles..., you are working with the value type

A method to differentiate a valye type object and a reference type object is to check it is a struct or a class

string is reference type, but it act like a value type 

### struct and class

**Struct**
- The struct is a value type in C# and it inherits from System.Value Type.
- Struct is usually used for smaller amounts of data.
- Struct can’t be inherited from other types. But **struct can inherit others, but it can't be inherited by others.**
- A structure can't be abstract.
- No need to create an object with a **new** keyword.
- **Do not have permission to create any default constructor.**

> A structure type can't inherit from other class or structure type and it can't be the base of a class. 
> However, a structure type can implement interfaces.

**Class**
- The class is a reference type in C# and it inherits from the System.Object Type.
- Classes are usually used for large amounts of data.
- Classes can be inherited from other classes.
- A class can be an abstract type.
- We can create a default constructor.

### Pass by reference and Pass by value 

**See demo**

These are based on the fact that method in C# is always, always, always, passing by values by default unless you declare these two keywords.

pass by reference and pass by value is totally different with referece types. it is all about parameter(形参) and argument(实参).

**ref/out** 

> ref tells the compiler that the object is initialized before entering the function, while out tells the compiler that the object will be initialized inside the function.
> So while **ref is two-ways, out is out-only.**

so **ref** must be initialized before entering the method, and does not have to be initiated or re-assigned before leaving the calling method;
while **out** does not have to be initiated before entering, but must be initiated or assigned a value before leaving

That is why **ref** is useful when method wants to changing sth; while out is useful when method wants to **return** multiple outputs

ref:
https://stackoverflow.com/questions/388464/whats-the-difference-between-the-ref-and-out-keywords
https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/ref#passing-an-argument-by-reference
**https://segmentfault.com/a/1190000016773324**

### boxing and unboxing

Boxing and Unboxing both are used for type conversions.
 
The process of converting from a value type to a reference type is called boxing. 
Boxing is an implicit conversion. 

Why do we need boxing and unboxing? unified type system?

https://stackoverflow.com/questions/2111857/why-do-we-need-boxing-and-unboxing-in-c


### Default values

```<language>
int a = default(int)
```

Note that this different with Nullable

https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/default-values


## Nullable

A nullable type is a data type is that contains the defined data type or the null value.
 
This nullable type concept is not compatible with "var".
 
Any **data type** can be declared **nullable type** with the help of operator "?". 

```<C#>
int? a = null;
```

### is VS as


> The is operator returns true when an expression result is non-null and any of the following conditions are true:
> 
> - The run-time type of an expression result is T.
> 
> - The run-time type of an expression result derives from type T, implements interface T, or another implicit reference conversion exists from it to T.
> 
> - The run-time type of an expression result is a nullable value type with the underlying type T and the Nullable<T>.HasValue is true.
> 
> - A boxing or unboxing conversion exists from the run-time type of an expression result to type T.


- "is" is used to determine if an object can be cast into some specifc type. For val type, directly check? if ref type, can check if it is derived class
- "as" is I will firstly try to cast into this type, but if fails, I will return null

> IS - Is Operator is used to Check the Compatibility of an Object with a given Type and it returns the result as a Boolean (True Or False).
> 
> AS - As Operator is used for Casting of Object to a given Type or a Class.

> The as operator explicitly converts the result of an expression to a given reference or nullable value type


ref:
https://stackoverflow.com/questions/3786361/difference-between-is-and-as-keyword
https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/type-testing-and-cast#code-try-7

### Casting

cast means type conversion, 
casting is different with boxing and unboxing

https://stackoverflow.com/questions/1085144/what-is-the-difference-between-boxing-unboxing-and-type-casting

### equals() VS == VS ReferenceEquals

> Equals is an instance method that takes one parameter (which can be null). Since it is an instance method (must be invoked on an actual object), it can't be invoked on a null-reference.
> 
> ReferenceEquals is a static method that takes two parameters, either / both of which can be null. Since it is static (not associated with an object instance), it will not throw a NullReferenceException under any circumstances.
> 
> == is an operator, that, in this case (object), behaves identically to ReferenceEquals. It will not throw a NullReferenceException either 

ref:
https://stackoverflow.com/questions/3869601/c-sharp-equals-referenceequals-and-operator

### ref:
https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-types
https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/out-parameter-modifier
https://www.c-sharpcorner.com/UploadFile/ff2f08/ref-vs-out-keywords-in-C-Sharp/ 
https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/structs
https://stackoverflow.com/questions/2111857/why-do-we-need-boxing-and-unboxing-in-c


## flow control

### foreach

    foreach(float number in numbers)
    {
    }

    foreach(int i = 0, i < numbers.Length, i++)
    {
    }

### do while VS while

The do statement executes a statement or a block of statements while a specified Boolean expression evaluates to true. 
Because that expression is evaluated after each execution of the loop, a do loop executes one or more times.

This differs from a while loop, which executes zero or more times.

See demo.


### Switch, Case

```<language>
Swtich()
{
    case A/ Case case safe guard
    {
        exeucte sth;
        Jump statement: break, return, throw, goto
    }
    case B/ Case case safe guard
    {}
    case C/ Case case safe guard
    {}
}
```

The default case can appear in any place within a switch statement. 
Regardless of its position, the default case is always evaluated last and only if all other case patterns aren't matched.

C# 9.0, the case declarition becomes more intuitive.  


### Continue, Break, Goto, return 

Continue: go to the next iteration
Break: break the current iteration and jump out of the loop; break switch
Goto: go to other case in switch, or go to "label statement"?
return: very typically used in function that need to return values. 


# Classes

    Class Name
    {
        # state

        # behavior
    }

- Class should be in a namespace, otherwise it will be in the global namespace, but this is dangerous
- One Class per file.

## Class Basics

### defining a method


    Class Name
    {
        # state

        # behavior
        public void AddGrade(double grade)
        {
        }
    }

#### method overloading

**method overloading is the common way of implementing polymorphism**

- method signature, name, and parameter(order, name, return type)


ref:
- https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/member-overloading
- https://www.geeksforgeeks.org/c-sharp-method-overloading/
- https://stackoverflow.com/questions/154577/polymorphism-vs-overriding-vs-overloading

### defining a field


    Class Name
    {
        # state
        List<double> grades        

        # behavior
        public void AddGrade(double grade)
        {
            # local variable
            # List<double> grades;
            grades.Add(grade)
        }
    }


### class field initilization

this is mostly used inside the class, which used to indicate the object.

### defining a Properties: getter and setter

- C# properties are members of a C# class that provide a flexible mechanism to read, write or compute the values of private fields.
- In other words, by using properties, we can access private fields and set their values. 
- **Properties in C# are always public data members**. Properties can be used as if they are public data members, but they are actually special methods called accessors.
- C# properties use get and set methods, also known as accessors, to access and assign values to private fields.
 
What are accessors?
 
- The get and set portions or blocks of a property are called accessors. These are useful to restrict the accessibility of a property. 
- The set accessor specifies that we can assign a value to a private field in a property.
- Without the set accessor property, it is like a readonly field. 
- With the 'get' accessor we can access the value of the private field. 
- In other words, it returns a single value. A Get accessor specifies that we can access the value of a field publically.
 
We have three types of properties: Read/Write, ReadOnly, and WriteOnly
 
### defining a delegate





### defining a Constructors

```<C#>
Class Name
{
    # state
    List<double> grades;     
        
    # constructor method
    public book()
    {
        grades = new List<double>();
    }
           

    # behavior
    public void AddGrade(double grade)
    {
        # local variable
        # List<double> grades;
        grades.Add(grade)
    }
}
```


#### default construtor

> If you don't provide a constructor for your class, C# creates one by default that instantiates the object and sets member variables to the default values as listed in the Default values of C# types article. If you don't provide a constructor for your struct, 
> C# relies on an implicit parameterless constructor to automatically initialize each field to its default value. 

Once you declare a constructor, there will be no default parameterless constructor

#### constructor overloading

To create different constructors for different behavior of initiating object with different parameter signature.

#### Static Constructor



https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/static-constructors

#### construtor chaining


- Is this a old fashion way or not? Since we already have the optional parameters

> If you use this technique, you have to be aware that default arguments are set at compile time in the caller, not the callee. 
> That means if you deploy code like this in a library and an application uses a constructor with default args; you need a re-compile of the application using the library if the default arguments change.
> Some people consider default arguments in public interfaces inherently dangerous because of this gotcha
> https://stackoverflow.com/questions/1814953/how-to-do-constructor-chaining-in-c-sharp

- Chaining constructor is in order to reduce code repeat.
- Chaining constructor use "this(parameter signature)" to chain.
- The constructor body executed after the chained constructor call. There is no way to call the constructor body first

ref:
https://www.c-sharpcorner.com/UploadFile/825933/constructor-chaining-in-C-Sharp/
https://stackoverflow.com/questions/7577627/purpose-of-constructor-chaining
https://stackoverflow.com/questions/40491161/constructor-chaining-in-c-sharp
https://stackoverflow.com/questions/45344913/beginner-to-c-how-to-do-constructor-chaining-overriding-and-using-this-ba
https://stackoverflow.com/questions/1814953/how-to-do-constructor-chaining-in-c-sharp

## C# Class Charcteristics

C# is of course Object-Oriented Programming language, which have that three main charateristics:
- Encapsulation:
  - try to "do not repeat yourself" implementations.
  - Encapsulation is also about the access control
    
- Polymorphism
- Inheritance

C# has memebers such as fields, methods, properties, delegate, events.

Want to talk about the refactoring a little bit here:
- Encapsulate fields
- Extract method -> To generate a block of code to a new method. 
- Generalize Type -> to generalize a base class. And make fully use of the Polymorphism to override/overload. 
- Pull up -> to move childrens to parent
- Push down -> to move parents to childrens

### modifiers

#### access modifiers

- public: all
- private: in the same class
- internal: in the same assembly
- protected: in the parent class and derived class

#### readonly, constant

- readonly can be changed via **non-static constructor**, even during the runtime. As long as you change this in the constructor
- Constant is nothing but "constant", a variable of which the value is constant but at compile time.It's mandatory to assign a value to it. 
- By default, a const is static and we cannot change the value of a const variable throughout the entire program.
- **so a property with only get accessor is inplicitly a readonly member.**

I think readonly and constant has something in common, where they all expected that the value to be constant to some extent, but readonly means val can be
mutable but only with the constructor. so looks like after a object is constructed, the value won't change

ref:
https://stackoverflow.com/questions/277010/what-are-the-benefits-to-marking-a-field-as-readonly-in-c
https://www.c-sharpcorner.com/UploadFile/c210df/difference-between-const-readonly-and-static-readonly-in-C-Sharp/

#### sealed

prevent to be inherited.

Sealed classes are used to restrict the inheritance feature of object-oriented programming. 
Once a class is defined as a sealed class, the class cannot be inherited. 

struct is sealed. 

#### static
static can be used to declare class.
In class, static can be used to describle fields, methods, properties, events, operators, and constructors

A static class:
- Contains only static members.
- Cannot be instantiated.
- Is sealed.
- Cannot contain Instance Constructors. 

什么时候会用到呢？

### Inheritance,

Inheritance enables you to create new classes that **reuse, extend, and modify** the behavior defined in other classes. 
The class whose members are inherited is called the base class, and the class that inherits those members is called the derived class. 
A derived class can have only one direct base class

#### Constructor Inheritance

> No, you can't override constructors. The concept makes no sense in C#, because constructors simply aren't invoked polymorphically. 
> You always state which class you're trying to construct, and the arguments to the constructor.
> 
> Constructors aren't inherited at all - but all constructors from a derived class must chain either to another constructor in the same class, or to one of the constructors in the base class. 
> If you don't do this explicitly, the compiler implicitly chains to the parameterless constructor of the base class (and an error occurs if that constructor doesn't exist or is inaccessible).
> 
> https://stackoverflow.com/questions/11271920/is-it-possible-to-override-a-constructor-in-c

Constructor chaining is a way to connect two or more classes in a relationship as Inheritance. 
In Constructor Chaining, every child class constructor is mapped to a parent class Constructor implicitly by base keyword,
so when you create an instance of the child class, it will call the parent’s class Constructor. Without it, inheritance is not possible

#### Abstract

**Concept**
- The abstract modifier indicates that the thing being modified has a missing or incomplete implementation. 
- The abstract modifier can be used with classes, methods, properties, indexers, and events. 
- Use the abstract modifier in a class declaration to indicate that a class is intended only to be a base class of other classes, not instantiated on its own. 
- Members marked as abstract must be implemented by non-abstract classes that derive from the abstract class.

**Abstract Class feature**

- Cannot be instantiated
- An abstract class may contain abstract methods and accessors, **so abstract class can have actual implementation for method**
- A non-abstract class derived from an abstract class must include actual implementations of all inherited abstract methods and accessors.
- It is not possible to modify an abstract class with the sealed modifier because the two modifiers have opposite meanings. 

The **sealed** modifier prevents a class from being inherited **and the abstract modifier requires a class to be inherited.** 

**Abstract method feature**
- **Abstract method declarations are only permitted in abstract classes.** <https://stackoverflow.com/questions/22161297/why-can-abstract-methods-only-be-declared-in-abstract-classes>
- It is an error to use the static or virtual modifiers in an abstract method declaration

**Abstract properties feature**
- It is an error to use the abstract modifier on a static property.
- An abstract inherited property can be overridden in a derived class by including a property declaration that uses the override modifier

ref:

https://stackoverflow.com/questions/10942599/c-abstract-and-non-abstract-methods-in-an-abstract-class
https://stackoverflow.com/questions/22161297/why-can-abstract-methods-only-be-declared-in-abstract-classes
https://stackoverflow.com/questions/4811678/defining-an-abstract-class-without-any-abstract-methods

#### Virtual

A virtual method is a method that can be redefined in derived classes
A virtual method has an implementation in a base class as well as derived class.
It of course can be override. But it is optional. 

https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/virtual

**Virtual & Abstract Difference**

An abstract function cannot have functionality. You're basically saying, any child class MUST give their own version of this method, 
however it's too general to even try to implement in the parent class.

A virtual function, is basically saying look, here's the functionality that may or may not be good enough for the child class. 
So if it is good enough, use this method, if not, then override me, and provide your own functionality.

ref:

https://stackoverflow.com/questions/391483/what-is-the-difference-between-an-abstract-method-and-a-virtual-method

#### Interface

- Interface is more common than abstract in daily C# usage
- Interface defines a contract. Any class or struct that implements that contracts must provide an implementation of the members defines in the interface.
- An interface declaration can contain declarations of following:
  - methods
  - properties
  - indexers
  - events

#### Abstract VS Interface

- A class can implement any number of interfaces but a subclass can at most use only one abstract class.
- An abstract class can have non-abstract methods (concrete methods) while in case of interface, all the methods have to be abstract.
- An abstract class can declare or use any variables while an interface is not allowed to do so.
- **In an abstract class, all data members or functions are private by default while in an interface all are public, we can’t change them manually.**
- In an abstract class, we need to use abstract keywords to declare abstract methods, while in an interface we don’t need to use that.
- An abstract class can’t be used for multiple inheritance while the interface can be used as multiple inheritance.
- An abstract class use constructor while in an interface we don’t have any type of constructor.


In C#, when should you use interfaces and when should you use abstract classes? What can be the deciding factor?

**Why we do create object instance from Interface instead of Class?**


> The advantages of an abstract class are:
> 
> Ability to specify default implementations of methods
> Added invariant checking to functions
> Have slightly more control in how the "interface" methods are called
> Ability to provide behavior related or unrelated to the interface for "free"
> 
> Interfaces are merely data passing contracts and do not have these features. 
> However, they are typically more flexible as a type can only be derived from one class, but can implement any number of interfaces.



> Abstract classes and interfaces are semantically different, although their usage can overlap.
> 
> An abstract class is generally used as a building basis for similar classes. Implementation that is common for the classes can be in the abstract class.
> 
> An interface is generally used to specify an ability for classes, where the classes doesn't have to be very similar.

https://stackoverflow.com/questions/747517/interfaces-vs-abstract-classes


ref:
https://stackoverflow.com/questions/7716435/why-would-you-declare-an-interface-and-then-instantiate-an-object-with-it-in-jav
https://stackoverflow.com/questions/16832280/why-we-do-create-object-instance-from-interface-instead-of-class
https://stackoverflow.com/questions/17290336/what-happens-when-we-create-an-object-of-interface
https://stackoverflow.com/questions/2186906/creating-objects-from-an-interface-in-c-sharp
https://stackoverflow.com/questions/7122260/creating-an-instance-of-an-interface

#### overriding

override is only for methods, for behaviors. No constructor
And override only happend for virtual and abstract methods, you cannot override a non-virtual method


## Other parts about C# class

### Partial 






# Other

## Enum

Enum is **value type**

- By default, the associated constant values of enum members are of type int; they start with zero and increase by one following the definition text order. 
- You can explicitly specify any other integral numeric type as an underlying type of an enumeration type. 
- You can also explicitly specify the associated constant values, as the following example shows

An enum is used to create **numeric constants** in the .NET framework. All the members of enum are enum type. There must be a numeric value for each enum type.
The default underlying type of the enumeration element is int. By default, the first enumerator has the value 0, and the value of each successive enumerator is increased by 1. 

```<C#>
enum Season
{
    Spring, # start from 0
    Summer,
    Autumn,
    Winter
}
```

```<C#>
enum Season: short
{
    Spring = 1,
    Summer = 3,
    Autumn = 5,
    Winter = 7
}
```

**Constants can be referred to in a consistent, expressive and type-safe way.**

ref:

https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/enum
https://stackoverflow.com/questions/3519429/what-is-main-use-of-enumeration

## IEnumerable


## 