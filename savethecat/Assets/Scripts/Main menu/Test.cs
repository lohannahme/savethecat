using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Test : MonoBehaviour
{
    [SerializeField] private float _timeToGrow = .2f;
    [SerializeField] private float _timeToFade = .3f;

    void Start()
    {
        Skill();
    }   


    private void Skill()
    {
        transform.DOScale(.3f, _timeToGrow).onComplete += () => GetComponent<SpriteRenderer>().DOFade(0,_timeToFade).onComplete += DisableObject;
    }

    private void DisableObject()
    {
        transform.localScale = new Vector3(.22f, .22f, .22f);
        GetComponent<SpriteRenderer>().DOFade(1, .1f);
        Destroy(this.gameObject);
    }
}
