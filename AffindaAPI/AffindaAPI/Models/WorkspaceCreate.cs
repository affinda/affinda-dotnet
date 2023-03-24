// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Affinda.API.Models
{
    /// <summary> The WorkspaceCreate. </summary>
    public partial class WorkspaceCreate
    {
        /// <summary> Initializes a new instance of WorkspaceCreate. </summary>
        /// <param name="organization"> Uniquely identify an organization. </param>
        /// <param name="name"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="organization"/> or <paramref name="name"/> is null. </exception>
        public WorkspaceCreate(string organization, string name)
        {
            if (organization == null)
            {
                throw new ArgumentNullException(nameof(organization));
            }
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Organization = organization;
            Name = name;
        }

        /// <summary> Uniquely identify an organization. </summary>
        public string Organization { get; }
        /// <summary> Gets the name. </summary>
        public string Name { get; }
        /// <summary> Visibility &quot;organization&quot; means everyone in the organization can access the workspace. Visibility &quot;private&quot; means only people explicitly added can access the workspace. </summary>
        public WorkspaceVisibility? Visibility { get; set; }
        /// <summary> If true, the uploaded document will be rejected if it&apos;s of the wrong document type, or if its document type cannot be determined. No credits will be consumed. </summary>
        public bool? RejectInvalidDocuments { get; set; }
        /// <summary> If &quot;true&quot;, parsing will fail when the uploaded document is duplicate of an existing document, no credits will be consumed. If &quot;false&quot; (default), will parse the document normally whether its a duplicate or not. </summary>
        public string RejectDuplicates { get; set; }
    }
}