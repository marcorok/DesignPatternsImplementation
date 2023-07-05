// See https://aka.ms/new-console-template for more information

using FactoryMethod.Factory;
using Adapter;
using ChainOfResponsibility;
using ChainOfResponsibility.Handlers;

Tests testToRun = Tests.CHAIN_OF_RESPONSIBILITY;

switch (testToRun)
{
    case Tests.FACTORY_METHOD:
        TestFactoryMethod();
        break;
    case Tests.ADAPTER:
        TestAdapter();
        break;
    case Tests.CHAIN_OF_RESPONSIBILITY:
        TestCoR();
        break;
    default:
        Console.WriteLine("Nothing to test");
        break;

}

void TestCoR()
{
    var monkey = new MonkeyHandler();
    var squirrel = new SquirrelHandler();
    var dog = new DogHandler();

    monkey.SetNext(squirrel).SetNext(dog);
    Console.WriteLine("Chain: Monkey > Squirrel > Dog");
    Client.ClientCode(monkey);
    Console.WriteLine();

    Console.WriteLine("Subchain: Squirrel > dog");
    Client.ClientCode(squirrel);
}

void TestAdapter()
{
    Console.WriteLine("Testing the ADAPTER design pattern!!!!");

    RoundHole rh = new RoundHole(5);
    RoundPeg rp = new Adapter.RoundPeg(4);
    Console.WriteLine("Round Peg fits in Round hole?");
    Console.WriteLine(rh.Fits(rp));

    Console.WriteLine("Square Peg fits in Round hole?");
    SquarePeg squarePeg = new Adapter.SquarePeg(2);
    SquarePegAdapter sqpa = new Adapter.SquarePegAdapter(squarePeg);
    Console.WriteLine(rh.Fits(sqpa));

}

void TestFactoryMethod()
{
    Console.WriteLine("I'm creating a Windows Dialog!");
    var winDialog = new FactoryMethod.Factory.WindowsDialog();
    winDialog.Render();

    Console.WriteLine("I'm creating an HTML Dialog!");
    var htmlDialog = new FactoryMethod.Factory.WebDialog();
    htmlDialog.Render();

}


public enum Tests
{
    FACTORY_METHOD,
    ADAPTER,
    CHAIN_OF_RESPONSIBILITY
}