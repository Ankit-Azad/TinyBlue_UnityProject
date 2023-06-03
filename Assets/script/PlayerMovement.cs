using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
public float direX;
[SerializeField] private LayerMask jumpableground;
public float run_speed;
     public float jumpstrength; 
    private Rigidbody2D rb;
    private BoxCollider2D col;
    private SpriteRenderer sp;
private Animator anim;
private enum player_mobility {idle,running,jump,fall}
[SerializeField] private AudioSource jumpsound; 
 
[SerializeField] private AudioSource run;

    // Start is called before the first frame update
    void Start()
    {
        
rb=GetComponent<Rigidbody2D>();
sp=GetComponent<SpriteRenderer>();
anim=GetComponent<Animator>();
col=GetComponent<BoxCollider2D>();

    }

    // Update is called once per frame
    void Update()

    
    {
direX=Input.GetAxisRaw("Horizontal");

playermovementground();



if(Input.GetButtonDown("Jump")&&isground()){
jumpsound.Play();
rb.velocity=new Vector2(rb.velocity.x,jumpstrength*1f);

}

if(direX!=0&&isground()){
run.Play();

    }

    }
void playermovementground(){
player_mobility state;
if(direX>0){

rb.velocity=new Vector2(run_speed*direX,rb.velocity.y);
sp.flipX=false;
state=player_mobility.running;
}else if(direX<0){
rb.velocity=new Vector2(run_speed*direX,rb.velocity.y);
sp.flipX=true;
state=player_mobility.running;

}else{


    rb.velocity=new Vector2(0,rb.velocity.y);
state=player_mobility.idle;
}

if(rb.velocity.y>0.1f){


state=player_mobility.jump;


}else if(rb.velocity.y<-0.1f){

state=player_mobility.fall;

}


anim.SetInteger("state",(int)state);




}
//define here new methods
private bool isground( ){

return Physics2D.BoxCast(col.bounds.center,col.bounds.size,0f,Vector2.down,.1f,jumpableground);

}

}
