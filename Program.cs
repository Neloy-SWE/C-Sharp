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
            Loops loops = new Loops();
            loops.checkForLoop(5);
            loops.checkWhileLoop(5);
            loops.checkDoWhileLoop(5);
            loops.simpleNestedLoop();

        }
    }
}

