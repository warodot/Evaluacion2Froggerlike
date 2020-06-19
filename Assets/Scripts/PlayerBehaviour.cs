using UnityEngine;

public class PlayerBehaviour:MonoBehaviour
{
    public float speed;

    public Animator playerAnim;
    public SpriteRenderer playerSprite;

    void Update()
    {
        float v = Input.GetAxisRaw("Vertical");
        float h = Input.GetAxisRaw("Horizontal");
        //Asi hago usualmente el input yo, no me mate, me queda mas comodo

        transform.position += new Vector3(h, v, 0) * speed * Time.deltaTime;

        //para que sea mas bonito ;)
        if (h != 0 || v != 0)
        {
            playerAnim.SetBool("isMoving", true);
        }
        else
        {
            playerAnim.SetBool("isMoving", false);
        }

        if(h > 0)
        {
            playerSprite.flipX = false;
        }
        else if(h < 0)
        {
            playerSprite.flipX = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) //Should the player handle the collision? IDK
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Auch!");
        }

        if (collision.gameObject.CompareTag("Goal"))
        {
            Debug.Log("Lo conseguiste!!");
        }
    }
}
