﻿namespace Todo.Core.Agents.A2A
{
    public class AgentTask
    {
        public List<Message> History {get; } = [];

        public List<AgentArtifact> Artifacts { get; } = [];

        public string TaskId { get; set; } = string.Empty;

        public string SessionId { get; set; } = string.Empty;

        public AgentTaskStatus Status { get; set; } = new AgentTaskStatus();
    }
}
