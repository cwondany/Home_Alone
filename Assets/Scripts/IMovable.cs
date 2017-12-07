using UnityEngine;

public interface IMovable {

    // Use this for initialization
    void TakeHit(float damage, RaycastHit hit);

    void TakeDamage(float damage);

}
