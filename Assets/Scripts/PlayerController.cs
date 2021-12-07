using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject projectil;

    // Update is called once per frame
    void Update()
    {

        //Controladores de disparo 
        if (Input.GetKeyDown(KeyCode.D))
        {
            SpawnProjectile(Quaternion.Euler(0, 90, 0));
        }

         if (Input.GetKeyDown(KeyCode.W))
        {
            SpawnProjectile(Quaternion.Euler(-90, 0, 0));
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            SpawnProjectile(Quaternion.Euler(90, 0, 0));
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            SpawnProjectile(Quaternion.Euler(0, -90, 0));
        }
    }


    //Controladores de direccion del disparo
    public void SpawnProjectile(Quaternion Rotation)
    {
        Instantiate(projectil, transform.position, Rotation);
    }
  
}
