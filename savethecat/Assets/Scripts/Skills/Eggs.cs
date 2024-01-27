using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eggs : MonoBehaviour
{
    [SerializeField] private int _damage;
    [SerializeField] private GameObject _particles;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 7)
        {
            collision.GetComponent<CharacterHealth>().TakeDamage(_damage);
            Instantiate(_particles, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
