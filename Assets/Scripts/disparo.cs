using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparo : MonoBehaviour
{
    //bala y cadencia de disparo
    public GameObject bulletPrefab;
    private bool canShot;
    private float cadencia = 0.6f;

    //posición de la bala
    private GameObject canonhole;


    //sonido
    private AudioSource playerAudioSource;
    public AudioClip shotSound;

    void Start()
    {
        canShot = true;//bolean que nos impedirá poder disparar en cada frame, sino tener un cooldown del disparo

        canonhole = GameObject.Find("salida_bala");

        playerAudioSource = GetComponent<AudioSource>(); //accedemos al audio Source del Player
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0) && canShot) //si pulsamos click izquierdo y canShot nos deja disparar
        {
            Instantiate(bulletPrefab, canonhole.transform.position, canonhole.transform.rotation); //instanciamos una bala en la posición del canon
            canShot = false;
            playerAudioSource.PlayOneShot(shotSound,0.2f);
            StartCoroutine(ShotCooldown()); //y nos impedirá disparar durante 1 segundo hasta que canShot vuelva a valer true
        }
    }

    public IEnumerator ShotCooldown() //corrutina que nos hará esperar 1 segundo antes de que la variable canShot valga true y podamos disparar
    {
        yield return new WaitForSeconds(cadencia);
        canShot = true;
    }
}
