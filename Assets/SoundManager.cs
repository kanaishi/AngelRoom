using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    //public string SeName = null;


    public AudioClip G2;
    public AudioClip G2S;
    public AudioClip A2;
    public AudioClip A2S;
    public AudioClip B2;
    public AudioClip C3;
    public AudioClip C3S;
    public AudioClip D3;
    public AudioClip D3S;
    public AudioClip E3;
    public AudioClip F3;
    public AudioClip F3S;
    public AudioClip G3;
    public AudioClip G3S;
    public AudioClip A3;
    public AudioClip A3S;
    public AudioClip B3;
    public AudioClip C4;
    public AudioClip C4S;
    public AudioClip D4;
    public AudioClip D4S;
    public AudioClip E4;
    public AudioClip F4;

    private AudioSource audioSource; //オーディオソース

    // Use this for initialization
    void Start()
    {
        audioSource = this.gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        // ClassA のインスタンスを見つける.
        KeyDown KeyDown = FindObjectOfType<KeyDown>();

        string SeName = KeyDown.SeName;    // 読み取りできる.
                                               // 書き込みもできる.
        Debug.Log(SeName);
        Debug.Log("格納成功");

        if (SeName == "G2")
        {
            Debug.Log("サウンドＩＦ通過");
            audioSource.PlayOneShot(G2);
         Debug.Log("G2鳴った");
        }

    }
}