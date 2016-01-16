using UnityEngine;
using System.Collections;

public class BeeScript : MonoBehaviour {

    private Rigidbody2D body;
    public float magnitude = 1f;
    public int bounce = 1;
    public float initialForceX = 400f;
    public float initialForceY = 400f;

    void Start ()
    {
        body = GetComponent<Rigidbody2D>();
        body.isKinematic = false;
        body.AddForce(new Vector2(initialForceX, initialForceY));
    }


    // Update is called once per frame
    void Update () {
        
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
