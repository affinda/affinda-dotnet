// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class DataPoint
    {
        internal static DataPoint DeserializeDataPoint(JsonElement element)
        {
            string identifier = default;
            string name = default;
            Optional<string> slug = default;
            Optional<string> description = default;
            AnnotationContentType annotationContentType = default;
            Optional<Organization> organization = default;
            int? extractor = default;
            Optional<bool> multiple = default;
            Optional<bool> noRect = default;
            Optional<IReadOnlyList<DataPointChoicesItem>> choices = default;
            Optional<IReadOnlyList<DataPoint>> children = default;
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
                if (property.NameEquals("annotationContentType"))
                {
                    annotationContentType = new AnnotationContentType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("organization"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    organization = Organization.DeserializeOrganization(property.Value);
                    continue;
                }
                if (property.NameEquals("extractor"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        extractor = null;
                        continue;
                    }
                    extractor = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("multiple"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    multiple = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("noRect"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    noRect = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("choices"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<DataPointChoicesItem> array = new List<DataPointChoicesItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataPointChoicesItem.DeserializeDataPointChoicesItem(item));
                    }
                    choices = array;
                    continue;
                }
                if (property.NameEquals("children"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<DataPoint> array = new List<DataPoint>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeserializeDataPoint(item));
                    }
                    children = array;
                    continue;
                }
            }
            return new DataPoint(identifier, name, slug.Value, description.Value, annotationContentType, organization.Value, extractor, Optional.ToNullable(multiple), Optional.ToNullable(noRect), Optional.ToList(choices), Optional.ToList(children));
        }
    }
}
