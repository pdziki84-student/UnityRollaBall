using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;



public class NewBehaviourScript : MonoBehaviour
{   

    public float speed;
    

    void Start()
    {
       

    }
    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        GetComponent<Rigidbody>().AddForce(movement * speed * Time.deltaTime);

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "cube")
        {
            other.gameObject.SetActive(false);
            ScoresCounter.Score++;
        }
        else if (other.gameObject.tag == "sphere")
        {
            other.gameObject.SetActive(false);
            ScoresCounter.Score += 2;
        }
    }

    void RemoveObjectsWithTag(string tag)
    {
        var cubePickUp = GameObject.FindGameObjectsWithTag(tag);

        if (cubePickUp != null)
            foreach (var item in cubePickUp)
                item.gameObject.SetActive(false);
    }
}
