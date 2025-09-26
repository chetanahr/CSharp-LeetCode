**Step 1: Calculate the sum and sum of squares**

Use two variables, e.g., sum and sumSquares, both of type long to avoid overflow (since squares can get large).

Loop through the array once:

Add each number to sum.

Add the square of each number to sumSquares.

At the same time, you can compute the expected sum and expected sum of squares for numbers from 1 to n using formulas:

expectedSum = n * (n + 1) / 2

expectedSumSquares = n * (n + 1) * (2n + 1) / 6

**Step 2: Compute differences**

diffSum = sum - expectedSum → this equals D - M (duplicate minus missing).

diffSquares = sumSquares - expectedSumSquares → this equals D^2 - M^2.

**Step 3: Solve for duplicate and missing**

Factor D^2 - M^2 = (D - M)(D + M) → diffSquares / diffSum = D + M.

Now you have:

D - M = diffSum

D + M = diffSquares / diffSum

Solve these two equations to get:

D = (diffSum + (diffSquares / diffSum)) / 2

M = D - diffSum

**Step 4: Return the result**

Once you have D and M, you can store them in a small array, tuple, or return both as separate variables.
