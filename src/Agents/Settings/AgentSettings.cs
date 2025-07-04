﻿namespace Agents.Settings;

public class AgentSettings
{
    public string Name { get; set; } = string.Empty;

    public string Type { get; set; } = string.Empty;

    public string Template { get; set; } = string.Empty;

    public string ServiceId { get; set; } = string.Empty;

    public string ToolCallBehavior { get; set; } = string.Empty;

    public string Temperature { get; set; } = string.Empty;

    public List<string> Plugins { get; set; } = [];
}