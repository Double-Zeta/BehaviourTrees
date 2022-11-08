using System.Collections;
using System.Collections.Generic;
using TheKiwiCoder;
using UnityEngine;

public class AIVision : MonoBehaviour
{
   public BehaviourTreeRunner behaviourTreeRunner;

    
    public GameObject targetCreature;

    // Start is called before the first frame update
    void Start()
    {
        behaviourTreeRunner.tree.blackboard.moveToTarget = targetCreature;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
