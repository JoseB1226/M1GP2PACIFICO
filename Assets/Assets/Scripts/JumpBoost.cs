using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBoost : MonoBehaviour
{
    public float multiplier = 2f;

    public void OnTriggerEnter(Collider other)
    {
        if (other.name == "player")
        {

        }
        ThirdPersonMovement.jumpHeight *= multiplier;
        Destroy(gameObject);
    }
}



