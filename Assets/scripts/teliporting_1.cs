using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teliporting_1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider col)
    {
        col.transform.position = new Vector3(-203, 1.5f, -247);
    }

    //private void OnTriggerStay(Collider other)
   // {
      //  if (Input.GetKeyDown(KeyCode.E))
       // {
        //    other.transform.position = new Vector3(-203, 1.5f, 247);
      //  }
    //}
}
