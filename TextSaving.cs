using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class TextSaving : MonoBehaviour
{
	   public string[] loadData;
	   //content of the file
	   
   public void CharacterSaveSlot(string path, string content)
   {
	   //Path of file
	  // string path2 = Application.streamingAssetsPath;
	   //string path = Application.persistentDataPath + "/StreamingAssets";
	   //string path3 = Application.dataPath + "/StreamingAssets";
	   //Create file path if it doesnt exist
	   if (!File.Exists(path))
	   {
							//Path and Content
		   File.WriteAllText(path,"");
	   }
	   //add the content to the file
	   //Append allows to add more to the file
	  //Write creates or replaces a text file
	  File.WriteAllText(path,content);
	  
	   Debug.Log(path);
   }
	   public void CharacterLoadSlot(string path)
	   {
		   //if the path exists
		   if (File.Exists(path))
		   {
				//read file
				loadData = File.ReadAllLines(path);
		   }
	   }
}
