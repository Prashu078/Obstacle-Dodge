using UnityEngine;

public class scorer : MonoBehaviour
{
    int hits=0;
    void OnCollisionEnter(Collision other)
    {

        if(other.gameObject.tag != "Hit")
        {
            hits = hits+1;
            Debug.Log("You've bumped this many times: " + hits);
        }
    }
}
