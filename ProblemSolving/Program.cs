﻿using ProblemSolving.Core;

string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

int s = Convert.ToInt32(firstMultipleInput[0]);

int t = Convert.ToInt32(firstMultipleInput[1]);

string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

int a = Convert.ToInt32(secondMultipleInput[0]);

int b = Convert.ToInt32(secondMultipleInput[1]);

string[] thirdMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

int m = Convert.ToInt32(thirdMultipleInput[0]);

int n = Convert.ToInt32(thirdMultipleInput[1]);

List<int> apples = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(applesTemp => Convert.ToInt32(applesTemp)).ToList();

List<int> oranges = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(orangesTemp => Convert.ToInt32(orangesTemp)).ToList();

var res = Apple_and_Orange.countApplesAndOranges(s, t, a, b, apples, oranges);
Console.WriteLine(res.NumOfApply);
Console.WriteLine(res.NumOfOrange);
Console.ReadKey();


