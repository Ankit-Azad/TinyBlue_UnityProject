using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class player_death : MonoBehaviour
{
    private Rigidbody2D rb;
[SerializeField] private AudioSource dea;
    private Animator ani;
    // Start is called before the first frame update
   private void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        ani=GetComponent<Animator>();
    }

private void OnCollisionEnter2D(Collision2D collision){

if(collision.gameObject.CompareTag("trap")){
    dea.Play();
Die();


}

}
private void Die(){
rb.bodyType=RigidbodyType2D.Static;
ani.SetTrigger("deathh");


}
private void restartlevel(){

SceneManager.LoadScene(SceneManager.GetActiveScene().name);

}

}
