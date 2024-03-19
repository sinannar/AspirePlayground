var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.WeatherForecastApi>("weatherforecastapi");

builder.AddProject<Projects.MenuApi>("menuapi");

builder.Build().Run();
