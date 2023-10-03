using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColisionesPlayer : MonoBehaviour {

    public AudioSource reproductor;
    public AudioClip carrito;
    public Image hamburguesa;

    public AudioClip sndAmbulancia;

    public Image ambulancia;
    public GameObject video;


    // Start is called before the first frame update
    void Start(){
        hamburguesa.gameObject.SetActive(false);
        video.SetActive(false);
        ambulancia.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider obj){
        if (obj.tag == "Carrito"){
            reproductor.PlayOneShot(carrito);
        }

        if (obj.tag == "comida"){
            hamburguesa.gameObject.SetActive(true);
        }

        if (obj.tag == "cine"){
            video.SetActive(true);
        }

        if (obj.tag == "hospital"){
            ambulancia.gameObject.SetActive(true);
            reproductor.PlayOneShot(sndAmbulancia);
        }

    }

    private void OnTriggerExit(Collider obj){
        reproductor.Stop();
        if (obj.tag == "comida"){
            hamburguesa.gameObject.SetActive(false);
        }

        if (obj.tag == "hospital"){
            ambulancia.gameObject.SetActive(false);
            
        }

        if (obj.tag == "cine"){
            video.SetActive(false);
        }

    }


}
