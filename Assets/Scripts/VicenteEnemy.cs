using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VicenteEnemy : MonoBehaviour
{
    public Transform theTransform;
    public Transform ref1, ref2, ref3, ref4, ref5, ref6, ref7, ref8, ref9, ref10, ref11;
    public Transform target;
    public float speed = 3;
    public Animator Cangrejo;
    public bool ida;
    public bool vuelta;
    public bool suelo, techo, paredIzq, paredDer;
    private void Start()
    {
        target = ref1;
        ida = true;
        vuelta = false;
    }
    private void Update()
    {
        if (ida == true)
        {
            Ida();
        }

        if (vuelta == true)
        {
            Vuelta();
        }

        if(suelo == true)
        {
            Suelo();
        }

        if(techo == true)
        {
            Techo();
        }

        if(paredIzq == true)
        {
            ParedIzq();
        }

        if(paredDer == true)
        {
            ParedDer();
        }
    }
    private void Ida()
    {
        if (Vector3.Distance(theTransform.position, target.position) > 0.1f)
        {
            theTransform.position = Vector3.MoveTowards(theTransform.position, target.position, speed * Time.deltaTime);
        }
        else
        {
            if (target == ref1)
            {
                target = ref2;
                paredDer = true;
                paredIzq = false;
                suelo = false;
                techo = false;
            }
            else if (target == ref2)
            {
                target = ref3;
                paredDer = false;
                paredIzq = false;
                suelo = true;
                techo = false;
            }
            else if (target == ref3)
            {
                target = ref4;
                paredDer = false;
                paredIzq = true;
                suelo = false;
                techo = false;
            }
            else if (target == ref4)
            {
                target = ref5;
                paredDer = false;
                paredIzq = false;
                suelo = true;
                techo = false;
            }
            else if (target == ref5)
            {
                target = ref6;
                paredDer = true;
                paredIzq = false;
                suelo = false;
                techo = false;
            }
            else if (target == ref6)
            {
                target = ref7;
                paredDer = false;
                paredIzq = false;
                suelo = true;
                techo = false;
            }
            else if (target == ref7)
            {
                target = ref8;
                paredDer = false;
                paredIzq = true;
                suelo = false;
                techo = false;
            }
            else if (target == ref8)
            {
                target = ref9;
                paredDer = false;
                paredIzq = false;
                suelo = false;
                techo = true;
            }
            else if (target == ref9)
            {
                target = ref10;
                paredDer = false;
                paredIzq = true;
                suelo = false;
                techo = false;
            }
            else if (target == ref10)
            {
                target = ref11;
                paredDer = false;
                paredIzq = false;
                suelo = true;
                techo = false;
                ida = false;
                vuelta = true;
            }
        }
    }

    private void Vuelta()
    {
        if (Vector3.Distance(theTransform.position, target.position) > 0.1f)
        {
            theTransform.position = Vector3.MoveTowards(theTransform.position, target.position, speed * Time.deltaTime);
        }
        else
        {
            if (target == ref11)
            {
                target = ref10;
                paredDer = false;
                paredIzq = false;
                suelo = true;
                techo = false;
            }
            else if (target == ref10)
            {
                target = ref9;
                paredDer = false;
                paredIzq = true;
                suelo = false;
                techo = false;
            }
            else if (target == ref9)
            {
                target = ref8;
                paredDer = false;
                paredIzq = false;
                suelo = false;
                techo = true;
            }
            else if (target == ref8)
            {
                target = ref7;
                paredDer = false;
                paredIzq = true;
                suelo = false;
                techo = false;
            }
            else if (target == ref7)
            {
                target = ref6;
                paredDer = false;
                paredIzq = false;
                suelo = true;
                techo = false;
            }
            else if (target == ref6)
            {
                target = ref5;
                paredDer = true;
                paredIzq = false;
                suelo = false;
                techo = false;
            }
            else if (target == ref5)
            {
                target = ref4;
                paredDer = false;
                paredIzq = false;
                suelo = true;
                techo = false;
            }
            else if (target == ref4)
            {
                target = ref3;
                paredDer = false;
                paredIzq = true;
                suelo = false;
                techo = false;
            }
            else if (target == ref3)
            {
                target = ref2;
                paredDer = false;
                paredIzq = false;
                suelo = true;
                techo = false;
            }
            else if (target == ref2)
            {
                target = ref1;
                paredDer = true;
                paredIzq = false;
                suelo = false;
                techo = false;
                ida = true;
                vuelta = false;
            }
        }
    }

    private void Suelo()
    {
        gameObject.GetComponent<Animator>().SetBool("Suelo", true);
        gameObject.GetComponent<Animator>().SetBool("Techo", false);
        gameObject.GetComponent<Animator>().SetBool("Pared_Izq", false);
        gameObject.GetComponent<Animator>().SetBool("Pared_Der", false);
    }
    private void Techo()
    {
        gameObject.GetComponent<Animator>().SetBool("Suelo", false);
        gameObject.GetComponent<Animator>().SetBool("Techo", true);
        gameObject.GetComponent<Animator>().SetBool("Pared_Izq", false);
        gameObject.GetComponent<Animator>().SetBool("Pared_Der", false);
    }
    private void ParedIzq()
    {
        gameObject.GetComponent<Animator>().SetBool("Suelo", false);
        gameObject.GetComponent<Animator>().SetBool("Techo", false);
        gameObject.GetComponent<Animator>().SetBool("Pared_Izq", true);
        gameObject.GetComponent<Animator>().SetBool("Pared_Der", false);
    }
    private void ParedDer()
    {
        gameObject.GetComponent<Animator>().SetBool("Suelo", false);
        gameObject.GetComponent<Animator>().SetBool("Techo", false);
        gameObject.GetComponent<Animator>().SetBool("Pared_Izq", false);
        gameObject.GetComponent<Animator>().SetBool("Pared_Der", true);
    }
}