using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] public GameObject PLayer;
    [SerializeField] float playerspeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        PLayer.transform.Translate(new Vector3(x, 0, 0) * Time.deltaTime * playerspeed);

    }
}
