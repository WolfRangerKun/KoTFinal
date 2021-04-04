using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaponDetection : MonoBehaviour
{
    public GameObject detectionTapon1, detectionTapon2;
    public bool isTapon1;
    public bool isTapon2;
    public IsaacEnemy iEnemy;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("IsaacEnemy"))
        {
            if (isTapon1)
            {
                detectionTapon1.SetActive(false);
                iEnemy.tapon = true;
                detectionTapon2.SetActive(true);
            }
            else if (isTapon2)
            {
                detectionTapon2.SetActive(false);
                iEnemy.tapon = true;
                detectionTapon1.SetActive(true);
            }
        }
    }
}
