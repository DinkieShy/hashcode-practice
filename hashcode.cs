using System;
using System.IO;

class main{
	static void Main(){
	}
	
	static void printPizza(string[] pizza){
		
	}
	
	static void outputToFile(string[] textToOutput){ //save output to .txt file
		string filename = "./output.txt";
		File.WriteAllLines(filename, textToOutput);
	}
}

class pizza{
	public int maxCells;
	public int rows;
	public int columns;
	public string[,] cells;
}