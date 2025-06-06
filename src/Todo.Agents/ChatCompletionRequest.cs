﻿using Microsoft.SemanticKernel.Agents;

namespace Todo.Agents
{
    public class ChatCompletionRequest
    {
        public string Message { get; init; } = string.Empty;

        public string SessionId { get; init; } = string.Empty;

        public string TaskId { get; init; } = string.Empty;

        public  ChatHistoryAgentThread ChatHistory { get; set; } = new();
    }
}
