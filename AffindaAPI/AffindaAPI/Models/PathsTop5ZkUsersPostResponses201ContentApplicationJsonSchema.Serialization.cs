// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class PathsTop5ZkUsersPostResponses201ContentApplicationJsonSchema
    {
        internal static PathsTop5ZkUsersPostResponses201ContentApplicationJsonSchema DeserializePathsTop5ZkUsersPostResponses201ContentApplicationJsonSchema(JsonElement element)
        {
            Optional<string> apiKey = default;
            Optional<string> id = default;
            Optional<string> name = default;
            string username = default;
            Optional<string> email = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("apiKey"))
                {
                    apiKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
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
            }
            return new PathsTop5ZkUsersPostResponses201ContentApplicationJsonSchema(id.Value, name.Value, username, email.Value, apiKey.Value);
        }
    }
}
