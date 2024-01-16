using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnControl : MonoBehaviour
{

    public GameObject Danger;

    Camera cam;
    float Width;
    float Height;
    Vector3 topright;
    Vector3 topleft;
    Vector3 bottomright;
    Vector3 bottomleft;
    public float time = 1.5f;
    [SerializeField]
    private bool speedUp = true;
    [SerializeField]
    private bool spawn;
    int loopCount = 5;
    // Start is called before the first frame update
    void Start()
    {

        ScreenSize();
        ScreenCorners();
        spawn = true;
    }
    private void Awake()
    {
        cam = Camera.main;
    }
    void ScreenSize()
    {
        Width = 1 / (cam.WorldToViewportPoint(new Vector3(1, 1, 0)).x - 0.5f);
        Height = 1 / (cam.WorldToViewportPoint(new Vector3(1, 1, 0)).y - 0.5f);

    }
    void ScreenCorners()
    {
        transform.position = new Vector3(0, 0, 0);
        Vector2 TopRight = new Vector2(Width / 2, Height / 2);// finds the locations of the screens corners
        Vector2 BottomRight = new Vector2(Width / 2, -Height / 2);
        Vector2 BottomLeft = new Vector2(-Width / 2, -Height / 2);
        Vector2 TopLeft = new Vector2(-Width / 2, Height / 2);
        topright = TopRight;
        topleft = TopLeft;
        bottomright = BottomRight;
        bottomleft = BottomLeft;
    }

    // Update is called once per frame
    void Update()
    {
        if (spawn == true)//prevents couroutine being called every update
        {
            StartCoroutine(MoveSpawnPoint());
            spawn = false;
        }
       
    }




    private IEnumerator MoveSpawnPoint()
    {
        for (int i = 0; i < loopCount; i++)
        {
            //Debug.Log(time * Time.deltaTime);
            yield return new WaitForSeconds(time); //adds delay
           Vector3 randomSP = new Vector3((Width / 2 + 1), UnityEngine.Random.Range(bottomright.y, topright.y), 0); //picks random spot moves to
          transform.position = randomSP;
           Instantiate(Danger, transform.position, transform.rotation);
        }
           

        
        
      StartCoroutine(speedUpC());
     spawn = true;//resets loop
    }


   
                     // Debug.Log("moved");
    
    private IEnumerator speedUpC()
    {
        yield return new WaitForSeconds(0);
        time -= 0.5f;
        loopCount += 5;
        // speedUp = true;
    }
}