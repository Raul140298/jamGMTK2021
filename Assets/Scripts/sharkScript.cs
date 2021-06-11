using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sharkScript : MonoBehaviour
{
    public GameObject player;
    public float speed;
    public Vector3 playerPosIni;
    public Vector3 velocity;
    private float distance;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player");
        playerPosIni = player.transform.position;
        distance = Mathf.Sqrt(Mathf.Pow(this.transform.position.y - playerPosIni.y,2) + Mathf.Pow(this.transform.position.x - playerPosIni.x,2));
        print(distance);
        LookAt2D(this.gameObject, playerPosIni);
        velocity = new Vector3((playerPosIni.x - this.transform.position.x)/distance, (playerPosIni.y - this.transform.position.y)/distance, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.position = player.transform.position;
        this.GetComponent<Rigidbody2D>().velocity = velocity * speed;
    }

    public void LookAt2D(GameObject shark, Vector2 target)
    {
        Vector2 current = shark.transform.position;
        var direction = target - current;
        var angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        shark.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}