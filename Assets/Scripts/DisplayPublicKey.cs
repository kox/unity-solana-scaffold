using Solana.Unity.SDK;
using Solana.Unity.Wallet;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayPublicKey : MonoBehaviour
{
    private TextMeshProUGUI _txtPublicKey;

    // Start is called before the first frame update
    void Start()
    {
        _txtPublicKey = GetComponent<TextMeshProUGUI>();
        
    }

    private void OnEnable()
    {
        Web3.OnLogin += OnLogin;
    }

    private void OnLogin(Account account)
    {
        _txtPublicKey.text = account.PublicKey;
        string trimmedPublicKey = account.PublicKey.ToString().Length > 18 ? account.PublicKey.ToString().Substring(0, 18) : account.PublicKey.ToString();
        _txtPublicKey.text = trimmedPublicKey;
    }
}
