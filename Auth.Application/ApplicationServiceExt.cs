﻿using Core.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MVC.Service.Identities;

namespace Auth.Application;

public static class ApplicationServiceExt
{
    public static IServiceCollection AddApplicationService(this IServiceCollection services,
        IConfiguration configuration)
    {
        var assembly = typeof(ApplicationAssembly).Assembly;

        services.AddCoreApplicationService(assembly, configuration);

        services.AddScoped<IIdentityService, IdentityService>();


        return services;
    }
}