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
            TypeCasting typeCasting = new TypeCasting();
            typeCasting.ImplicitCast(integerValue: 10);
            typeCasting.ExplicitCast(doubleValue: 10.21345);
            typeCasting.ConvertByMethod(integerValue: 10, doubleValue: 20.44);

        }
    }
}

