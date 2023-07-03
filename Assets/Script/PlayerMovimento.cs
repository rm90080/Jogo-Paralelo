using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovimento : MonoBehaviour
{
    public float veloc;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Metodo Start de " + this.name);
        veloc = 10.0f;
        transform.position = new Vector3(-7, -3, 0);
    }

    // Update is called once per frame
    void Update()
    {
        float entradaHorizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * entradaHorizontal * Time.deltaTime * veloc);

        if (transform.position.y > 0)
        {
            transform.position = new Vector3(transform.position.x, 0, 0);
        }
        else if (transform.position.y < -3.75f)
        {
            transform.position = new Vector3(transform.position.x, -3.75f, 0);
        }

        if (transform.position.x > 10f)
        {
            transform.position = new Vector3(-10f, transform.position.y, 0);
        }
        else if (transform.position.x < -10f)
        {
            transform.position = new Vector3(10f, transform.position.y, 0);
        }

    }
}
