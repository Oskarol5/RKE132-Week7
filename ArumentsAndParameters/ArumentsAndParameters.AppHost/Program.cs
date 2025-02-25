var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.ArumentsAndParameters_ApiService>("apiservice");

builder.AddProject<Projects.ArumentsAndParameters_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
