function circleArea(arg1) {
    let result;

    let inputType = typeof (arg1);

    if (inputType == 'number') {
        result = Math.pow(arg1, 2) * Math.PI;
        console.log(result.toFixed(2));
    }
    else {
        console.log(`We can not calculate the circle area, because we receive a ${inputType}.`);
    }
}