using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItem : MonoBehaviour {

    public Transform hand;
    Transform item;
    
    void OnTriggerEnter (Collider collider) {
        if (collider.tag != "Player")
        {
            return;
        }
        PickUp(collider.transform);
	}

	void PickUp (Transform item) {
        //OnPickup(item);
        print(item+"test");
        
        //item = Instantiate(item, hand.position, hand.rotation);
        //item.transform.parent = hand;
    }
}
