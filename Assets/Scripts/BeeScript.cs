using UnityEngine;
using System.Collections;

public class BeeScript : MonoBehaviour {

    private Rigidbody2D body;
    public float magnitude = 1f;
    public int bounce = 1;
    public float initialForceX = 4f;
    public float initialForceY = 4f;
    private GMScript gm;
    public int RageAdd = 1;

    void Start ()
    {
        body = GetComponent<Rigidbody2D>();
        body.isKinematic = false;
        body.AddForce(new Vector2(initialForceX, initialForceY));
        gm = GameObject.FindWithTag("Player").GetComponent<GMScript>();
    }


    // Update is called once per frame
    void Update () {
        
	}

    void OnMouseDown()
    {
        if (Input.GetKey("mouse 0"))
        {
            //SendMessage message to the gm that a bee was killed
            gm.BeeKilled(RageAdd);
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


}
