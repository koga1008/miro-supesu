using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private bool Direction;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Direction == true)
        {
            transform.position += new Vector3(0.1f, 0, 0);

            if (transform.position.x >= 8)
            {
                Direction = false;
            }
        }
        else
        {
            transform.position -= new Vector3(0.1f, 0, 0);

            if (transform.position.x <= -8)
            {
                Direction = true;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "bullet")
        {
            Destroy(gameObject);
        }
        
    }
}
