# Delta Encoding

## Problem
Delta encoding is a way of storing data as the difference (delta) between consecutive values instead of the actual values. The first number in the result matches the first number in the original sequence. The other numbers are the differences between adjacent elements.

## Task
Write a method `Delta` that takes an array of integers (`originalNumbers`) and prints the delta-encoded sequence (`deltaEncoded`) to the console, separated by spaces.
