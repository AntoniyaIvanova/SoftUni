function wordsUppercase(arg1) {
    let turnedToUppercase = arg1.toUpperCase();
    let result = turnedToUppercase.match(/\b(\w+)\b/g);
    console.log(result.join(', '));
}