
/* Puts the array code in a try block and
 * catches the index out of range exception
 * if it occurs.
 */

using System;
public class TryException{
  public static void Main(String[] args) 
  {
    int value;
    try 
    {
      int[] anArray = {5,6,7};
      int index = int.Parse(args[0]);
      value = anArray[index];
      Console.WriteLine
         ("Execution does not get here if index is bad");
    }catch (IndexOutOfRangeException e) 
    {
      Console.WriteLine("Stick with 0, 1, or 2");
    }
    Console.WriteLine("This is the end of the program");
  }
}