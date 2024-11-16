using UnityEngine;

public class ConditionChecker : MonoBehaviour
{
    public detectCollision playerScript;
    public GameObject box;

    // Update is called once per frame
    void Update()
    {
        if(playerScript.heartstat %3 ==1 && playerScript.coinstat %3 ==2)
        {
            DestroyBox();
        }
    }
    private void DestroyBox()
    {
        if(box != null)
        {
            Destroy(box);
            box = null;
        }
    }
}
