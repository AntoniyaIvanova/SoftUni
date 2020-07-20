function sumOfNumbersInALoop(firstNumber, secondNumber) {

    let result = 0;

    let num1 = +firstNumber;
    let num2 = +secosndNumber;

    for (let i = num1; i <= num2; i++) {
        result += i;
    }
    return result;
}