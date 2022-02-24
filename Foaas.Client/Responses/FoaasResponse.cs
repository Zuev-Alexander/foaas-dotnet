// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FoaasResponse.cs" company="Alexander Zuev">
//   Copyright (C) Alexander Zuev. All rights reserved.
// </copyright>
// <summary>
//   Defines the response from a Fuck Off as a Service operation.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Foaas.Client.Responses
{
    /// <summary>
    /// Defines the response from a Fuck Off as a Service operation.
    /// </summary>
    public sealed class FoaasResponse
    {
        /// <summary>
        /// Gets or sets the operation response message.
        /// </summary>
        /// <value>
        /// The operation response message.
        /// </value>
        public string Message
        {
            get;

            // ReSharper disable once UnusedAutoPropertyAccessor.Global
            set;
        }

        /// <summary>
        /// Gets or sets the operation response subtitle.
        /// </summary>
        /// <value>
        /// The operation response subtitle.
        /// </value>
        public string Subtitle
        {
            get;

            // ReSharper disable once UnusedAutoPropertyAccessor.Global
            set;
        }
    }
}
