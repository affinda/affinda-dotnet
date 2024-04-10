// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class ValidationResultCreate : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("annotations");
            writer.WriteStartArray();
            foreach (var item in Annotations)
            {
                writer.WriteNumberValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(Passed))
            {
                writer.WritePropertyName("passed");
                writer.WriteBooleanValue(Passed.Value);
            }
            writer.WritePropertyName("ruleSlug");
            writer.WriteStringValue(RuleSlug);
            writer.WritePropertyName("message");
            writer.WriteStringValue(Message);
            writer.WritePropertyName("document");
            writer.WriteStringValue(Document);
            writer.WriteEndObject();
        }
    }
}