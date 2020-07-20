function stringLength(arg1, arg2, arg3) {
    let sumLength;
    let averageLength;

    let firstArgLength = arg1.length;
    let secondArgLength = arg2.length;
    let thirdArgLength = arg3.length;

    sumLength = firstArgLength + secondArgLength + thirdArgLength;
    averageLength = Math.floor(sumLength / 3);

    console.log(sumLength);
    console.log(averageLength);
}