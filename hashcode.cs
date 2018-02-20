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
	static void inputRead(){
		string[] input = File.ReadAllLines("small.in");

		int Rows,Cols,minIngred,maxCells;
		Rows=Int32.Parse(input[0][0].ToString());
		Cols=Int32.Parse(input[0][2].ToString());
		minIngred=Int32.Parse(input[0][4].ToString());
		maxCells=Int32.Parse(input[0][6].ToString());
		Console.WriteLine(maxCells);
		input[0] = "";

		Console.ReadLine();
		
	}
	
}
