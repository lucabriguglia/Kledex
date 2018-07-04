﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OpenCqrs.Extensions;
using OpenCqrs.Store.EF.Extensions;

namespace OpenCqrs.Store.EF.SqlServer
{
    public static class ServiceCollectionExtensions
    {
        public static IOpenCqrsBuilder AddSqlServerProvider(this IOpenCqrsBuilder builder, IConfiguration configuration)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));

            if (configuration == null)
                throw new ArgumentNullException(nameof(configuration));

            builder.AddEFProvider(configuration);

            var connectionString = configuration.GetSection(Constants.DomainDbConfigurationConnectionString).Value;

            builder.Services.AddDbContext<DomainDbContext>(options =>
                options.UseSqlServer(connectionString));

            builder.Services.AddTransient<IDatabaseProvider, SqlServerDatabaseProvider>();

            return builder;
        }
    }
}
