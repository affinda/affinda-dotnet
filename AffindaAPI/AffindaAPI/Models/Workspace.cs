// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Affinda.API.Models
{
    /// <summary> The Workspace. </summary>
    public partial class Workspace
    {
        /// <summary> Initializes a new instance of Workspace. </summary>
        /// <param name="identifier"> Uniquely identify a workspace. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="identifier"/> is null. </exception>
        internal Workspace(string identifier)
        {
            if (identifier == null)
            {
                throw new ArgumentNullException(nameof(identifier));
            }

            Identifier = identifier;
            Collections = new ChangeTrackingList<WorkspaceCollectionsItem>();
            Members = new ChangeTrackingList<User>();
        }

        /// <summary> Initializes a new instance of Workspace. </summary>
        /// <param name="identifier"> Uniquely identify a workspace. </param>
        /// <param name="organization"></param>
        /// <param name="name"></param>
        /// <param name="visibility"> Visibility &quot;organization&quot; means everyone in the organization can access the workspace. Visibility &quot;private&quot; means only people explicitly added can access the workspace. </param>
        /// <param name="collections"></param>
        /// <param name="rejectInvalidDocuments"> If true, the uploaded document will be rejected if it&apos;s of the wrong document type, or if its document type cannot be determined. No credits will be consumed. </param>
        /// <param name="members"></param>
        /// <param name="unvalidatedDocsCount"> Number of unvalidated documents in the workspace. </param>
        /// <param name="confirmedDocsCount"> Number of validated documents in the workspace. </param>
        internal Workspace(string identifier, Organization organization, string name, WorkspaceVisibility? visibility, IReadOnlyList<WorkspaceCollectionsItem> collections, bool? rejectInvalidDocuments, IReadOnlyList<User> members, int? unvalidatedDocsCount, int? confirmedDocsCount)
        {
            Identifier = identifier;
            Organization = organization;
            Name = name;
            Visibility = visibility;
            Collections = collections;
            RejectInvalidDocuments = rejectInvalidDocuments;
            Members = members;
            UnvalidatedDocsCount = unvalidatedDocsCount;
            ConfirmedDocsCount = confirmedDocsCount;
        }

        /// <summary> Uniquely identify a workspace. </summary>
        public string Identifier { get; }
        /// <summary> Gets the organization. </summary>
        public Organization Organization { get; }
        /// <summary> Gets the name. </summary>
        public string Name { get; }
        /// <summary> Visibility &quot;organization&quot; means everyone in the organization can access the workspace. Visibility &quot;private&quot; means only people explicitly added can access the workspace. </summary>
        public WorkspaceVisibility? Visibility { get; }
        /// <summary> Gets the collections. </summary>
        public IReadOnlyList<WorkspaceCollectionsItem> Collections { get; }
        /// <summary> If true, the uploaded document will be rejected if it&apos;s of the wrong document type, or if its document type cannot be determined. No credits will be consumed. </summary>
        public bool? RejectInvalidDocuments { get; }
        /// <summary> Gets the members. </summary>
        public IReadOnlyList<User> Members { get; }
        /// <summary> Number of unvalidated documents in the workspace. </summary>
        public int? UnvalidatedDocsCount { get; }
        /// <summary> Number of validated documents in the workspace. </summary>
        public int? ConfirmedDocsCount { get; }
    }
}
