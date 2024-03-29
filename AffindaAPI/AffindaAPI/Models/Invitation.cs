// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Affinda.API.Models
{
    /// <summary> The Invitation. </summary>
    public partial class Invitation
    {
        /// <summary> Initializes a new instance of Invitation. </summary>
        internal Invitation()
        {
        }

        /// <summary> Initializes a new instance of Invitation. </summary>
        /// <param name="identifier"> Uniquely identify an invitation. </param>
        /// <param name="organization"></param>
        /// <param name="email"> The email which the invitation is sent to. </param>
        /// <param name="role"></param>
        /// <param name="status"></param>
        /// <param name="expiryDate"> The date after which the invitation expires. Default is 10 days from now. </param>
        /// <param name="invitedBy"></param>
        /// <param name="respondedBy"></param>
        /// <param name="createdDt"></param>
        internal Invitation(string identifier, Organization organization, string email, OrganizationRole? role, InvitationStatus? status, DateTimeOffset? expiryDate, User invitedBy, InvitationRespondedBy respondedBy, DateTimeOffset? createdDt)
        {
            Identifier = identifier;
            Organization = organization;
            Email = email;
            Role = role;
            Status = status;
            ExpiryDate = expiryDate;
            InvitedBy = invitedBy;
            RespondedBy = respondedBy;
            CreatedDt = createdDt;
        }

        /// <summary> Uniquely identify an invitation. </summary>
        public string Identifier { get; }
        /// <summary> Gets the organization. </summary>
        public Organization Organization { get; }
        /// <summary> The email which the invitation is sent to. </summary>
        public string Email { get; }
        /// <summary> Gets the role. </summary>
        public OrganizationRole? Role { get; }
        /// <summary> Gets the status. </summary>
        public InvitationStatus? Status { get; }
        /// <summary> The date after which the invitation expires. Default is 10 days from now. </summary>
        public DateTimeOffset? ExpiryDate { get; }
        /// <summary> Gets the invited by. </summary>
        public User InvitedBy { get; }
        /// <summary> Gets the responded by. </summary>
        public InvitationRespondedBy RespondedBy { get; }
        /// <summary> Gets the created dt. </summary>
        public DateTimeOffset? CreatedDt { get; }
    }
}
