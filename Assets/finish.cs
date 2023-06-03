using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class finish : MonoBehaviour
{
    private bool complete=false;
    [SerializeField] private int final=2;
    [SerializeField] private AudioSource finsound;

    // Start is called before the first frame update
    void Start()
    {
    finsound=GetComponent<AudioSource>();    
    }

 private void OnTriggerEnter2D(Collider2D collision){

if(collision.gameObject.name=="player"&&!complete){
complete=true;
    finsound.Play();
    Invoke("completelevel",1f);
}


 }

private void completelevel(){

if(SceneManager.GetActiveScene().buildIndex==final){
SceneManager.LoadScene(0);

}

SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);

}

}
