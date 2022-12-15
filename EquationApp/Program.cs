using EquationApp;

//Equation eq = Equation.CreateEq(1, 10,-2);

Equation eq = new Equation();


if (eq is Equation2)
{
    var newEq = eq as Equation2;
    newEq.Solve();
}
else
{
    Console.WriteLine("Это не equation2");
}

Console.WriteLine(eq);
eq.Solve();
eq.PrintResult();

//   ax^2 + bx + c = 0
//    bx + c = 0
//    c = 0
