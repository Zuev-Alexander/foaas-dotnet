// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FoaasClientConfiguration.cs" company="Alexander Zuev">
//   Copyright (C) Alexander Zuev. All rights reserved.
// </copyright>
// <summary>
//   Fuck Off as a Service client configuration.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Foaas.Client.Configuration
{
    /// <summary>
    /// Fuck Off as a Service client configuration.
    /// </summary>
    public sealed class FoaasClientConfiguration
    {
        /// <summary>
        /// Gets or sets the base URL.
        /// </summary>
        /// <value>
        /// The base URL.
        /// </value>
        public string BaseUrl { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the <see cref="FoaasClient" /> uses the ShoutCloud
        /// (ALL CAPS AS A SERVICE) service.
        /// </summary>
        /// <value>
        /// <c>true</c> if the <see cref="FoaasClient" /> uses the ShoutCloud (ALL CAPS AS A SERVICE) service;
        /// otherwise, <c>false</c>.
        /// </value>
        public bool ShoutCloud { get; set; }

        /// <summary>
        /// Gets or sets the language to translate to.
        /// </summary>
        /// <value>
        /// The language to translate to.
        /// </value>
        public string I18N { get; set; }
    }
}
