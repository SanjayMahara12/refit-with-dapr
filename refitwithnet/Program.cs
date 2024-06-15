// See https://aka.ms/new-console-template for more information



using Refit;
using refitwithdotnet.node;
using ConsoleTables;
using refitwithnet.dto;
var api = RestService.For<IUsersClient>("https://jsonplaceholder.typicode.com/");
var nodeapi = RestService.For<INode>("http://localhost:3000/");
try
{
    var users = await api.GetAll();
    ConsoleTable.From<User>(users)
                .Write(Format.Default);

    Console.WriteLine("/n result for the nodes in the grid");
    var nodes = await nodeapi.GetNodes();
    ConsoleTable.From<Node>(nodes).Write(Format.Default);
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
Console.ReadKey();
