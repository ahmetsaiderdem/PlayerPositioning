using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame updateü
    private float horizontalInput;
    
    private float speed = 20f;
    public GameObject projectilePrefabs;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -20)
        {
            transform.position = new Vector3(-20, transform.position.y, transform.position.z);
        }
        else if(transform.position.x > 20)
        {
            transform.position = new Vector3(20, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");   
        transform.Translate(Vector3.right * Time.deltaTime * horizontalInput*speed);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefabs,transform.position,projectilePrefabs.transform.rotation);
        }
    }
}
