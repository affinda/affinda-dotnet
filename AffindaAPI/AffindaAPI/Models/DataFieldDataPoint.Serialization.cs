// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class DataFieldDataPoint
    {
        internal static DataFieldDataPoint DeserializeDataFieldDataPoint(JsonElement element)
        {
            string identifier = default;
            string name = default;
            string slug = default;
            string description = default;
            AnnotationContentType type = default;
            bool multiple = default;
            bool noRect = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identifier"))
                {
                    identifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("slug"))
                {
                    slug = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        description = null;
                        continue;
                    }
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new AnnotationContentType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("multiple"))
                {
                    multiple = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("noRect"))
                {
                    noRect = property.Value.GetBoolean();
                    continue;
                }
            }
            return new DataFieldDataPoint(identifier, name, slug, description, type, multiple, noRect);
        }
    }
}
