using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoDaPizza : MonoBehaviour
{
    public float velocPizza = 15f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * velocPizza * Time.deltaTime);

        if (transform.position.y > 5.5f){
            Destroy(this.gameObject);
        }
    }
}
