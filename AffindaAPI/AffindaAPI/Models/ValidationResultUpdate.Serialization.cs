// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class ValidationResultUpdate : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Annotations))
            {
                writer.WritePropertyName("annotations");
                writer.WriteStartArray();
                foreach (var item in Annotations)
                {
                    writer.WriteNumberValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Passed))
            {
                if (Passed != null)
                {
                    writer.WritePropertyName("passed");
                    writer.WriteBooleanValue(Passed.Value);
                }
                else
                {
                    writer.WriteNull("passed");
                }
            }
            if (Optional.IsDefined(RuleSlug))
            {
                writer.WritePropertyName("ruleSlug");
                writer.WriteStringValue(RuleSlug);
            }
            if (Optional.IsDefined(Message))
            {
                writer.WritePropertyName("message");
                writer.WriteStringValue(Message);
            }
            if (Optional.IsDefined(Document))
            {
                writer.WritePropertyName("document");
                writer.WriteStringValue(Document);
            }
            writer.WriteEndObject();
        }
    }
}
