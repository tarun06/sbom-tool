﻿using System.Text.Json.Serialization;
using Microsoft.Sbom.Spdx3_0.Core.Enums;

namespace Microsoft.Sbom.Spdx3_0.Core;
public record Hash(HashAlgorithm Algorithm, string HashValue, string? Comment = null)
    : IntegrityMethod(Comment)
{
    [JsonPropertyName("@type")]
    public string Type { get; } = "Hash";
}