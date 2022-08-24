// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class ResumeSearchDetailJobTitleValueItem
    {
        internal static ResumeSearchDetailJobTitleValueItem DeserializeResumeSearchDetailJobTitleValueItem(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> startDate = default;
            Optional<string> endDate = default;
            Optional<string> companyName = default;
            Optional<bool> match = default;
            foreach (var property in element.EnumerateObject())
            {
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
                if (property.NameEquals("startDate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        startDate = null;
                        continue;
                    }
                    startDate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endDate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        endDate = null;
                        continue;
                    }
                    endDate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("companyName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        companyName = null;
                        continue;
                    }
                    companyName = property.Value.GetString();
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
            return new ResumeSearchDetailJobTitleValueItem(name.Value, startDate.Value, endDate.Value, companyName.Value, Optional.ToNullable(match));
        }
    }
}