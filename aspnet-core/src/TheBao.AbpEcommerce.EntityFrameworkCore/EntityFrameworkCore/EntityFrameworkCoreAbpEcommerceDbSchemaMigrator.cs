﻿using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TheBao.AbpEcommerce.Data;
using Volo.Abp.DependencyInjection;

namespace TheBao.AbpEcommerce.EntityFrameworkCore;

public class EntityFrameworkCoreAbpEcommerceDbSchemaMigrator
    : IAbpEcommerceDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreAbpEcommerceDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the AbpEcommerceDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<AbpEcommerceDbContext>()
            .Database
            .MigrateAsync();
    }
}
