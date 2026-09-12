using UnityEngine;
using UnityEngine.Rendering;

public class flyAtPlayer : MonoBehaviour
{
    [SerializeField] float speed = 1.0f;
    [SerializeField] Transform player;
    Vector3 playerPosition;

    void Awake()
    {
        gameObject.SetActive(false);
    }
    void Start()
    {
        playerPosition = player.transform.position;
    }
    void Update()
    {
        MovetoPlayer();
        DestroywhenReached();
    }
    void MovetoPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position,playerPosition,Time.deltaTime*speed); 
    }

    void DestroywhenReached()
    {
        if( transform.position == playerPosition)
        {
            Destroy(gameObject);
        }
    }
}
