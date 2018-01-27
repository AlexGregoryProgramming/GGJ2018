using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorFire : MonoBehaviour
{
    ParticleSystem PS;
    ParticleSystemRenderer PSR; 
    
    
    float FireAmount = 100;

    float PLifetime;

    float WaitTime = 0.0f; 

    // Use this for initialization
    void Awake ()
    {
        PS = GetComponent<ParticleSystem>();
        PSR = GetComponent<ParticleSystemRenderer>();

        StartCoroutine("Emit");
    }

    public void GotHit(float ExtinguishAmount)
    {
        FireAmount -= ExtinguishAmount;

        WaitTime += 0.001f;

        if (FireAmount <= 0)
        {
            Destroy(this.gameObject);
        }
        
        //print(FireAmount.ToString() + "FireAmount Left");
    }

    IEnumerator Emit()
    {
        while (true)
        {
            PS.Emit(1);
            print("WaitTime is " + WaitTime);
            yield return new WaitForSeconds(WaitTime);
        }
    }
}
