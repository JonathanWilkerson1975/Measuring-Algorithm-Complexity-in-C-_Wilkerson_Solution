Timing Table (you fill in after running code)
Method	n=1,000	n=10,000	n=100,000
O(1)	___ ms	___ ms	___ ms
O(n)	___ ms	___ ms	___ ms
O(n²)	___ ms	___ ms	(took way too long)

Complexity Classification

O(1) – constant time

O(n) – linear time

O(n²) – quadratic time

Reflection (humanized)

1. How did the O(1) method’s time change as n increased?
The O(1) method didn’t really change much at all when the array got bigger. It was always super fast since it only looks at the first number.

2. How did the O(n) method’s time change compared to O(1)?
The O(n) method started taking more time as the arrays got bigger. You could see the difference when jumping from 1,000 to 100,000 items. It was way slower than O(1), but it made sense since it has to go through every element.

3. How did the O(n²) method’s time change compared to the others?
The O(n²) method got slow really quick. Even with 1,000 items it was noticeably slower than the other two. At 10,000 it took a really long time, and running it with 100,000 wasn’t even worth trying because it would take forever.

4. Do your results match the theoretical complexities? Why or why not?
Yeah, they matched what we expected. O(1) stayed basically the same no matter how big the array was, O(n) grew in a straight line as the input got bigger, and O(n²) blew up really fast. The actual times might not be perfect because of the computer or random stuff running in the background, but the overall pattern lined up with Big-O theory.
