using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSoundController : MonoBehaviour
{
    AudioSource audioSource;

      public AudioClip BlockSE;
 
// 地面の位置
private float groundLevel = -3.0f;

    // Start is called before the first frame update
    void Start()
    {
     
    audioSource = GetComponent<AudioSource>();
    }
   //他のキューブと接触したら
        void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Cube")
            {
                audioSource.PlayOneShot(BlockSE);
            }

            else if (collision.gameObject.tag == "ground")
            {
                audioSource.PlayOneShot(BlockSE);




            }
        }
    // Update is called once per frame
    void Update()
    {

     
   
        }
    }

