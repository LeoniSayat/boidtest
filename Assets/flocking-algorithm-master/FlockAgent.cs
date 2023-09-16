using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class FlockAgent : MonoBehaviour
{

    Flock agentFlock;
    public Flock AgentFlock { get { return agentFlock; } }
    public Vector3 _forward; 
    public Vector3 _scuffed;
    static Vector3 smooth = new Vector3(1,1,0);

    Collider agentCollider;
    public Collider AgentCollider { get { return agentCollider; } }

    // Start is called before the first frame update
    void Start()
    {
        agentCollider = GetComponent<Collider>();
    }

    public void Initialize(Flock flock)
    {
        agentFlock = flock;
    }

    public void Move(Vector2 velocity)
    {
        //transform.forward = (Vector3)velocity;
        _scuffed = ((Vector3)velocity).normalized;
        //transform.forward = _scuffed;
        //transform.forward = new Vector3(_scuffed.x, _scuffed.z, _scuffed.y);
        //transform.forward = Vector3.Cross(((Vector3)velocity).normalized, smooth); 
        // _scuffed = ((Vector3)velocity).normalized;
        _forward = transform.forward;
        transform.position += new Vector3(velocity.x, 0, velocity.y) * Time.deltaTime;

    }
}
