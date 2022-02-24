// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FoaasOperationsResponse.cs" company="Alexander Zuev">
//   Copyright (C) Alexander Zuev. All rights reserved.
// </copyright>
// <summary>
//   Defines the Operations operation response type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Foaas.Client.Responses
{
    using System.Collections.Generic;

    /// <summary>
    /// Represents the Operations operation response type.
    /// </summary>
    public sealed class FoaasOperationsResponse
    {
        /// <summary>
        /// Gets or sets the list of operations.
        /// </summary>
        /// <value>
        /// The list of operations.
        /// </value>
        public IEnumerable<Operation> Operations
        {
            // ReSharper disable once UnusedAutoPropertyAccessor.Global
            get;

            set;
        }

        /// <summary>
        /// Defines a single operation.
        /// </summary>
        // ReSharper disable once ClassNeverInstantiated.Global
        public sealed class Operation
        {
            /// <summary>
            /// Gets or sets the operation name.
            /// </summary>
            /// <value>
            /// The operation name.
            /// </value>
            // ReSharper disable once UnusedMember.Global
            public string Name { get; set; }

            /// <summary>
            /// Gets or sets the operation URL.
            /// </summary>
            /// <value>
            /// The operation URL.
            /// </value>
            // ReSharper disable once UnusedMember.Global
            public string Url { get; set; }

            /// <summary>
            /// Gets or sets the fields for this operation.
            /// </summary>
            /// <value>
            /// The fields for this operation.
            /// </value>
            // ReSharper disable once UnusedMember.Global
            public IEnumerable<OperationField> Fields { get; set; }
        }

        /// <summary>
        /// Defines a single field of the operation.
        /// </summary>
        // ReSharper disable once ClassNeverInstantiated.Global
        public sealed class OperationField
        {
            /// <summary>
            /// Gets or sets the field name.
            /// </summary>
            /// <value>
            /// The field name.
            /// </value>
            // ReSharper disable once UnusedMember.Global
            public string Name { get; set; }

            /// <summary>
            /// Gets or sets the field.
            /// </summary>
            /// <value>
            /// The field.
            /// </value>
            // ReSharper disable once UnusedMember.Global
            public string Field { get; set; }
        }
    }
}
