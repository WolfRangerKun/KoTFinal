using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VicenteEnemy : MonoBehaviour
{
    public Transform theTransform;
    public Transform ref1, ref2, ref3, ref4, ref5, ref6, ref7, ref8, ref9, ref10, ref11, ref12, ref13, ref14;
    public Transform target;
    public float speed = 3;

    private void Start()
    {
        target = ref9;
    }
    private void Update()
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
            }
            else if (target == ref2)
            {
                target = ref3;
            }
            else if (target == ref3)
            {
                target = ref4;
            }
            else if (target == ref4)
            {
                target = ref5;
            }
            else if (target == ref5)
            {
                target = ref6;
            }
            else if (target == ref6)
            {
                target = ref7;
            }
            else if (target == ref7)
            {
                target = ref8;
            }
            else if (target == ref8)
            {
                target = ref9;
            }
            else if (target == ref9)
            {
                target = ref10;
            }
            else if (target == ref10)
            {
                target = ref11;
            }
            else if (target == ref11)
            {
                target = ref12;
            }
            else if (target == ref12)
            {
                target = ref13;
            }
            else if (target == ref13)
            {
                target = ref14;
            }
            else if (target == ref14)
            {
                target = ref1;
            }
        }
    }
}
