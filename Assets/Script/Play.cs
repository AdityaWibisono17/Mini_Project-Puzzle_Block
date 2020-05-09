using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource buttonSound;
    public void Mulai(){
        buttonSound.PlayOneShot(buttonSound.clip);
        SceneManager.LoadScene("Puzzle(A)");
    }
}
