using UnityEngine;
using System.Collections;

public class CombSpinScript : MonoBehaviour {

    public int rotationModifier = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.right * (Time.deltaTime * rotationModifier) ,Space.World);

	}


    public void SquashedBeeProtocol()
    {
        rotationModifier += 2;

        //Squash all the combs available
        var children = gameObject.GetComponentsInChildren<CombScript>();
        foreach(var child in children)
        {
            child.Squashed();
        }
    }

}
