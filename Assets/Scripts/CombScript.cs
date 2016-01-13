using UnityEngine;
using System.Collections;

public class CombScript : MonoBehaviour {

    private SpriteRenderer sr;

    public Sprite emptyComb;
    public Sprite fullComb;

	// Use this for initialization
	void Start () {
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = fullComb;
    }
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnMouseDown()
    {
        if(Input.GetKey("mouse 0"))
        {
            sr.sprite = emptyComb;
            //Send the point to the game manager
        }
        
    }
}
