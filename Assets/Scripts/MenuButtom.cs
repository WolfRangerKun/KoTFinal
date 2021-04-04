using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtom : MonoBehaviour
{
    public void FindAMatch()
    {
        SceneManager.LoadScene("SceneKoT");
    }
}
