using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public GameObject winScreen, player, resetButtom;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            winScreen.SetActive(true);
            resetButtom.SetActive(true);
            Destroy(player);
        }
    }

    public void Reset()
    {
        SceneManager.LoadScene("SceneKoT");
    }

}
