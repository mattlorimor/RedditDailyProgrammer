// Matt Lorimor
// Language: F#
// Challenge #122 [Easy] Sum Them Digits - http://www.reddit.com/r/dailyprogrammer/comments/1berjh/040113_challenge_122_easy_sum_them_digits/
// Can be opened Visual Studio

let inputNumber = 1073741824

let subtractNine num =
    num - 9

//Uses the formula from Wikipeda for finding digital roots: http://en.wikipedia.org/wiki/Digital_root
let calculateDigitalRootModulo num =
    num % 9

//While loop version
let calculateDigitalRoot num =
    let mutable continueLoop = true
    let mutable result = subtractNine num
    while continueLoop do
        if result < 10 then
            continueLoop <- false
        else
            result <- subtractNine result
    result

//Recursive version
let rec calculateDigitalRootRecursive num =
    if num >= 10 then
        calculateDigitalRootRecursive (subtractNine num)
    else
        num

let moduloResult = calculateDigitalRootModulo inputNumber
let customResult = calculateDigitalRoot inputNumber
let recursiveResult = calculateDigitalRootRecursive inputNumber

printfn "Modulo-style returned %d." moduloResult
printfn "Custom-style returned %d." customResult
printfn "Recursive-style returned %d." recursiveResult