using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIRageBarScript : MonoBehaviour {

    public int startingRage = 0;
    public int currentRage;
    public Slider rageSlider;

    bool isSwarmed;

    void Awake ()
    {
        currentRage = startingRage;
        rageSlider.value = currentRage;
    }

    public void UpdateRage(int amount)
    {
        currentRage += amount;

        rageSlider.value = currentRage;

        if(currentRage <= 100 && !isSwarmed)
        {
            Swarmed();
        }
    }

    void Swarmed()
    {
        isSwarmed = true;
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
