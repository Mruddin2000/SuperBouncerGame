using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSellector : MonoBehaviour {

	public void ChooseCharacter(int characterIndex) {
		PlayerPrefs.SetInt ("SellectedCharacter", characterIndex);
		print ("The player index that is sellected is " + characterIndex);
	}

	public void LoadScene ()
   
    {
        SceneManager.LoadScene("Level_001");
    }
}
