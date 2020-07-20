function mathOperations(firstNumber, secondNumber, operatorName) {

    let result;

    switch (operatorName) {
        case '+':
            result = firstNumber + secondNumber;
            break;
        case '-':
            result = firstNumber - secondNumber;
            break;
        case '/':
            result = firstNumber / secondNumber;
            break;
        case '*':
            result = firstNumber * secondNumber;
            break;
        case '%':
            result = firstNumber % secondNumber;
            break;
        case '**':
            result = firstNumber ** secondNumber;
            break;
    }

    console.log(result);
}