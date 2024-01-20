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
            ConstructorExample constructorExample1 = new ConstructorExample(); // default
            ConstructorExample constructorExample2 = new ConstructorExample(a: 10); // parameterized
            constructorExample1.check();
        }
    }
}

