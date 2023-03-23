// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class WorkspaceUpdate : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Visibility))
            {
                writer.WritePropertyName("visibility");
                writer.WriteStringValue(Visibility.Value.ToString());
            }
            if (Optional.IsDefined(RejectInvalidDocuments))
            {
                writer.WritePropertyName("rejectInvalidDocuments");
                writer.WriteBooleanValue(RejectInvalidDocuments.Value);
            }
            if (Optional.IsDefined(RejectDuplicates))
            {
                writer.WritePropertyName("rejectDuplicates");
                writer.WriteStringValue(RejectDuplicates);
            }
            writer.WriteEndObject();
        }
    }
}
