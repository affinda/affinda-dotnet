// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class Components1Rpp8I6SchemasJobdescriptiondataupdateAdditionalproperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WriteEndObject();
        }

        internal static Components1Rpp8I6SchemasJobdescriptiondataupdateAdditionalproperties DeserializeComponents1Rpp8I6SchemasJobdescriptiondataupdateAdditionalproperties(JsonElement element)
        {
            foreach (var property in element.EnumerateObject())
            {
            }
            return new Components1Rpp8I6SchemasJobdescriptiondataupdateAdditionalproperties();
        }
    }
}
