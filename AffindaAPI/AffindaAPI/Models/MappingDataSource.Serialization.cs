// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class MappingDataSource
    {
        internal static MappingDataSource DeserializeMappingDataSource(JsonElement element)
        {
            string identifier = default;
            Optional<string> name = default;
            string keyProperty = default;
            string displayProperty = default;
            string organization = default;
            string workspace = default;
            Optional<object> schema = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identifier"))
                {
                    identifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        name = null;
                        continue;
                    }
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyProperty"))
                {
                    keyProperty = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayProperty"))
                {
                    displayProperty = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("organization"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        organization = null;
                        continue;
                    }
                    organization = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workspace"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        workspace = null;
                        continue;
                    }
                    workspace = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("schema"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    schema = property.Value.GetObject();
                    continue;
                }
            }
            return new MappingDataSource(identifier, name.Value, keyProperty, displayProperty, organization, workspace, schema.Value);
        }
    }
}
