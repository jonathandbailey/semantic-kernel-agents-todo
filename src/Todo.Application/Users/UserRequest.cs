﻿using MediatR;
using Todo.Application.Dto;
using Todo.Core.A2A;

namespace Todo.Application.Users
{
    public class UserRequest : IRequest<UserResponseDto>
    {
        public Guid UserId { get; init; }

        public required string Message { get; set; }

        public string? TaskId { get; set; }

        public string? SessionId { get; set; }

        public Guid VacationPlanId { get; set; } = Guid.Empty;

        public string Source { get; set; } = string.Empty;

        public required SendTaskRequest SendTaskRequest { get; init; }
    }
}
