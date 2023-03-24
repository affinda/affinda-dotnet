// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class Extractor
    {
        internal static Extractor DeserializeExtractor(JsonElement element)
        {
            string identifier = default;
            string name = default;
            string namePlural = default;
            Optional<ExtractorBaseExtractor> baseExtractor = default;
            Optional<Organization> organization = default;
            Optional<string> category = default;
            bool validatable = default;
            Optional<bool> isCustom = default;
            Optional<IReadOnlyList<FieldGroup>> fieldGroups = default;
            Optional<DateTimeOffset> createdDt = default;
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
                if (property.NameEquals("namePlural"))
                {
                    namePlural = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("baseExtractor"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        baseExtractor = null;
                        continue;
                    }
                    baseExtractor = ExtractorBaseExtractor.DeserializeExtractorBaseExtractor(property.Value);
                    continue;
                }
                if (property.NameEquals("organization"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        organization = null;
                        continue;
                    }
                    organization = Organization.DeserializeOrganization(property.Value);
                    continue;
                }
                if (property.NameEquals("category"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        category = null;
                        continue;
                    }
                    category = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("validatable"))
                {
                    validatable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isCustom"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isCustom = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("fieldGroups"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        fieldGroups = null;
                        continue;
                    }
                    List<FieldGroup> array = new List<FieldGroup>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FieldGroup.DeserializeFieldGroup(item));
                    }
                    fieldGroups = array;
                    continue;
                }
                if (property.NameEquals("createdDt"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    createdDt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new Extractor(identifier, name, namePlural, baseExtractor.Value, organization.Value, category.Value, validatable, Optional.ToNullable(isCustom), Optional.ToList(fieldGroups), Optional.ToNullable(createdDt));
        }
    }
}