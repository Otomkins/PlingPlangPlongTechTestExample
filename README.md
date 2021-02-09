# PlingPlangPlong Tech Test Example

### Summary:

An example of a tech test. Similar to FizzBuzz, this exercise required me to create a method that takes in a number. I needed to extract all the factors of this number and then return a combination of "Pling", "Plang" and "Plong". If the number had a factor of 3, I would return 'Pling'. A factor of 5 would return 'Plang', a factor of 7 would return 'Plong', and a number that does not have a factor of 3, 5 or 7 would return the inputted number as a string. A number with multiple factors would return a combination of the 3. For example, including factors of 3, 5 and 7 would return "PlingPlangPlong, and a number with factors of 5 and 7 would return "PlangPlong".

### Architecture:

There are two projects in my solution, a test project and a class library. In the class library, I have two methods to test against. The fist was used for testing purposes. The method would accept the chosen number as a parameter, iterate through it and determine if its preceding values include these factors of the number. Using the list return of this method, I was able to first test if I was accurately retrieving the factors of any number that was passed into the method.

```c#
    public List<int> ReturnFactors(int num)
    {
        var numFactors = new List<int>();

        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0) numFactors.Add(i);
        }

        return numFactors;
    }
```
Once I was sure that I was receiving the correct results, I could test against the rest of the specifications. The other method in my library took the same approach to gather the factors of the number. Using if statements, I was then able to determine if this included 3, 5 and 7, and added the appropriate string name to a variable. This variable could then be returned and tested against. Additional if statements were used to determine if the entered number was a minus number or zero. The minus number would be handled in a similar way and the zero would return "PlingPlangPlong".

```c#
    public string PlingPlangPlong(int num)
    {
        var numFactors = new List<int>();
        var returnString = "";

        if (num < 0)
        {
            for (int i = -1; i >= num; i--)
            {
                if (num % i == 0) numFactors.Add(i);
            }
            if (numFactors.Contains(-3)) returnString += "Pling";
            if (numFactors.Contains(-5)) returnString += "Plang";

            if (numFactors.Contains(-7)) returnString += "Plong";
            else if (!numFactors.Contains(-3) && !numFactors.Contains(-5)) return num.ToString();
        }
        else if (num == 0)
        {
            return "PlingPlangPlong";
        }
        else
        {
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0) numFactors.Add(i);
            }
            if (numFactors.Contains(3)) returnString += "Pling";
            if (numFactors.Contains(5)) returnString += "Plang";

            if (numFactors.Contains(7)) returnString += "Plong";
            else if (!numFactors.Contains(3) && !numFactors.Contains(5)) return num.ToString();
        }
        return returnString;
    }
```
### Testing:

As mentioned previously, I used the first ReturnFactors method to test if I was accurately retrieving the correct factors. I used multiple test cases to test this. From here, I tested the PlingPlangPlong method. I used separate tests to cover each scenario. These include testing for all factors being included, none of the factors being included, and each combination of them in between. From here, I also added another testcase to each test to check if the same value but minus works in the expected way. Then i added one final test to cover the scenario of a 0 being entered into the method.

