/* Функции в программировании
void SelectionSort(int[] array)
{  
 for (int i = 0; i < array.Length - 1; i++)
 {
 int minPosition = i;
 for (int j = i + 1; j < array.Length; j++)
 {
 if (array[j] < array[minPosition])
 {
 minPosition = j;
 }
 }
 int temporary = array[i];
 array[i] = array[minPosition];
 array[minPosition] = temporary;
 }
}
*/
/* string Method5(int count, string text)    
{    
          string textLine = string.Empty;
          for (int i =0; i < count; i++)
          {
            textLine = textLine + text ;
            i++;
          }
          return (textLine);
}

string CurrentPrompt = Method5(3,"Bujaka buyaka! ");
Console.WriteLine($"{CurrentPrompt}");
*/
/*
int multiRes = 0;
for(int i =2; i < 10; i++)
{
    for (int j =2; j < 10; j++)
    { 
        multiRes = j * i;
        Console.WriteLine($"{i} * {j} = {multiRes}");
    }
    Console.WriteLine();
}
*/
string textOrigin = "- Я думаю , - сказал князь, улыбаясь, "
+ " что ежели бы вас послали вместо нашего милого Винцегерольда"
+ " вы бы взяли приступом согласие прусского короля"
+ " Вы так красноречивы, вы дадите мне чаю?";

string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty;
    int stringLength = text.Length;

    for (int i = 0; i < stringLength; i++)
    {
        if (Equals(text[i], oldValue))
        {
            result = result + $"{newValue}";
        }
        else
        {
            result = result + $"{text[i]}";
        }
    }

    return (result);
}

string newText = Replace(textOrigin, 'я', '&');
Console.WriteLine($"{newText}");


/* int [] arr = {1,5,4,3,2,6,7,1,1};

void PrintArray(int [] array)
{
    for(int i =1 ; i < array.Length; i++ ) 
    {
     Console.Write($"{array[i]}, "); 
    }
   Console.WriteLine(); 
} 

PrintArray(arr);

void SelectionSort(int [] array)

{ 
    for (int i =0; i < array.Length - 1; i++)
    { 
        int minPosition = i;
        
          for (int j=i+1; j < array.Length;j++)
            {  
              if (array[j] < array[minPosition]) minPosition  = j; 
            }
    
                
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary; 
    }
} 


SelectionSort (arr);
PrintArray(arr); 
*/