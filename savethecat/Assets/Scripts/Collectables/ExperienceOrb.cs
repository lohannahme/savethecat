using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExperienceOrb : MonoBehaviour
{
    [SerializeField] private float _experienceAmount = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.TryGetComponent<PlayerXPManager>(out PlayerXPManager player))
        {
            player.UpdatePlayerExperience(_experienceAmount);
            Destroy(this.gameObject);
        }
    }
}
