﻿using Microsoft.SemanticKernel.Agents;

namespace Todo.Agents.Communication
{
    public class ChatCompletionResponse
    {
        public string Message { get; init; } = string.Empty;

        public string SessionId { get; init; } = string.Empty;

        public ChatHistoryAgentThread ChatHistory { get; set; } = new ChatHistoryAgentThread();
    }
}
