function cookingByNumbers(arg1) {

    let initialNumber = Number(arg1[0]);

    for (let i = 1; i < arg1.length; i++) {
        let currentOperation = arg1[i];

        if (currentOperation === "chop") {
            initialNumber /= 2;
        }
        else if (currentOperation === "dice") {
            initialNumber = Math.sqrt(initialNumber);
        }
        else if (currentOperation === "spice") {
            initialNumber += 1;
        }
        else if (currentOperation === "bake") {
            initialNumber *= 3;
        }
        else if (currentOperation === "fillet") {
            initialNumber -= initialNumber * 0.20;
        }
        console.log(initialNumber);
    }
}