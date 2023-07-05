using ChainOfResponsibility.Handlers;

namespace ChainOfResponsibility
{
    public static class Client
    {
        public static void ClientCode(AbstractHandler handler) {

            foreach (var food in new List<string> { "Banana", "Nut", "Cup of coffee" })
            {
                Console.WriteLine($"Client: Who wants a {food}?");

                var result = handler.Handle( food );
                if( result != null )
                {
                    Console.WriteLine($"{result}");
                }
                else
                {
                    Console.WriteLine($"{food} was left untouched.");
                }
            }
        }
    }
}