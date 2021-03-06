using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
  [SerializeField] float loadDelay=.5f;
  [SerializeField] ParticleSystem crashEffect;
  
  //to choose which audio to play  
  [SerializeField]  AudioClip  crashSFX;
  bool hasCrashed=false;



    private void OnTriggerEnter2D(Collider2D other) {
        
        if(other.tag == "Ground" && !hasCrashed)
        {
          hasCrashed=true;
          FindObjectOfType<PlayerController>().DisableControls();
          crashEffect.Play();
          GetComponent<AudioSource>().PlayOneShot(crashSFX);
          // play specific audio you choosed
          Invoke("ReloadScene",loadDelay);// sec unit 
        }

    }



      void ReloadScene(){

      SceneManager.LoadScene(0);


  }

}
