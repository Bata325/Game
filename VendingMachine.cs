using UnityEngine;

public class VendingMachine : MonoBehaviour
{
    [SerializeField] private string vendingMachineNumber;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            VendingMachineCode.Instance.AppendCode(vendingMachineNumber);
        }
    }
    
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            VendingMachineCode.Instance.ResetCode();
        }
    }
}
