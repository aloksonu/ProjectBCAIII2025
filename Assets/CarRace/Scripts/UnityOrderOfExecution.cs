using UnityEngine;

public class UnityOrderOfExecution : MonoBehaviour
{

    void Start()
    {
        Debug.Log("Start");
    }

     void OnDisable()
    {
        Debug.Log("Disable");
    }
    void Awake()
    {
        Debug.Log("Awake");
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void OnEnable()
    {
        Debug.Log("Enable");
    }
    // Update is called once per frame

    private void LateUpdate()
    {
        //Debug.Log("LateUpdate=" + Time.deltaTime);
    }
    void Update()
    {
        //Debug.Log("Update="+ Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space)) {
            Destroy(this.gameObject);
            //DestroyImmediate(this.gameObject);
        
        }
    }

    void FixedUpdate()
    {
        //Debug.Log("Fixed Update=" + Time.deltaTime);
    }

    void OnDestroy()
    {
        Debug.Log("Destroy");
    }
}
