using CoreOOP.AllAbstract;
using CoreOOP.AllInheritance;
using CoreOOP.AllPolymorphism;
using CoreOOP.Practice;
using System;

namespace CoreOOP
{
    class Execute
    {
        static void Main(string[] args)
        {
            // simple print a string
            //FirstProgram firstProgram = new FirstProgram();
            //firstProgram.simplePrint();


            // data type check
            //DataTypes types = new DataTypes();
            //types.printAllValues();


            // type casting
            //TypeCasting typeCasting = new TypeCasting();
            //typeCasting.ImplicitCast(integerValue: 10);
            //typeCasting.ExplicitCast(doubleValue: 10.21345);
            //typeCasting.ConvertByMethod(integerValue: 10, doubleValue: 20.44);


            // control flow
            // if else
            //ControlFlowIfElse controlFlowIfElse = new ControlFlowIfElse();
            //controlFlowIfElse.checkIf(num: 11);
            //controlFlowIfElse.checkIfElseIf(num: 79);
            //controlFlowIfElse.checkIfElse(num: 50);
            //controlFlowIfElse.simpleNestedCondition(5);

            // switch
            //ControlFlowSwitchCase controlFlowSwitchCase = new ControlFlowSwitchCase();
            //controlFlowSwitchCase.checkSwitchCase(num: 50);
            //controlFlowSwitchCase.checkSwitchCase(num: 51.66);


            // loops
            //Loops loops = new Loops();
            //loops.checkForLoop(num: 5);
            //loops.checkWhileLoop(num: 5);
            //loops.checkDoWhileLoop(num: 5);
            //loops.simpleNestedLoop();
            //loops.checkBreakContinue(num: 10);


            // function
            //Functions functions = new Functions();
            //Console.WriteLine("retrun value check: {0}",functions.ReturnType(num: 5));
            //int i = 10;
            //Console.WriteLine("Before calling method for value: {0}", i);
            //functions.callByValue(num: i);
            //Console.WriteLine("After calling method for value: {0}", i);
            //functions.callByReference(num: ref i);
            //Console.WriteLine("After calling method for reference: {0}", i);
            //int a;
            //functions.callByOut(num: out a);
            //Console.WriteLine("After assign value from method: {0}", a);


            // array
            //Arrays arrays = new Arrays();
            //arrays.singleArray();
            //arrays.passArray(arr: [1,2,3]);
            //arrays.mutlidimensionalArray();
            //arrays.jaggedArray();


            // params
            //Params objParams = new Params();
            //objParams.checkParams(1, "Hello", 5.5, 19.4f);


            // class
            //ClassCheck classCheck = new ClassCheck();
            //classCheck.initialize(id: 181, name: "Neel");
            //classCheck.check();


            // constructor
            //ConstructorExample constructorExample1 = new ConstructorExample(); // default
            //ConstructorExample constructorExample2 = new ConstructorExample(a: 10); // parameterized
            //constructorExample1.check();


            // destructor
            //DestructorExample destructorExample = new DestructorExample();
            //destructorExample.checkObject();
            //destructorExample = null;
            //GC.Collect();
            //GC.WaitForPendingFinalizers();
            //Console.ReadKey();


            // static
            //Console.WriteLine("Calling static value of a: {0}", StaticExample.a);
            //StaticExample.checkStaticMethod();
            //StaticExample.a = 20;
            //Console.WriteLine("After change the static value of a: {0}", StaticExample.a);
            //StaticExample s1 = new StaticExample();
            //StaticExample s2 = new StaticExample();
            //StaticExample s3 = new StaticExample();
            //Console.WriteLine("Object creation count: {0}", StaticExample.count);

            // static class
            //StaticClass.check();


            // static constructor
            //StaticConstructor sc = new StaticConstructor();


            // struct
            //StructsExample structsExample = new StructsExample();
            //Console.WriteLine("Checking struct example value a: {0}", structsExample.a);
            //Console.WriteLine("Checking struct example value a: {0}", StructsExample.b);


            // inheritance
            // single
            //ChildSingleInheritanceClass csc = new ChildSingleInheritanceClass();
            //csc.check();
            //csc.checkChild();

            // multilevel
            //ChildMultilevel childMultilevel = new ChildMultilevel();
            //childMultilevel.checkSupreme();
            //childMultilevel.checkSubParent();
            //childMultilevel.checkChild();

            // hierarchical
            //HierarchicalInheritance c1 = new Child1(); // super class er vetor sub class er object newa possible. but sub class er method call possible na. only super class er method use kora possible
            //Level1HIClass c1 = new Child1(); // // super class er vetor sub class er object newa possible. but sub class er method call possible na. only super class er method use kora possible
            //Child1 c1 = new Child1();
            //c1.checkHI();
            //c1.checkHILevel1();
            //c1.checkChild1();
            //Child2 c2 = new Child2();
            //c2.checkHI();
            //c2.checkHILevel1();
            //c2.checkChild2();

            // multiple
            //MultipleInheritance cmi = new childMultipleInheritance(); // interface er object initialize kora jai na. tobe child class er object er maddhom e method use kora jai.
            //cmi.common(); // child class er object dhore interface er method ke call kora jai. tobe jodi same method child class eo thake tobe child class er method e call hobe.
            //childMultipleInheritance cmi = new childMultipleInheritance();
            //cmi.method1();
            //cmi.common();


            // has a relationship
            //HasARelationShip hasARelationShip = new HasARelationShip(name: "Neloy", department: "SWE");
            //Relations relations = new Relations(id: 181, har: hasARelationShip);
            //relations.show();


            // polymorphism
            // overloading: method, constructor
            //MemberOverloading mo1 = new MemberOverloading();
            //MemberOverloading mo2 = new MemberOverloading(s: "with parameter");
            //Console.WriteLine(mo1.add(1, 2));
            //Console.WriteLine(mo1.add(1, 2,3));
            //Console.WriteLine(mo1.add(1.1, 2.2));

            // overriding: method
            //Overriding o = new Overriding();
            //o.check();
            //Overriding o = new Child();
            //o.check();
            //Child child = new Child();
            //child.check();

            // base
            //BaseChild baseChild = new BaseChild(a: 10, b: 20);
            ////BaseChild baseChild = new BaseChild();
            //baseChild.childCheck();
            //Console.WriteLine(baseChild.a + baseChild.b);


            // abstract
            // class, method
            //ChildAbstractClass childAbstractClass = new ChildAbstractClass();
            //childAbstractClass.checkAbstractMethod();
            //childAbstractClass.checkNonAbstractMethod();

            // interface
            //ChildInterfaceClass childInterfaceClass = new ChildInterfaceClass();
            //Console.WriteLine("Retrun value form interface is: {0}", childInterfaceClass.check());        
            //InterfaceExample example = new ChildInterfaceClass();
            //example.TypeCheck();



            // access modifier
            // public
            AccessModifierExample accessModifierExample = new AccessModifierExample();
            accessModifierExample.CheckPublic();
            AccessMOdifierCheck accessMOdifierCheck = new AccessMOdifierCheck();
            // protected
            accessMOdifierCheck.CheckProtected();
            // internal
            Console.WriteLine("internal member: "+accessModifierExample.b);
            // protected internal
            Console.WriteLine("protected internal member: "+accessModifierExample.c);
            // private
            accessModifierExample.GetPrivate();











            // Paractice
            //BankAccount bankAccount = new BankAccount(500);
            //bankAccount.Deposit(500);
            //Console.WriteLine("Balance: "+ bankAccount.GetBalance());
            //bankAccount.Withdraw(500);
            //Console.WriteLine("Balance: " + bankAccount.GetBalance());

            //bankAccount.Withdraw(5000);
            //Console.WriteLine("Balance: " + bankAccount.GetBalance());
        }
    }
}

