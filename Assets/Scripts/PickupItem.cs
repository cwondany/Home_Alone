using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItem : MonoBehaviour
{

    public Transform hand;
    bool carryItem = true;

    void Start()
    {

    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            GetComponent<Collider>().transform.parent = null;
            carryItem = true;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (carryItem)
        {

            {
                if (GetComponent<Collider>().CompareTag("PickupAble"))
                {
                    GetComponent<Collider>().transform.parent = (hand);
                    carryItem = false;

                }


            }

        }
    }
}
