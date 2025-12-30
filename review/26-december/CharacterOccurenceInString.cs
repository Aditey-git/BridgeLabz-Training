using System;

public class CharacterOccurence{
	public static void Main(){
		int[] map = new int[26];
		
		string str = Console.ReadLine();
		string stringNew = str.ToLowerCase();
		
		for(int i = 0; i < str.Length;i++){
			map[(int)stringNew[i]-97]++;
		}
		
		for(int i = 0; i < 26;i++){
			if(map[i] != 0){
				Console.WriteLine(((char)(i+97)) + "=" + map[i]);
			}
				
		}
			
	}
}