function solve(fruit, weight, price) {
    let weightInKg = weight / 1000;
    let totalPrice = weightInKg * price;

    return `I need $${totalPrice.toFixed(2)} to buy ${weightInKg.toFixed(2)} kilograms ${fruit}.`
}



console.log(solve('orange', 2500, 1.80))
console.log(solve('apple', 1563, 2.35))