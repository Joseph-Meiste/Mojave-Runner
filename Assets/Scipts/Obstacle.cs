using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public Parallax.Layer layer;
    public float endRange = -12f;

    void Update()
    {
        transform.position += Vector3.left * Parallax.speed * Time.deltaTime;

        if (transform.position.x <= endRange){
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Health.TryDamageTarget(other.gameObject, 1);
    }
}
