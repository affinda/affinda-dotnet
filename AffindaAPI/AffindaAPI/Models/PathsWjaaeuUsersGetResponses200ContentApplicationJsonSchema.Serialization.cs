// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class PathsWjaaeuUsersGetResponses200ContentApplicationJsonSchema
    {
        internal static PathsWjaaeuUsersGetResponses200ContentApplicationJsonSchema DeserializePathsWjaaeuUsersGetResponses200ContentApplicationJsonSchema(JsonElement element)
        {
            Optional<int> count = default;
            Optional<string> next = default;
            Optional<string> previous = default;
            Optional<IReadOnlyList<User>> results = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("count"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    count = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("next"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        next = null;
                        continue;
                    }
                    next = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("previous"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        previous = null;
                        continue;
                    }
                    previous = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("results"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<User> array = new List<User>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(User.DeserializeUser(item));
                    }
                    results = array;
                    continue;
                }
            }
            return new PathsWjaaeuUsersGetResponses200ContentApplicationJsonSchema(Optional.ToNullable(count), next.Value, previous.Value, Optional.ToList(results));
        }
    }
}