using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HingeControl : MonoBehaviour
{
    private HingeJoint hinge;
    private JointSpring hingeSpring;
    
    // Start is called before the first frame update
    void Start()
    {
        hinge = GetComponent<HingeJoint>();
        hingeSpring = hinge.spring;
    }

    // Update is called once per frame
    void Update()
    {
        
        
        /*If open set spring target position to open*/
        if (hinge.angle < -170) {
            hingeSpring.targetPosition = (float)-174.2604;
        }
    }
}
