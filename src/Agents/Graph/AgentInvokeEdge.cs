﻿namespace Agents.Graph
{
    public class AgentInvokeEdge(string targetNode) : IEdge
    {
        public string TargetNode { get; set; } = targetNode;

        public bool CanInvoke(NodeState state)
        {
            return state.Route == TargetNode;
        }
    }
}
