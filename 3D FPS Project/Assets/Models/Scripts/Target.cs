using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Target : MonoBehaviour
{
     void Start()
        {
            this.gameObject.SetActive(true);
        }
   void OnCollisionEnter(Collision other)
   {
        if(other.gameObject.CompareTag("Bullet"))
        {
            //add points to the score
            if(this.gameObject.tag == "Floating Target")
            {
                //Destroy(this.gameObject);
                GameObject.Find("Game Manager").GetComponent<GameManager>.()UpdatetargetAmount(-1)
                this.gameObject.SetActive(false);
            }
            //add grayscale to standing target later on
        }
   }
}
