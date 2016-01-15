using UnityEngine;
using System.Collections;

public class CombScript : MonoBehaviour {

    private SpriteRenderer sr;
    private bool IsActive = true;

    public Sprite emptyComb;
    public Sprite fullComb;
    GMScript gm;

	// Use this for initialization
	void Start () {
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = fullComb;
        gm = GameObject.FindWithTag("Player").GetComponent<GMScript>();
    }
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnMouseDown()
    {
        if(Input.GetKey("mouse 0") && IsActive)
        {
            sr.sprite = emptyComb;
            //Send the point to the game manager
            gm.GatheredNumberofCombs++;
            IsActive = false;
        }
        
    }
}
