function squareOfStars(n) {

    let number;

    let nType = typeof (n);

    if (nType == 'number') {
        number = n;
    }
    else {
        number = 5;
    }

    function printStars(count = number) {
        console.log("*" + " *".repeat(count - 1));
    }
    for (let i = 1; i <= number; i++)
        printStars();
}