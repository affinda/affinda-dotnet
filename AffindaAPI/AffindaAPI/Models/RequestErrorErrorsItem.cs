// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Affinda.API.Models
{
    /// <summary> The RequestErrorErrorsItem. </summary>
    internal partial class RequestErrorErrorsItem
    {
        /// <summary> Initializes a new instance of RequestErrorErrorsItem. </summary>
        /// <param name="attr"></param>
        /// <param name="code"></param>
        /// <param name="detail"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="code"/> or <paramref name="detail"/> is null. </exception>
        internal RequestErrorErrorsItem(string attr, string code, string detail)
        {
            if (code == null)
            {
                throw new ArgumentNullException(nameof(code));
            }
            if (detail == null)
            {
                throw new ArgumentNullException(nameof(detail));
            }

            Attr = attr;
            Code = code;
            Detail = detail;
        }

        /// <summary> Gets the attr. </summary>
        public string Attr { get; }
        /// <summary> Gets the code. </summary>
        public string Code { get; }
        /// <summary> Gets the detail. </summary>
        public string Detail { get; }
    }
}
