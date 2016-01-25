﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.DocAsCode.MetadataSchemata
{
    using Newtonsoft.Json.Linq;

    public interface IWellknownMetadataValidator
    {
        ValidationResult Validate(string path, IMetadataDefinition definition, JToken value);
    }
}
