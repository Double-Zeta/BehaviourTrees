using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TheKiwiCoder;

public class moveToTarget : ActionNode
{
    public float speed = 5;
    public float stoppingDistance = 0.1f;
    public bool updateRotation = true;
    public float acceleration = 40.0f;
    public float tolerance = 1.0f;
    //public GameObject targetPos;

    protected override void OnStart()
    {
        //blackboard.moveToTarget = targetPos.transform.position;
        context.agent.stoppingDistance = stoppingDistance;
        context.agent.speed = speed;
        context.agent.destination = blackboard.moveToTarget.transform.position;
        context.agent.updateRotation = updateRotation;
        context.agent.acceleration = acceleration;
    }

    protected override void OnStop() {
    }

    protected override State OnUpdate() {
        if (context.agent.pathPending)
        {
            return State.Running;
        }

        if (context.agent.remainingDistance < tolerance)
        {
            return State.Success;
        }

        if (context.agent.pathStatus == UnityEngine.AI.NavMeshPathStatus.PathInvalid)
        {
            return State.Failure;
        }
        return State.Running;
    }
}
