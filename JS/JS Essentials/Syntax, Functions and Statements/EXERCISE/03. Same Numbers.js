function sameNumber(arg1) {

    let numberToCheck = String(arg1);

    let areTheyEqual = true;
    let sum = 0;

    let firstDigit = numberToCheck[0];

    for (let i = 0; i < numberToCheck.length; i++) {
        sum += +numberToCheck[i];

        if (numberToCheck[i] !== firstDigit) {
            areTheyEqual = false;
        }
    }
    
    console.log(areTheyEqual);
    console.log(sum);
}