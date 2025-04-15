using UnityEngine;

public class Move : MonoBehaviour {

    public GameObject goal;
    Vector3 direction;
    public float speed = 2f;

    void Start() {

    }

    private void LateUpdate()
    {
        direction = goal.transform.position - transform.position;
        transform.LookAt(goal.transform.position);
        if (direction.magnitude > 2)
        {
            Vector3 velocity = direction.normalized * speed * Time.deltaTime;
            this.transform.position = transform.position + velocity;

        }
    }
}
