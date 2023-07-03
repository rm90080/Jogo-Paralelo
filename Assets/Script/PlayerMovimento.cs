using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovimento : MonoBehaviour
{
    public float veloc;
    public GameObject pfPizza;
    public float tempoDeDisparo = 0.3f;
    public float podeDisparar = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        veloc = 3.0f ;
        Debug.Log("Metodo Start de " + this.name);
        veloc = 10.0f;
        transform.position = new Vector3(-7, -3, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            if ( Time.time > podeDisparar ){
                Instantiate(pfPizza, transform.position + new Vector3 (0,1f,0), Quaternion.identity);
                podeDisparar = Time.time + tempoDeDisparo ;
            }
        }
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
