using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelmanager : MonoBehaviour {
    public string[] rooms = new string[]{"Room1","Room1(1)","Room1(2)","Room1(3)","Room1(4)","Room1(5)","Room1(6)","Room1(7)","Room1(8)","Room1(9)"};
    public int random = 0;
    public static int maxspawns = 20;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		 
	}
    string GetRoom()
    {
        int picker = Random.Range(0, 9);
        return rooms[picker];
    }
    public void spawnNewRoom()
    {
        int spawnNum = maxspawns;
        while (spawnNum >= -1)
        {
            GameObject room = objectpooler.SharedInstance.GetPooledObject(GetRoom());
            if (room != null)
            {
                room.transform.position = new Vector3(90F+ (20*spawnNum), -2F, 1.0f);
                room.SetActive(true);
            }
            spawnNum--;
        }
    }
}
