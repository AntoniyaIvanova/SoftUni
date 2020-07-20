function functionalCalculator(arg1, arg2, arg3) {
    let firstNumber = Number(arg1);
    let secondNumber = Number(arg2);
    let opera = arg3;
    let result = 0;

    switch (opera) {
        case '+':
            return result = firstNumber + secondNumber;
            break;
        case '-':
            return result = firstNumber - secondNumber;
            break;
        case '*':
            return result = firstNumber * secondNumber;
            break;
        case '/':
            return result = firstNumber / secondNumber;
            break;
    }
}