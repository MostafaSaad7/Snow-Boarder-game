using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem DustParticles;
        // Start is called before the first frame update
    /*void OnTriggerEnter2D(Collider2D other) {

      if(other.tag=="Ground")

     
 }
 */

/*
note : trigger ignore physics system 

https://answers.unity.com/questions/58658/what-is-trigger-and-the-uses-scripting.html
*/

 void OnCollisionEnter2D(Collision2D other) {
    
    if(other.gameObject.tag=="Ground")
    DustParticles.Play();
}


 void OnCollisionExit2D(Collision2D other) {
      if(other.gameObject.tag=="Ground")
    DustParticles.Stop();
}




}
