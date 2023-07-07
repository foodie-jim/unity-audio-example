using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    public Vector3 positionChange;
    private bool isForward = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >= -8 && transform.position.x <= 8)
        {
            if (isForward)
            {
                transform.position += positionChange;
            }
            else
            {
                transform.position -= positionChange;
            }

        }
        else if (transform.position.x > 8 || transform.position.x < -8)
        {
            isForward = !isForward;

            if (isForward)
            {
                transform.position += positionChange;
            }
            else
            {
                transform.position -= positionChange;
            }
        }
    }

}
