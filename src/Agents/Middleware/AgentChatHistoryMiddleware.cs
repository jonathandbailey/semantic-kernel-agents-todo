﻿using Microsoft.SemanticKernel.Agents;

namespace Agents.Middleware
{
    public  class AgentChatHistoryMiddleware(IAgentChatHistoryProvider agentChatHistoryProvider, string agentName) : IAgentMiddleware
    {
        public async Task<AgentState> InvokeAsync(AgentState state, AgentDelegate next)
        {
            var sessionId = state.SessionId.ToString();
            
            var chatHistory = await agentChatHistoryProvider.LoadChatHistoryAsync(agentName, sessionId);

            AppendChatHistory(chatHistory, state);

            var response = await next(state);

            chatHistory = state.AgentThread;

            await agentChatHistoryProvider.SaveChatHistoryAsync(chatHistory, agentName, sessionId);

            return response;
        }

        private void AppendChatHistory(ChatHistoryAgentThread chatHistory, AgentState agentState)
        {
            var stateChatHistory = agentState.AgentThread;

            foreach (var message in chatHistory.ChatHistory)
            {
                stateChatHistory.ChatHistory.AddMessage(message.Role, message.Content!);
            }
        }
    }
}
