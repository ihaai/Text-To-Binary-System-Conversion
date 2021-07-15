# What is that?
Program that converts given text to binary system. Keep in mind that the program __cannot__ convert characters like *Æ*, *ç* *à* and the other weird ones.
# How to use it?
Open the executable and write down the text you wish to be converted. Simple as that
# Issues with the program?
If you are having issues with the program open New Issue
# How to check if it works?
Use the following sites since they support binary values on new line:
 * https://www.convertbinary.com/to-text/
 * https://www.rapidtables.com/convert/number/ascii-to-binary.html
# How it works?
I'll try to explain it in simple words.
 * We declare a new Char Array that has our Text values. This is necessary to do because Strings are immuatable otherwise we wouldn't be able to modify them.
 * We declare a string where we are going to store the number reminders ( Example: Letter 'a' -> 97 in ASCII table. We are storing the reminders of the number 97 )
 * We create a for loop that will loop our Char Array from Index 0 to the last Index ( charArray.Lenght )
 * We create a endless while loop. Inside it we are doing our calculations for reminders and other stuff.
 * We are performing a check if our number is less or equals to 0. If that is true, it will add '0' at the end of the string as well as adding space. Then the loop breaks. 
 * We declare a new string that is equals to our storing one. Split it and use lambda expression to reverse the elements inside.
 * Finally, using foreach loop to print our reminders on new line.
