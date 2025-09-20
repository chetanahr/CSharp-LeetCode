1. Single-pass algorithm
2. Initialize prevRunLength = 0 and currRunLength = 1.
3. Traverse the string from index 1 to end:
4. If s[i] == s[i-1], increment currRunLength.
5. Else (new run):
6. Add Math.Min(prevRunLength, currRunLength) to the answer.
7. Set prevRunLength = currRunLength and currRunLength = 1.
8. After the loop, add Math.Min(prevRunLength, currRunLength) one last time.

**Example **:string "0011001" and see how the single-pass algorithm with prevRunLength and currRunLength works.
**Step 0**: Initialize
prevRunLength = 0
currRunLength = 1 (start counting the first character '0')
count = 0
**Step 1**: Scan the string
  i = 1 → s[1] = '0'
    Same as previous '0' → currRunLength++ = 2
    No new run yet, continue.
  i = 2 → s[2] = '1'
    New run detected ('1' ≠ '0')
    Add valid substrings between previous run and current run:
    Math.Min(prevRunLength, currRunLength) = Math.Min(0, 2) = 0 → count = 0
    Update run lengths:
    prevRunLength = currRunLength = 2
    currRunLength = 1 (start counting new run '1')
  i = 3 → s[3] = '1'
    Same as previous '1' → currRunLength++ = 2
  i = 4 → s[4] = '0'
    New run detected ('0' ≠ '1')
    Add valid substrings:
    Math.Min(prevRunLength, currRunLength) = Math.Min(2, 2) = 2
    count = 0 + 2 = 2 → substrings: "0011", "01"
    Update run lengths:
    prevRunLength = currRunLength = 2
    currRunLength = 1 (new run '0')
  i = 5 → s[5] = '0'
    Same as previous '0' → currRunLength++ = 2
  i = 6 → s[6] = '1'
    New run detected ('1' ≠ '0')
    Add valid substrings:
    Math.Min(prevRunLength, currRunLength) = Math.Min(2, 2) = 2
    count = 2 + 2 = 4 → substrings: "1100", "10"
    Update run lengths:
    prevRunLength = currRunLength = 2
    currRunLength = 1 (new run '1')
**Step 2**: End of string
  Add valid substrings for the last run pair:
  Math.Min(prevRunLength, currRunLength) = Math.Min(2, 1) = 1
  count = 4 + 1 = 5 → substring: "01"
**Step 3**: Result
  Total valid binary substrings = 5
  They are:
  "0011"
  "01" (inside first "0011")
  "1100"
  "10" (inside "1100")
  "01" (at the end)
