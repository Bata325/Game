using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VendingMachineCode : MonoBehaviour
{
   public static VendingMachineCode Instance {get; private set;}
   [SerializeField] private Text codeText;
   private string code = ""; 

   private void Awake()
   {
    if(Instance == null)
    {
        Instance = this;
    }
    else
    {
        Destroy(gameObject);
    }
   }

    // Update is called once per frame
    public void AppendCode(string newCode)
    {
        code += newCode;
        UpdateCodeText();
    }
    public void ResetCode()
    {
        code = "";
        UpdateCodeText();
    }
    private void UpdateCodeText()
    {
        if(codeText != null)
        {
            codeText.text = "Your code: " + code;
        }

        if(code == "325")
        {
            SceneManager.LoadScene(2);
        }
    }
}
