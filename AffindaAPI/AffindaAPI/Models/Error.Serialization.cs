// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class Error : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ErrorCode))
            {
                if (ErrorCode != null)
                {
                    writer.WritePropertyName("errorCode");
                    writer.WriteStringValue(ErrorCode);
                }
                else
                {
                    writer.WriteNull("errorCode");
                }
            }
            if (Optional.IsDefined(ErrorDetail))
            {
                if (ErrorDetail != null)
                {
                    writer.WritePropertyName("errorDetail");
                    writer.WriteStringValue(ErrorDetail);
                }
                else
                {
                    writer.WriteNull("errorDetail");
                }
            }
            writer.WriteEndObject();
        }

        internal static Error DeserializeError(JsonElement element)
        {
            Optional<string> errorCode = default;
            Optional<string> errorDetail = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("errorCode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        errorCode = null;
                        continue;
                    }
                    errorCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorDetail"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        errorDetail = null;
                        continue;
                    }
                    errorDetail = property.Value.GetString();
                    continue;
                }
            }
            return new Error(errorCode.Value, errorDetail.Value);
        }
    }
}
