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
        ShotControlHoriz(KeyCode.A, -90);
        ShotControlHoriz(KeyCode.D, 90);

        //Controladores de disparo Verticalmente
        ShotControlVert(KeyCode.W, -90);
        ShotControlVert(KeyCode.S, 90);

    }


    //Controladores de direccion del disparo
    public void SpawnProjectile(Quaternion Rotation)
    {
        Instantiate(projectil, transform.position, Rotation);
    }

    //Funciones para el controlador de disparos
    public void ShotControlHoriz(KeyCode Key, float Rotation)
    {
        if (Input.GetKeyDown(Key))
        {
            SpawnProjectile(Quaternion.Euler(0,Rotation,0));
        }
    }

    public void ShotControlVert(KeyCode Key, float Rotation)
    {
        if (Input.GetKeyDown(Key))
        {
            SpawnProjectile(Quaternion.Euler(Rotation, 0, 0));
        }
    }

}
