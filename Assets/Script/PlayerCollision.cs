using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement Move;

    void OnCollisionEnter(UnityEngine.Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "Obstacle")
        {
            Move.enabled = false;
            FindObjectOfType<GameManager>().GameOver();
        }


    }
}
