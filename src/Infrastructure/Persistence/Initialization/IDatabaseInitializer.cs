﻿using Template.Infrastructure.Multitenancy;

namespace Template.Infrastructure.Persistence.Initialization;
internal interface IDatabaseInitializer
{
    Task InitializeDatabasesAsync(CancellationToken cancellationToken);
    Task InitializeApplicationDbForTenantAsync(FSHTenantInfo tenant, CancellationToken cancellationToken);
}