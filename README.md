# RefitWithDapr
Sample project to work with refit in .net
- refit - Refit reduces the amount of code required to call APIs by eliminating the need to manually construct HTTP requests and handle responses.<br/>
- using refit package for easy access to any API and working with the response without much creation of
  http handler or a wrapper. output flat structured POCO out to console.<br/>
- using ConsoleTables package to present the data console terminal easily in customization table stuctures
- services<br/>
            .AddRefitClient<IUsersClient>()<br/>
            .ConfigureHttpClient(c => c.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/"));<br/>
    }).Build();<br/>
- Refit provides us with two ways to instantiate a client, either by using the RestService class provided by Refit, or by registering the Refit client with HttpClientFactory, and injecting the interface into a class constructor.<br/>
- if we want to make our code more maintainable and testable then registration is good way to handle dependency<br/>
