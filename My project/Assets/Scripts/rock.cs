using UnityEngine;

public class rock : MonoBehaviour
{
    [SerializeField] float timeTowait = 2f;
    
    MeshRenderer myMesh;
    Rigidbody myRigid;
    void Start()
    {
        myMesh = GetComponent<MeshRenderer>();
        myRigid = GetComponent<Rigidbody>();
    
        myMesh.enabled = false;
        myRigid.useGravity = false;
    }
    void Update()
    {
        if(Time.time > timeTowait)
        {
            myMesh.enabled = true;
            myRigid.useGravity = true;
        }
    }
}
