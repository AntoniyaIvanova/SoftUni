function calorieObject(arg1) {

    let storage = {};

    for (let i = 0; i < arg1.length; i += 2) {
        let nameOfFood = arg1[i];
        let calories = Number(arg1[i + 1]);
        storage[nameOfFood] = calories;
    }
    console.log(storage);
}