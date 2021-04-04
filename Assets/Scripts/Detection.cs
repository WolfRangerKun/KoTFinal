using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detection : MonoBehaviour
{
    public GameObject detectionIsaac1, detectionIsaac2;
    public bool isWalls = true;
    public static bool isWall;
    public static bool isGrounded;
    public bool isIsaacEnemy1;
    public bool isIsaacEnemy2;
    public bool isAnimationWall;
    public bool isAnimationGround;
    public IsaacEnemy iEnemy;
    public PlayerMovement pMovement;


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Walls"))
        {
            if (isWalls)
            {
                isWall = true;
            }
            else isGrounded = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Walls"))
        {
            if (isWalls)
            {
                isWall = false;
            }
            else isGrounded = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

            if (isIsaacEnemy1 && pMovement.movement == true)
            {

                iEnemy.corrutina2 = false;
                iEnemy.corrutina1 = true;
                iEnemy.playerDetection2 = false;
                iEnemy.playerDetection1 = true;
                detectionIsaac1.SetActive(false);
                detectionIsaac2.SetActive(true);
            }
            else if (isIsaacEnemy2 && pMovement.movement == false)
            {

                iEnemy.corrutina2 = true;
                iEnemy.playerDetection1 = false;
                iEnemy.playerDetection2 = true;
                detectionIsaac2.SetActive(false);
                detectionIsaac1.SetActive(true);
            }
        }
    }
}

