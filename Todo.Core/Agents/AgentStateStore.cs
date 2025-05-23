﻿namespace Todo.Core.Agents;

public class AgentStateStore : IAgentStateStore
{
    private readonly Dictionary<string, AgentState> _agentState = new();

    public AgentState Get(string agentName)
    {
        if (_agentState.TryGetValue(agentName, out var agentState))
        {
            return agentState;
        }
        return new AgentState { SessionId = Guid.NewGuid().ToString(), TaskId = Guid.NewGuid().ToString() };
    }

    public void Update(string agentName, string sessionId, string taskId)
    {
        if (_agentState.TryGetValue(agentName, out var agentState))
        {
            agentState.SessionId = sessionId;
            agentState.TaskId = taskId;
        }
        else
        {
            _agentState[agentName] = new AgentState { SessionId = sessionId, TaskId = taskId };
        }
    }
}

public interface IAgentStateStore
{
    AgentState Get(string agentName);
    void Update(string agentName, string sessionId, string taskId);
}