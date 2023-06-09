// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class ApiUserWithoutKey
    {
        internal static ApiUserWithoutKey DeserializeApiUserWithoutKey(JsonElement element)
        {
            int id = default;
            string name = default;
            string username = default;
            string email = default;
            string avatar = default;
            IReadOnlyList<ApiUserWithoutKeyOrganizationsItem> organizations = default;
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
                    List<ApiUserWithoutKeyOrganizationsItem> array = new List<ApiUserWithoutKeyOrganizationsItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ApiUserWithoutKeyOrganizationsItem.DeserializeApiUserWithoutKeyOrganizationsItem(item));
                    }
                    organizations = array;
                    continue;
                }
            }
            return new ApiUserWithoutKey(id, name, username, email, avatar, organizations);
        }
    }
}