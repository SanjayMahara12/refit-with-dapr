# RefitWithDapr
Sample project to work with refit in .net
- cancellation token implementation
- refit 
- secret manager

- using refit package for easy access to any API and working with the response without much creation of
  http handler or a wrapper. output flat structured POCO out to console.
- using ConsoleTables package to present the data console terminal easily in customization table stuctures
- services
            .AddRefitClient<IUsersClient>()
            .ConfigureHttpClient(c => c.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/"));
    }).Build();
   //Refit provides us with two ways to instantiate a client, either by using the RestService class provided by Refit, 
     or by registering the Refit client with HttpClientFactory, and injecting the interface into a class constructor.
  //if we want to make our code more maintainable and testable then registration is good way to handle dependency
