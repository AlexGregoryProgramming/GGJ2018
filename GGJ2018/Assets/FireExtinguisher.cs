using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireExtinguisher : MonoBehaviour
{
    public Transform FirePoint;

    bool Firing = false; 

    public float SprayDistance = 10;

    public LayerMask FireMask;

    ParticleSystem System;

    public float ExtinguishingPower = 2.0f; 
    
	// Use this for initialization
	void Start ()
    {
        //System = GetComponent<ParticleSystem>();


    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Firing == true)
        {
            //print("Firing");
            RaycastHit Hit;
            bool RayHit = Physics.Raycast(FirePoint.position, FirePoint.forward, out Hit, SprayDistance);

            //print(Hit.collider.gameObject.name);
            if (RayHit == true && Hit.collider.tag == "Fire")
            {
                print("Hitting Something");
                Hit.transform.gameObject.GetComponent<GeneratorFire>().GotHit(ExtinguishingPower);
            }
            // TODO(barret): activate particle effect here 
            //System.Play();
        }
        else
        {
            //System.Stop();
        }

        if (Input.GetKey(KeyCode.Space))
        {
            BeginFire();
        }
        else
        {
            EndFire();
        }
    }

    public void BeginFire()
    {
        Firing = true; 
    }

    public void EndFire()
    {
        Firing = false; 
    }
}
