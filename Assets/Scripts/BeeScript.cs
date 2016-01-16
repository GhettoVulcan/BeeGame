using UnityEngine;
using System.Collections;

public class BeeScript : MonoBehaviour {

    private Rigidbody2D body;
    UIRageBarScript rageBar;
    public float magnitude = 1f;
    public int bounce = 1;
    public float initialForceX = 4f;
    public float initialForceY = 4f;
    private GMScript gm;
    public int damage = 25;

    void Start ()
    {
        body = GetComponent<Rigidbody2D>();
        body.isKinematic = false;
        body.AddForce(new Vector2(initialForceX, initialForceY));
        gm = GameObject.FindWithTag("Player").GetComponent<GMScript>();
        rageBar = gm.GetComponent<UIRageBarScript>();
    }

    void Awake()
    {
        
    }


    // Update is called once per frame
    void Update () {
        if(rageBar.currentRage >= 100)
        {
            Debug.Log("End Game");
        }
	}

    void OnMouseDown()
    {
        if (Input.GetKey("mouse 0"))
        {
            Enraged();
            //SendMessage message to the gm that a bee was killed
            gm.BeeKilled(damage);
            //Destroy bee
            Destroy(this.gameObject);
        }

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "Bee")
        {
            magnitude = body.velocity.magnitude;
        }
    }

    void OnCollisionExit(Collision col)
    {
        if (col.collider.tag == "Bee")
        {
            Vector3 otherVelocity = col.rigidbody.velocity.normalized;
            col.rigidbody.AddForce(otherVelocity, ForceMode.Impulse);
        }
    }

    void Enraged()
    {
        if(rageBar.currentRage < 100)
        {
            rageBar.UpdateRage(damage);
        }
    }


}
