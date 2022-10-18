// Andrea Burr
// 10-18-2022
// Mini4 redo - github
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

