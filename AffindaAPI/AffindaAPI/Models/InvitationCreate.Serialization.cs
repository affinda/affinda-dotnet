// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class InvitationCreate : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("organization");
            writer.WriteStringValue(Organization);
            writer.WritePropertyName("email");
            writer.WriteStringValue(Email);
            writer.WritePropertyName("role");
            writer.WriteStringValue(Role.ToString());
            writer.WriteEndObject();
        }
    }
}
