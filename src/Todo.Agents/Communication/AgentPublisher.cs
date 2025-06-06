﻿using MediatR;
using Todo.Core.A2A;

namespace Todo.Agents.Communication
{
    public class AgentPublisher(IMediator mediator) : IAgentPublisher
    {
        public async Task<SendTaskResponse> Send(SendTaskRequest sendTaskRequest)
        {
            return await mediator.Send(sendTaskRequest);
        }
    }
    public interface IAgentPublisher
    {
        Task<SendTaskResponse> Send(SendTaskRequest sendTaskRequest);
    }
}
