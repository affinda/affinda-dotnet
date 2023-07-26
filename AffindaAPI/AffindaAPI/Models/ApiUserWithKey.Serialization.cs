// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class ApiUserWithKey
    {
        internal static ApiUserWithKey DeserializeApiUserWithKey(JsonElement element)
        {
            int id = default;
            string name = default;
            string username = default;
            string email = default;
            string avatar = default;
            IReadOnlyList<ApiUserWithKeyOrganizationsItem> organizations = default;
            string apiKey = default;
            Optional<string> apiKeyLastChars = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("username"))
                {
                    username = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("email"))
                {
                    email = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("avatar"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        avatar = null;
                        continue;
                    }
                    avatar = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("organizations"))
                {
                    List<ApiUserWithKeyOrganizationsItem> array = new List<ApiUserWithKeyOrganizationsItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ApiUserWithKeyOrganizationsItem.DeserializeApiUserWithKeyOrganizationsItem(item));
                    }
                    organizations = array;
                    continue;
                }
                if (property.NameEquals("apiKey"))
                {
                    apiKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("apiKeyLastChars"))
                {
                    apiKeyLastChars = property.Value.GetString();
                    continue;
                }
            }
            return new ApiUserWithKey(id, name, username, email, avatar, organizations, apiKey, apiKeyLastChars.Value);
        }
    }
}
