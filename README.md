# SOLUTION TO LEETCODE PROBLEM 1672 - C#

This is my solution to LeetCode Problem 1672 - **Richest Customer Wealth** - in C# and a brief explanation

Link to problem on LeetCode -> [https://leetcode.com/problems/richest-customer-wealth/](https://leetcode.com/problems/richest-customer-wealth/)

## PROJECT EXPLANATION

I have created a new project in _Visual Studio 2022 Community Edition_, selected the **Console App** project template, named the project **RichestCustomerWealth**, selected _.NET Core 3.1 (Out of support) Framework_.

I have two classes, **Program** class and **Solution** class.

## CODE EXPLANATION

### Program class 

I am using the automatically generated **Program** class and **Main** function.

```cs
internal class Program
{
    static void Main(string[] args)
    {
```

Firstly, the **accounts** numeric (int) 2D array (int[][]) is initialized by using basic 2D array initialization. This part of code is commented out currently.

```cs
int[][] accounts =
{
    new int[] { 1, 2, 3 },
    new int[] { 3, 2, 1 }
};
```

Currently, the **nums** numeric (int) 2D array is initialized by using next structure:

- Console Write -> where it displays that the number of accounts must be inputted [1. dimension].
- int input1 = int Parse Console ReadLine -> where user input is stored into a numeric input (int).
- Console Write -> where it displays that the number of values must be inputted [2. dimension].
- int input2 = int Parse Console ReadLine -> where user input is stored into a numeric input (int).
- int[][] array = new int[input1][] -> where new 2D array is initialized and instantiated with the length specified in input1.
- for loop -> which iterates from _0 to input1_.
- array[i] = new int[input2] -> where new 1D array is initialized and instantiated with the length specified in input1.
- for loop -> which iterates from _0 to input2_.
- Console Write -> where it displays which array member's value needs to be inputted.
- array[i][j] = int Parse Console ReadLine -> where user input is stored into the array.

```cs
Console.Write("What is the number of accounts: ");
int accountsLength = int.Parse(Console.ReadLine());
Console.Write("What is the number of values: ");
int valuesLength = int.Parse(Console.ReadLine());
int[][] accounts = new int[accountsLength][];
for (int i = 0; i < accountsLength; i++)
{
    accounts[i] = new int[valuesLength];
    for (int j = 0; j < valuesLength; j++)
    {
        Console.Write($"Enter account[{i + 1}][{j + 1}] value: ");
        accounts[i][j] = int.Parse(Console.ReadLine());
    }
}
```

---

<details>
<summary>CODE EXPLAINED IN GREATER DETAIL</summary><br>
- When initializing a 2D array and at once filling it with values, notice that array Length does not need to be specified. This is because the Length of the array is implied by the number of array submembers and their values provided. Also, array does not need to be specifically instantiated (new int[input][]). This is because instantiation is implied.<br><br>
- When initializing a 2D array first before filling it with values, array Length needs to be specified and array needs to be specifically instantiated (new int[input1][]).<br><br>
- When initializing each of the array submembers first before filling it with values, array Length needs to be specified and array needs to be specifically instantiated (new int[input2]).<br><br>
- Notice that you cannot at the start instantiate the 2D array by providing both Length values (new int[input1][input2]). You need to instantiate array submembers one at a time, after instantiating the 2D array itself.<br><br>
- Console.ReadLine always takes user input in a text format (string) . To convert the text input (string) into a numeric input (int) -> int Parse needs to be used.<br><br>
- 2D array submembers can be accessed by using array[i]. 2D array values can be accessed by using array[i][j].<br><br>
- Notice that you could have 1D arrays with different number of values stored inside.<br>
</details>

---

Next, the **MaximumWealth** function from **Solution** class is called. It takes a 2D array (_int[][] array_) and returns an int (_int maxAccountSum_). The returned int is stored into a new int named **maxAccountSum**. The returned int is then printed out to the console.

```cs
int maxAccountSum = Solution.MaximumWealth(accounts);
Console.WriteLine(maxAccountSum);
```

At the end of the **Program** class there is next structure:

- Console WriteLine -> where it displays that the code is done processing.
- Console ReadLine -> where it waits for user input. Why does it wait for user input? To stop the code from automatically completing and exiting and us not being able to check the result of the code.

```cs
Console.WriteLine("Done processing");
Console.ReadLine();
```

### Solution class 

I have created a new class and named it **Solution**. I have made it public. I have created the **MaximumWealth** function to replicate the example from the LeetCode problem. I have made it static.

```cs
public class Solution
{
    public static int MaximumWealth(int[][] accounts)
    {
```

Firstly, the **maxAccountSum** numeric input (int) is initialized by using basic int initialization. It is set to 0. This numeric input (int) will be used to store the biggest account sum into and return it at the end of the function.

```cs
int maxAccountSum = 0;
```

Secondly, the **for** loop is initialized that iterates from _0 to array Length_.

```cs
for (int i = 0; i < accounts.Length; i++)
{
```

The **currentAccountSum** numeric input (int) is initialized by using basic int initialization. It is set to 0. This numeric input (int) will be used to store current account sum into and to check if it is greater then the maxAccountSum.

```cs
int currentAccountSum = 0;
```

Inside the **for** loop, there is another **for** loop initialized that iterates from _0 to array[i] Length_.

```cs
for (int j = 0; j < accounts[i].Length; j++)
{
```

Every value inside the array[i][j] is being summed into the currentAccountSum numeric input (int).

```cs
currentAccountSum += accounts[i][j];
```

Outside the second for loop, but inside the first one is the **if** statement. It checks if **currentAccountSum** is greater than the **maxAccountSum**. If it is greater, it stores the value of **currentAccountSum** into the **maxAccountSum**.

```cs
if (currentAccountSum > maxAccountSum)
{
    maxAccountSum = currentAccountSum;
}
```

At the end of the **Solution** class, the **maxAccountSum** numeric input (int) is returned.

```cs
return maxAccountSum;
```

## POTENTIAL MISTAKES (I HAVE MADE)

X

## RUNNING THE CODE - RESULT

![image](https://github.com/jerkdavi/LeetCode-Problem-1672-Solution-CSharp/assets/75536158/9aacc160-8404-4f38-9180-bbcae08f11b1) ![image](https://github.com/jerkdavi/LeetCode-Problem-1672-Solution-CSharp/assets/75536158/87058a1b-d431-41ed-b5ee-5456491a5d22) ![image](https://github.com/jerkdavi/LeetCode-Problem-1672-Solution-CSharp/assets/75536158/d3e1e8b6-facd-45ed-97e9-81fa1dcd1ad7)



