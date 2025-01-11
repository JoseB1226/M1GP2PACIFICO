using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
    public float multiplier = 1.5f;
    public void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
            ThirdPersonMovement.speed *= multiplier;
            Destroy(gameObject);
        }
    }
}
