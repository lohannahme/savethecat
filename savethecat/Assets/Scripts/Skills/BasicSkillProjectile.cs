using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BasicSkillProjectile : MonoBehaviour
{
    [SerializeField] private float _timeToGrow = .2f;
    [SerializeField] private float _timeToFade = .3f;

    private float _damage = 10;
    [SerializeField]private GameObject _particles;

    void Start()
    {
        Skill();
    }


    private void Skill()
    {
        transform.DOScale(.85f, _timeToGrow).onComplete += () => GetComponent<SpriteRenderer>().DOFade(0, _timeToFade).onComplete += DisableObject;
    }

    private void DisableObject()
    {
        transform.localScale = new Vector3(1f, .1f, 1f);
        GetComponent<SpriteRenderer>().DOFade(1, .1f);
        Destroy(this.gameObject);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 7)
        {
            collision.GetComponent<CharacterHealth>().TakeDamage(_damage);
            Instantiate(_particles, transform.position, Quaternion.identity);
           
        }
    }
}
