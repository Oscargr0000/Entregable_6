using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    private float horizontalLimit = 10f;
    private float verticalLimit = 10f;
    private float speed = 2f;




    // Update is called once per frame
    void Update()
    {
        //Velocidad constante
        transform.Translate(Vector3.forward * speed * Time.deltaTime);



        //Limitador de distancia en horizontal
        if (transform.position.x > horizontalLimit)
        {
            Destroy(gameObject);
        }

        if (transform.position.x < -horizontalLimit)
        {
            Destroy(gameObject);
        }



        //Limitador de distancia en vertical
        if (transform.position.y > verticalLimit)
        {
            Destroy(gameObject);
        }

        if (transform.position.y < -verticalLimit)
        {
            Destroy(gameObject);
        }
    }
}
