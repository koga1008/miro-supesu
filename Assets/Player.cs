using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public GameObject player;
    public GameObject bullet;
    // Start is calleb before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0f, 0.3f, 0f);
    
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(0.1f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-0.1f, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            Instantiate(bullet.gameObject, player.transform.position, player.transform.rotation);
        } 
    }
}