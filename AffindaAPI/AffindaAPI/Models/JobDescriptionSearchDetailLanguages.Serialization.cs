// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class JobDescriptionSearchDetailLanguages
    {
        internal static JobDescriptionSearchDetailLanguages DeserializeJobDescriptionSearchDetailLanguages(JsonElement element)
        {
            Optional<IReadOnlyList<ResumeSearchParametersSkill>> missing = default;
            Optional<IReadOnlyList<JobDescriptionSearchDetailLanguagesValueItem>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("missing"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ResumeSearchParametersSkill> array = new List<ResumeSearchParametersSkill>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResumeSearchParametersSkill.DeserializeResumeSearchParametersSkill(item));
                    }
                    missing = array;
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<JobDescriptionSearchDetailLanguagesValueItem> array = new List<JobDescriptionSearchDetailLanguagesValueItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JobDescriptionSearchDetailLanguagesValueItem.DeserializeJobDescriptionSearchDetailLanguagesValueItem(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new JobDescriptionSearchDetailLanguages(Optional.ToList(missing), Optional.ToList(value));
        }
    }
}
