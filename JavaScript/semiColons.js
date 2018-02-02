//  AUTOMATIC SEMICOLON INSERTION
// There are 3 rules the javascript compiler looks at before it decides
// whether or not it will insert a semicolon after a token

//1.  When a token is encountered as a script or module is parsed from left to right,
// that is not allowed in any production of the grammar, something happened.

// Sweet!! Thanks for the info!



// V --> variable

   var a = 12
   var b = 13  // <-- COMPILER STARTS WITH THE V, THEN PROCESSES THE TOKENS FROM LEFT TO RIGHT
// ^   |_____|  // IT HITS THE NEW LINE CHARACTER (THE BREAK BETWEEN THE VARIABLES) THEN HITS THE NEXT V (VAR)
// |
// V      ^
//        |
//       Tokens

// WHAT THIS RULE IS SAYING IS THAT V ( var a = 12 var b = 13 ) <-- IS NOT ALLOWED IN THIS CONTEXT BECAUSE THE
// PREVIOUS CHARACTER WAS A 12, THE V DOESN'T MAKE SENSE IN THAT CONTEXT, SO THE RULE (AUTO SEMICOLON) KICKS IN.

// SO BASCICALLY IT'S LIKE THIS:

// var a = 12(;) <-- This is the offending token, and it automatically (unbeknownst to you)
// var b = 13(;)     adds a semicolon because the compiler sees it like this if you dont have a semicolon: ( var a = 12 var b = 13 ).


 if(a){console.log(a)}  // <-- Curly braces are affected by this rule as well. This closing curly brace is the offending token so
     console.log(a + b) // it sticks a semicolon right before the closing curly brace.

     // if (a) { console.log(a)(;) } <-- offending token.
