function fruit(typeOfFruit, weightInGrams, pricePerKg) {

    let fruit = typeOfFruit;
    let weight = weightInGrams / 1000;
    let money = weight * pricePerKg;

    console.log(`I need $${money.toFixed(2)} to buy ${weight.toFixed(2)} kilograms ${fruit}.`)
}