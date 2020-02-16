using System;
using System.Collections.Generic;
using System.Linq;

namespace FunctionJunctionDotNet
{
  public static class FunctionJunction
  {
    /**
     * 1) Define a function max() that takes two numbers as arguments
     * and returns the largest of them. Use the if-then-else
     * construct available in Javascript.
     */

    // ...

    /**
     * 2) Define a function maxOfThree() that takes three
     * numbers as arguments and returns the largest of them.
     */

    // ...

    /*
     * 3) Define a function sum() that takes two numbers as
     * arguments and computes the sum of those two numbers.
     */

    // ...

    /*
     * 4) Define a function sumOfArray that calculates the sum of
     * all the numbers in an array.
     */

    // ...

    /**
     * 5) Write a function isVowel() that takes a character (i.e. a string of length 1)
     * and returns true if it is a vowel, false otherwise.
     */

    // ...

    /**
     * 6) Write a function rovarspraket() that will translate
     * a text into a "rövarspråket". That is, double every
     * consonant and place an occurrence of "o" in between.
     *
     * For example, rovarspraket("this is fun") should
     * return the string "tothohisos isos fofunon".
     */

    // ...

    /**
     * 7) Define a function reverse() that computes
     * the reversal of a string. For example,
     * reverse("skoob") should return the
     * string "books".
     */

    // ...

    /**
     * 8) Write a function findLongestWord() that takes an
     * string returns the first, longest word in the array.
     *
     * i.e. findLongestWord("book dogs") should return "book"
     */
    internal static int Max(int a, int b)
    {
      return a > b ? a : b;
    }

    internal static int MaxOfThree(int a, int b, int c)
    {
      return Max(a, b) == a ? Max(a, c) : Max(b, c);
    }

    internal static int Sum(int a, int b)
    {
      return a + b;
    }

    internal static int SumList(List<int> numbers)
    {
      return numbers.Sum();
    }
  }
}