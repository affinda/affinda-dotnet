// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class JobDescriptionSearchDetailManagementLevel
    {
        internal static JobDescriptionSearchDetailManagementLevel DeserializeJobDescriptionSearchDetailManagementLevel(JsonElement element)
        {
            Optional<ManagementLevel?> level = default;
            Optional<bool> match = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("level"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        level = null;
                        continue;
                    }
                    level = property.Value.GetString().ToManagementLevel();
                    continue;
                }
                if (property.NameEquals("match"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    match = property.Value.GetBoolean();
                    continue;
                }
            }
            return new JobDescriptionSearchDetailManagementLevel(Optional.ToNullable(level), Optional.ToNullable(match));
        }
    }
}