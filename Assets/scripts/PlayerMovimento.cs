using UnityEngine;

public class PlayerMovimento : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float velocidade = 5f;

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        transform.position += new Vector3(x, y, 0) * velocidade * Time.deltaTime;
    }
}
