using UnityEngine;

public class followplayer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float followspeed = 2f;
    public Transform target;
    public float height = 2f;

    // Update is called once per frame
    void Update()
    {
        Vector3 newpos = new Vector3(target.position.x,target.position.y + height,-10f);
        transform.position = Vector3.Slerp(transform.position,newpos,followspeed * Time.deltaTime);
    }
}
