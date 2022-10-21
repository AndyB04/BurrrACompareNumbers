// Andrea Burr
// 10-18-2022
// Mini4 redo - github
//Peer Review By: Kenneth Fujimura
//Project works. Code is easy to follow. A few points of constructive criticism:
//- There's no real data validation that I can tell. If you wanted to do a data validation on the number inputs to make sure only numbers are inputted, a TryParse like we used in the Codewars would work for that purpose.
//- If I recall the instructions for this project, there are pretty explicit instructions regarding making comparisons between the two inputted numbers. If you want to refactor your program, make sure you're reading the instructions carefully so your program fulfills all of the scenarios that are outlined. For example, your first if else statement only checks to see if one number is bigger than the other, and doesn't account for any scenarios where both numbers are equal.
//- Make sure you're also naming the file folder on your computer, as well as the repository in GitHub with the same naming conventions as outlined in the LMS instructions. That includes adding a program description in your vs code comments, and in the README. And also make sure that the peer review exists both in your README files, as well as in the comments at the top of the vs code in your program.
Console.Clear ();
bool playagain = true;

while (playagain){
    
Console.WriteLine("Lets compare two numbers!");
Console.WriteLine("type your first number");

string numberOne = Console.ReadLine();

Console.WriteLine("Now enter second Number");
string numberTwo = Console.ReadLine();


int num1 = Convert.ToInt32(numberOne);
int num2 = Convert.ToInt32(numberTwo);

if ( num1 > num2 ){
    Console.WriteLine("your first number is bigger than your second number");
}else{
    Console.WriteLine("your first number is smaller than your second number");
}


Console.WriteLine("lets do that again! enter your new number");
Console.ReadLine();

Console.WriteLine("enter second number");
Console.ReadLine();


if (num1 == num2 ){
    Console.WriteLine("your first number is bigger than or equal to your second number");
}else{
    Console.WriteLine("your first number is not bigger than or equal to your second number");
}
Console.WriteLine("if you are done playing type no or press any key to continue");
string contPlay = Console.ReadLine();

  if (contPlay == "no"){

 playagain = false; 
  }else{
    playagain = true;
  }
}

