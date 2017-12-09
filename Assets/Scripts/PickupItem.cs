using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItem : MonoBehaviour
{

    public Transform hand;
    public GameObject item;
    public GameObject tempParent;

    bool carryItem = false;

    void Start()
    {
        //item.GetComponent<Rigidbody>().useGravity = true;
    }

    private void Update()
    {
      
    }

    private void OnMouseDown()
    {
        if (!carryItem)
        {

            //item.GetComponent<Rigidbody>().useGravity = false;
            item.GetComponent<Rigidbody>().isKinematic = true;
            item.transform.position = hand.transform.position;
            item.transform.rotation = hand.transform.rotation;
            item.transform.parent = tempParent.transform;
            carryItem = true;
        }
        else
        {
            //item.GetComponent<Rigidbody>().useGravity = true; 
            item.GetComponent<Rigidbody>().isKinematic = false;
            item.transform.parent = null;
            item.transform.position = hand.transform.position;
            carryItem = false;

        }
       
    }
    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown("q"))
        {
            Destroy(gameObject);
        }

    }
        void OnGUI()
    {
        Event e = Event.current;
        if (e.isKey)
            Debug.Log("Detected key code: " + e.keyCode);

    }

}

