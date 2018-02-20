using System;
using System.IO;

class main{
	static void Main(){
		string[] testText = {"Hi", "This is a test"};
		outputToFile(testText);
	}
	
	static void outputToFile(string[] textToOutput){ //save output to .txt file
		string filename = "./output.txt";
		File.WriteAllLines(filename, textToOutput);
	}
}