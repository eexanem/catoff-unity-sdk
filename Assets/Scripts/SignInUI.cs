using UnityEngine;
using UnityEngine.UI; // for Button
using TMPro;         // for TextMeshPro text

public class SignInUI : MonoBehaviour {
    public Button signInButton;
    public TMP_Text statusText;

    void Start() {
        signInButton.onClick.AddListener(OnSignInClicked);
    }

    void OnSignInClicked() {
        string wallet = CatoffAPI.Authenticate();
        statusText.text = $"Wallet: {wallet}";
    }
}
