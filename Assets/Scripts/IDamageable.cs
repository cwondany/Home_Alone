using UnityEngine;

public interface IDamageable {

    // Use this for initialization
    void TakeHit(float damage, RaycastHit hit);

    void TakeDamage(float damage);

}
