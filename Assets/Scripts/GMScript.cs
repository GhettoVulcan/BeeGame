using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GMScript : MonoBehaviour {

    //public GameObject CombPreFab;
    //public GameObject BeePreFab;
    public int beeRage;
    public int maxNumofPowerUps = 5;
    
    public int GatheredNumberofCombs = 0;

    private CombSpinScript Combs;

	// Use this for initialization
	void Start () {
        Combs = GameObject.FindWithTag("Finish").GetComponent<CombSpinScript>();

    }
	
	// Update is called once per frame
	void Update () {
	    //Updates to the field as well as other updates

	}

    //Bee killed method
    public void BeeKilled(int rageAdd)
    {
        beeRage += rageAdd;
        //Send command to the cylander to speed up and squash all combs
        Combs.SquashedBeeProtocol();

    }

}
