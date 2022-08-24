// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class JobDescriptionSearchDetailExperience
    {
        internal static JobDescriptionSearchDetailExperience DeserializeJobDescriptionSearchDetailExperience(JsonElement element)
        {
            Optional<int?> minimumExperience = default;
            Optional<int?> maximumExperience = default;
            Optional<bool> match = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("minimumExperience"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        minimumExperience = null;
                        continue;
                    }
                    minimumExperience = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maximumExperience"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        maximumExperience = null;
                        continue;
                    }
                    maximumExperience = property.Value.GetInt32();
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
            return new JobDescriptionSearchDetailExperience(Optional.ToNullable(minimumExperience), Optional.ToNullable(maximumExperience), Optional.ToNullable(match));
        }
    }
}
