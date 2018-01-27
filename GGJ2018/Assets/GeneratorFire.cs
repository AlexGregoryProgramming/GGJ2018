using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorFire : MonoBehaviour
{
    ParticleSystem PS;

    float FireAmount = 100;

    float StartLifetime;
	// Use this for initialization
	void Awake ()
    {
        PS = GetComponent<ParticleSystem>();
        PS.Play();
        StartLifetime = PS.main.startLifetime.constant;
    }


    public void GotHit(float ExtinguishAmount)
    {
        FireAmount -= ExtinguishAmount;

        float ReduceAmountPercent = FireAmount / 100.0f;

        float ReduceAmount = ReduceAmountPercent * StartLifetime;

        var lifetime = PS.startLifetime;

        lifetime -= ReduceAmount; 

        if (FireAmount == 0)
        {
            Destroy(this.gameObject);
        }

        print("Got Hit");
    }
}
