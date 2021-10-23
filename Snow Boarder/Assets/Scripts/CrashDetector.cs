using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
  [SerializeField] float loadDelay=.5f;



    private void OnTriggerEnter2D(Collider2D other) {
        
        if(other.tag == "Ground")
      Invoke("ReloadScene",loadDelay);// sec unit 


    }



      void ReloadScene(){

      SceneManager.LoadScene(0);


  }

}
