using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class IsaacEnemy : MonoBehaviour
{
    public GameObject alert;
    public float speed = 2;
    public float jumpForce = 6.5f;
    Rigidbody2D rbody2D;
    public bool playerDetection1;
    public bool playerDetection2;
    public bool tapon;
    public bool corrutina1;
    public bool corrutina2;

    public bool idle;

    public float aniDuration;
    public Ease animEase;
    public int loops;
    void Start()
    {
        rbody2D = GetComponent<Rigidbody2D>();

        idle = true;

        StartCoroutine(Idle());

    }

    void Update()
    {
        if (idle == false)
        {
            gameObject.GetComponent<Animator>().SetBool("Correr", true);
        }


            if (playerDetection1)
            {
                loops = 0;

                if (corrutina1)
                {
                    StartCoroutine(Alert1());
                    corrutina1 = false;
                }
                gameObject.GetComponent<SpriteRenderer>().flipX = true;
                rbody2D.velocity = new Vector2(-speed, rbody2D.velocity.y);
            }


            if (playerDetection2)
            {

                if (corrutina2)
                {
                    StartCoroutine(Alert2());
                    corrutina2 = false;
                }
                gameObject.GetComponent<SpriteRenderer>().flipX = false;
                rbody2D.velocity = new Vector2(speed, rbody2D.velocity.y);
            }

            if (tapon)
            {
                rbody2D.velocity = new Vector2(rbody2D.velocity.x, jumpForce);
                gameObject.GetComponent<Animator>().SetTrigger("Saltar");
                tapon = false;
            }

    }

    private void FixedUpdate()
    {
        if (loops == 0)
        {
            StopCoroutine(Idle());
            DOTween.CompleteAll();
        }
    }

    IEnumerator Alert1()
    {
        alert.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        alert.SetActive(false);
    }
    IEnumerator Alert2()
    {
        alert.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        alert.SetActive(false);
    }

    IEnumerator Idle()
    {
        yield return new WaitForSeconds(0.5f);
        transform.DOMoveX(2.8f, aniDuration).SetEase(animEase).SetLoops(loops, LoopType.Yoyo);
    }

}
