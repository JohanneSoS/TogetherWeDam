using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluePlayerScript : MonoBehaviour
{
    [SerializeField] private float horizontal;
    [SerializeField] private float vertical;
    [SerializeField] private float speed = 1f;
    [SerializeField] private bool isFacingRight = true;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        horizontal = Input.GetAxisRaw("Horizontal2");
        vertical = Input.GetAxisRaw("Vertical2");
        Vector3 newPos = new Vector3(transform.position.x + (horizontal * 0.03f * speed), transform.position.y + (vertical * 0.05f * speed), transform.position.z);
        transform.position = newPos;
        Flip();
    }
    
    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localeScale = transform.localScale;
            localeScale.x *= -1f;
            transform.localScale = localeScale;
        }
    }
}
