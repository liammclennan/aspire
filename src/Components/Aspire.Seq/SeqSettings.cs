// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using OpenTelemetry.Exporter;

namespace Aspire.Seq;

/// <summary>
/// Provides the client configuration settings for connecting telemetry to a Seq server.
/// </summary>
public sealed class SeqSettings
{
    /// <summary>
    /// Gets or sets a boolean value that indicates whetherthe Seq server health check is enabled or not.
    /// </summary>
    public bool HealthChecks { get; set; } = true;

    /// <summary>
    /// Gets or sets a Seq <i>API key</i> that authenticates the client to the Seq server.
    /// </summary>
    public string? ApiKey { get; set; }

    /// <summary>
    /// Gets or sets the base URL of the Seq server (including protocol and port). E.g. "https://example.seq.com:6789"
    /// </summary>
    public string? ServerUrl { get; set; }

    /// <summary>
    /// Gets OTLP exporter options for logs.
    /// </summary>
    public OtlpExporterOptions Logs
    {
        get;
        private set;
    } = new ();

    /// <summary>
    /// Gets OTLP exporter options for traces.
    /// </summary>
    public OtlpExporterOptions Traces
    {
        get;
        private set;
    } = new ();

}
