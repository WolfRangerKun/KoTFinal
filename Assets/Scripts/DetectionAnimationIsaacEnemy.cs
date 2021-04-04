using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionAnimationIsaacEnemy : MonoBehaviour
{
    public IsaacEnemy iEnemy;
    public bool isWall;
    public bool isGround;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (isGround)
            {
                iEnemy.idle = false;
            }
        }

        if (other.CompareTag("IsaacEnemy"))
        {
            if (isWall)
            {
                iEnemy.idle = true;
                iEnemy.gameObject.GetComponent<Animator>().SetBool("Correr", false);
            }

        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("IsaacEnemy"))
        {
            if (isWall)
            {
                iEnemy.idle = false;
            }
        }
    }
}
