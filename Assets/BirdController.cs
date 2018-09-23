using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour {

    public float jumpForce = 10f;
    public float moveSpeed = 0.2f;
    private Rigidbody2D rgb;
	// Use this for initialization
	void Start () {
        rgb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            rgb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }

        Vector2 pos = transform.position;
        pos.x += moveSpeed * Time.deltaTime;
        transform.position = pos;


    }


    void OnCollisionEnter2D(Collision2D co)
    {
        if (co.gameObject.tag == "block")
        {
            Destroy(this.gameObject);
            GameController.instance.GameOver();
            return;
        }
    }
}
