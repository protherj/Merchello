﻿namespace Merchello.Web.Search
{
    /// <summary>
    /// Defines the CachedQueryProvider
    /// </summary>
    public interface ICachedQueryProvider
    {
        /// <summary>
        /// Gets the <see cref="ICachedInvoiceQuery"/>.
        /// </summary>
        ICachedInvoiceQuery Invoice { get; } 
    }
}