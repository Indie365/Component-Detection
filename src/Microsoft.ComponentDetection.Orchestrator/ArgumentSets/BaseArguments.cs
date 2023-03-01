﻿namespace Microsoft.ComponentDetection.Orchestrator.ArgumentSets;
using System;
using CommandLine;
using Serilog.Events;

public class BaseArguments : IScanArguments
{
    [Option("Debug", Required = false, HelpText = "Wait for debugger on start")]
    public bool Debug { get; set; }

    [Option("DebugTelemetry", Required = false, HelpText = "Used to output all telemetry events to the console.")]
    public bool DebugTelemetry { get; set; }

    [Option("CorrelationId", Required = false, HelpText = "Identifier used to correlate all telemetry for a given execution. If not provided, a new GUID will be generated.")]
    public Guid CorrelationId { get; set; }

    [Option("LogLevel", HelpText = "Flag indicating what level of logging to output to console during execution. Options are: Verbose, Debug, Information, Warning, Error, or Fatal.", Default = LogEventLevel.Information)]
    public LogEventLevel LogLevel { get; set; }

    [Option("Timeout", Required = false, HelpText = "An integer representing the time limit (in seconds) before detection is cancelled")]
    public int Timeout { get; set; }

    [Option("Output", Required = false, HelpText = "Output path for log files. Defaults to %TMP%")]
    public string Output { get; set; }
}
