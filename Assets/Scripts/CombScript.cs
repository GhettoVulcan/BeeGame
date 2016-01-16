using UnityEngine;
using System.Collections;

public class CombScript : MonoBehaviour {

    private SpriteRenderer sr;
    private bool IsFull = true; //If bee is squashed, this is false
    private bool IsSquashed = false;

    public Sprite emptyComb;
    public Sprite fullComb;
    public Sprite emptyCombSquashed;
    public Sprite fullCombSquashed;
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
        if(Input.GetKey("mouse 0") && IsFull && !IsSquashed)
        {
            sr.sprite = emptyComb;
            //Send the point to the game manager
            gm.GatheredNumberofCombs++;
            IsFull = false;
        }
        
    }

    public void Squashed()
    {
        sr.sprite = !IsFull ? emptyCombSquashed: fullCombSquashed;
        IsSquashed = false;
    }

}
