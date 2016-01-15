using UnityEngine;
using System.Collections;

public class BeeScript : MonoBehaviour {

    private Rigidbody2D body;
    private bool temp = true;

    void Start ()
    {
        body = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update () {
        if (temp)
        {
            body.isKinematic = false;
            body.AddForce(new Vector2(600f, 600f));
            temp = false;
        }

        var vel = body.velocity;
        var speed = vel.magnitude;

	}
}
