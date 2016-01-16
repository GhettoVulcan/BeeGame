using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIScore : MonoBehaviour {

    private GMScript gm;

    public int CollectedCombs;

	// Use this for initialization
	void Start () {
        gm = GameObject.FindWithTag("Player").GetComponent<GMScript>();
        GetComponent<Text>().text = CollectedCombs.ToString();
    }
	
	// Update is called once per frame
	void Update () {
        CollectedCombs = gm.GatheredNumberofCombs;
        GetComponent<Text>().text = CollectedCombs.ToString();
    }
}
