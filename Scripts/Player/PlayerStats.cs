using UnityEngine;
using System.Collections;

public class PlayerStats : MonoBehaviour {
    public int playerHealth = 100;
    public int playerAtk = 10;
    public int playerDef = 12;
    public int curExp;
    public int maxExp = 100;
    public int level = 1;

	// Use this for initialization

    void Update()
    {
      
    }

    void LevelUp()
    {
        level++;
        playerHealth += 100;
        playerAtk += 5;
        playerDef += 12;
        print("level" + level +"health" + playerHealth + "atk" + playerAtk + "def " + playerDef);
    }

    public void UpdateExp(int amount)
    {
        curExp += amount;
        if (curExp >= maxExp)
        {
            LevelUp();
            curExp -= maxExp;
            maxExp += 100;
        }
    }
 
}
