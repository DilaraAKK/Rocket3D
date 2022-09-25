using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour
{
    public int damage = 1;
    public int currentHealth = 3;
    ParticleSystem particle;
    public Animator anim;


    void Start()
    {
        particle = GetComponent<ParticleSystem>();
    }


    void Update()
    {

    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            anim.SetTrigger("DyingSlow");
        }
    }

    public void OnParticleTrigger()
    {
        TakeDamage(damage);
        Debug.Log("Hit");
    }

}
